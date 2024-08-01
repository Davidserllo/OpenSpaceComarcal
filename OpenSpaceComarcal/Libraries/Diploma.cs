using OpenSpaceComarcal.Objects;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace OpenSpaceComarcal.Libraries
{
    internal class Diploma
    {
        public static void generarDiplomaWord(PersDiploma diploma, string rutaDestino, bool saveAsPDF)
        {
            if (diploma.Diploma != "Seleccionar Diploma")
            {

                string nombreArchivo = $"{diploma.InscripcionId}_{diploma.AlumnoNombre}_" +
                $"{diploma.AlumnoApellidos}_" +
                $"{diploma.AlumnoDNI}_" +
                $"{diploma.CodCurso}";
                string rutaDestinoCombinada = Path.Combine(rutaDestino, $"{nombreArchivo}.docx");

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
                    string rutaCarpetaPDF = Path.Combine(rutaDestino, "PDF");
                    string rutaPDF = Path.Combine(rutaCarpetaPDF, $"{nombreArchivo}.pdf");
                    if (!Directory.Exists(rutaCarpetaPDF))
                    {
                        Directory.CreateDirectory(rutaCarpetaPDF);
                    }
                    ConvertirWordAPdf(rutaDestinoCombinada, rutaPDF);
                }
            }
        }

        public static void generarControlAsistencia(PersAsistencias asistencia, string rutaDestino, string rutaPlantilla)
        {
            string nombreArchivo = $"{asistencia.InstanciaId}_{asistencia.NombreCurso}_" +
                $"{asistencia.CodCurso}";
            string rutaDestinoCombinada = Path.Combine(rutaDestino, $"{nombreArchivo}.docx");
            DateTime thisTime = DateTime.Now;

            using (DocX document = DocX.Load(rutaPlantilla))
            {
                // Reemplazar los marcadores de posición en la plantilla con los datos proporcionados
                document.ReplaceText("[nom_curso]", asistencia.NombreCurso);
                document.ReplaceText("[cod_curso]", asistencia.CodCurso);
                document.ReplaceText("[sesiones]", asistencia.Sesiones.ToString());
                document.ReplaceText("[fecha_actual]", thisTime.ToString("dd/MM/yyyy"));
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
                document.SaveAs(rutaDestinoCombinada);

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

    }
}