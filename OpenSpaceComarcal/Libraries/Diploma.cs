using OpenSpaceComarcal.Objects;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace OpenSpaceComarcal.Libraries
{
    internal class Diploma
    {
        public static string generarDiplomaWord(PersDiploma diploma, string rutaDestino, bool saveAsPDF)
        {
            if (diploma.Diploma != "Seleccionar Diploma")
            {
                string anioInicio = diploma.FechaInicio.HasValue ? diploma.FechaInicio.Value.Year.ToString() 
                : DateTime.Now.Year.ToString();
                string mesInicio = diploma.FechaInicio.HasValue ? ObtenerMesEnEspanol(diploma.FechaInicio.Value.Month) 
                : DateTime.Now.ToString("MMMM", new CultureInfo("es-ES"));

                string rutaAnio = Path.Combine(rutaDestino, anioInicio);
                string rutaMes = Path.Combine(rutaAnio, mesInicio);
                string rutaCurso = Path.Combine(rutaMes, $"{diploma.SiglasCurso}_DIA_{diploma.FechaInicio.Value.Day}");

                // Crear las carpetas si no existen
                if (!Directory.Exists(rutaCurso))
                {
                    Directory.CreateDirectory(rutaCurso);
                }

                string nombreArchivo = 
                $"{diploma.InscripcionId}_{diploma.AlumnoNombre}_" +
                $"{diploma.AlumnoApellidos}_" +
                $"{diploma.AlumnoDNI}_" +
                $"{diploma.CodCurso}";
                string rutaDestinoCombinada = Path.Combine(rutaCurso, $"{nombreArchivo}.docx");

                using (DocX document = DocX.Load(diploma.Diploma))
                {
                    // Reemplazar los marcadores de posición en la plantilla con los datos proporcionados
                    document.ReplaceText("<nombre>", diploma.AlumnoNombre); //
                    document.ReplaceText("<apellidos>", diploma.AlumnoApellidos);
                    document.ReplaceText("<num_cod>", diploma.CodCurso);
                    document.ReplaceText("<f_inicio>", diploma.FechaInicio.HasValue ? diploma.FechaInicio.Value.ToString("dd/MM/yyyy") : "");
                    document.ReplaceText("<f_fin>", diploma.FechaFin.HasValue ? diploma.FechaFin.Value.ToString("dd/MM/yyyy") : "");
                    document.ReplaceText("<dni>", diploma.AlumnoDNI);
                    document.ReplaceText("<num_dip>", diploma.InscripcionId.ToString());
                    if (diploma.EmpresaId != null && diploma.EmpresaId != "")
                    {
                        document.ReplaceText("<num_cliente>", diploma.EmpresaId);
                    }
                    else
                    {
                        document.ReplaceText("<num_cliente>", "POO1");
                    }

                    document.ReplaceText("<num_fact>", diploma.NumFactura);
                    document.ReplaceText("num_fact", diploma.NumFactura);
                    document.ReplaceText("<ciudad>", diploma.Ciudad);
                    document.ReplaceText("<f_exp>", diploma.FechaExpedicion.HasValue ? diploma.FechaExpedicion.Value.ToString("dd/MM/yyyy") : "");
                    document.ReplaceText("<", "");
                    document.ReplaceText(">", "");
                    // Guardar el documento Word
                    document.SaveAs(rutaDestinoCombinada);
                }
                if (saveAsPDF)
                {
                    string rutaCarpetaPDF = Path.Combine(rutaCurso, "PDF");
                    string rutaPDF = Path.Combine(rutaCarpetaPDF, $"{nombreArchivo}.pdf");
                    if (!Directory.Exists(rutaCarpetaPDF))
                    {
                        Directory.CreateDirectory(rutaCarpetaPDF);
                    }
                    ConvertirWordAPdf(rutaDestinoCombinada, rutaPDF);
                }
                return rutaCurso;
            }
            return null;
        }
        private static string ObtenerMesEnEspanol(int mes)
        {
            string[] mesesEspanol = {
        "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
        "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
    };

            if (mes >= 1 && mes <= 12)
            {
                return mesesEspanol[mes - 1].ToUpper();
            }
            else
            {
                return "MesInvalido";
            }
        }

        public static void generarControlAsistencia(PersAsistencias asistencia, string rutaDestino, string rutaPlantilla)
        {
            string anioInicio = asistencia.FechaInicio.HasValue ? asistencia.FechaInicio.Value.Year.ToString() 
            : DateTime.Now.Year.ToString();
            string mesInicio = asistencia.FechaInicio.HasValue ? ObtenerMesEnEspanol(asistencia.FechaInicio.Value.Month) 
            : DateTime.Now.ToString("MMMM", new CultureInfo("es-ES"));

            string rutaAnio = Path.Combine(rutaDestino, anioInicio);
            string rutaMes = Path.Combine(rutaAnio, mesInicio);
            string rutaCurso = Path.Combine(rutaMes, $"{asistencia.SiglasCurso}_DIA_{asistencia.FechaInicio.Value.Day}");

            if (!Directory.Exists(rutaCurso))
            {
                Directory.CreateDirectory(rutaCurso);
            }

            string nombreArchivo = $"{asistencia.NombreCurso}_{asistencia.InstanciaId}_" +
                $"{asistencia.CodCurso}";
            DateTime thisTime = DateTime.Now;

            using (DocX document = DocX.Load(rutaPlantilla))
            {
                // Reemplazar los marcadores de posición en la plantilla con los datos proporcionados
                document.ReplaceText("[nom_curso]", asistencia.NombreCurso);
                document.ReplaceText("[cod_curso]", asistencia.CodCurso);
                document.ReplaceText("[sesiones]", asistencia.Sesiones.ToString());
                document.ReplaceText("[fecha_inicio]", asistencia.FechaInicio.HasValue ? asistencia.FechaInicio.Value.ToString("dd/MM/yyyy") : "");
                document.ReplaceText("[fecha_fin]", asistencia.FechaFin.HasValue ? asistencia.FechaFin.Value.ToString("dd/MM/yyyy") : "");

                // Identificar la tabla que contiene el marcador [primer_alumno]
                Xceed.Document.NET.Table tablaAlumnos = null;

                foreach (var table in document.Tables)
                {
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        foreach (var cell in table.Rows[i].Cells)
                        {
                            foreach (var paragraph in cell.Paragraphs)
                            {
                                if (paragraph.Text.Contains("[primer_alumno]"))
                                {
                                    tablaAlumnos = table;
                                    paragraph.ReplaceText("[primer_alumno]", ""); // Eliminar el marcador
                                    break;
                                }
                            }
                            if (tablaAlumnos != null)
                                break;
                        }
                        if (tablaAlumnos != null)
                            break;
                    }
                    if (tablaAlumnos != null)
                        break;
                }

                // Verificar si se encontró la tabla correcta
                if (tablaAlumnos == null)
                {
                    MessageBox.Show("No se encontró el marcador [primer_alumno] en ninguna tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Insertar alumnos desde la fila 8
                int alumnoIndex = 0;
                for (int i = 9; i < tablaAlumnos.Rows.Count && alumnoIndex < asistencia.Alumnos.Count; i++)
                {
                    var row = tablaAlumnos.Rows[i];
                    if (row.Cells.Count >= 3)
                    {
                        row.Cells[1].Paragraphs[0].Append(asistencia.Alumnos[alumnoIndex].apellidos);
                        row.Cells[2].Paragraphs[0].Append(asistencia.Alumnos[alumnoIndex].nombre);
                        row.Cells[3].Paragraphs[0].Append(asistencia.Alumnos[alumnoIndex].dni_nie_pasp);
                        alumnoIndex++;
                    }
                }
                // Guardar el documento Word
                if (!(asistencia.Sesiones > 1))
                {
                    string rutaDestinoCombinada = Path.Combine(rutaCurso, $"{nombreArchivo}.docx");
                    document.SaveAs(rutaDestinoCombinada);
                }
                else
                {
                    for (int i = 0; i < asistencia.Sesiones; i++) {
                        string nombreArchivoConIndice = $"S{i + 1}_{nombreArchivo}.docx";
                        string rutaDestinoConIndice = Path.Combine(rutaCurso, nombreArchivoConIndice);
                        document.SaveAs(rutaDestinoConIndice);
                    }
                }
                

            }
        }

        public static void ConvertirWordAPdf(string rutaArchivoWord, string rutaArchivoPdf)
        {
            Microsoft.Office.Interop.Word.Application wordApp = null;
            Microsoft.Office.Interop.Word.Document wordDoc = null;

            try
            {
                wordApp = new Microsoft.Office.Interop.Word.Application { Visible = false };

                wordDoc = wordApp.Documents.Open(rutaArchivoWord, ReadOnly: true, Visible: false);
                wordDoc.SaveAs2(rutaArchivoPdf, Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatPDF);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al convertir Word a PDF: " + ex.Message);
            }
            finally
            {
                if (wordDoc != null)
                {
                    wordDoc.Close(false);
                    Marshal.ReleaseComObject(wordDoc);
                    wordDoc = null;
                }

                if (wordApp != null)
                {
                    wordApp.Quit();
                    Marshal.ReleaseComObject(wordApp);
                    wordApp = null;
                }

                // Recolectar basura inmediatamente después de liberar recursos
                GC.Collect();
                GC.WaitForPendingFinalizers();

                // Realizar segunda recolección para asegurar la limpieza de los RCWs
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        public static void combinarDiplomas(String rutaCarpeta)
        {
            try
            {
                string carpeta = rutaCarpeta;

                var archivosDocx = Directory.GetFiles(carpeta, "*.docx");

                if (archivosDocx.Length == 0)
                {
                    MessageBox.Show("No se encontraron archivos .docx en la carpeta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    string archivoCombinadoPath = Path.Combine(carpeta, "COMBINADO.docx");

                    using (var docCombinado = DocX.Create(archivoCombinadoPath))
                    {
                        foreach (var archivo in archivosDocx)
                        {
                            using (var documento = DocX.Load(archivo))
                            {
                                docCombinado.InsertDocument(documento);
                            }
                        }
                        docCombinado.Save();
                    }

                    using (var docCombinado = DocX.Load(archivoCombinadoPath))
                    {
                        var primeraPagina = docCombinado.Paragraphs.First();
                        primeraPagina.Remove(false);

                        // Guardar los cambios
                        docCombinado.Save();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al combinar los archivos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}