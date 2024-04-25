using Microsoft.Office.Interop.Word;
using OpenSpaceComarcal.Objects;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace OpenSpaceComarcal.Libraries
{
    internal class Diploma
    {
        // Rutas de guardado de los archivos
        private static string WORDFOLDER = @"Z:\PRACTICAS-IT\DIPLOMAS\WORD";
        private static string PDFFOLDER = @"Z:\PRACTICAS-IT\DIPLOMAS\PDF";

        // Cargar la plantillas
        private static string PLANTILLAPATHWORD = @"Z:\PRACTICAS-IT\DIPLOMAS\PlantillaEjemplo.docx";

        public static void GenerarDiploma(
            string nombreAlumno, string apellidoAlumno, string dni, string numeroAlumno, string numeroFactura,
            DateTime fechaInicio, DateTime fechaFin, DateTime fechaExpedicion, string codigoCurso, string numeroDiploma, string ciudad)
        {

            // Nombre del archivo
            string nombreArchivo = $"{nombreAlumno}_{apellidoAlumno}_{dni}";
            string rutaWord = Path.Combine(WORDFOLDER, $"{nombreArchivo}.docx");
            string rutaPDF = Path.Combine(PDFFOLDER, $"{nombreArchivo}.pdf");

            // Crear el documento Word usando la plantilla
            using (DocX document = DocX.Load(PLANTILLAPATHWORD))
            {
                // Reemplazar los marcadores de posición en la plantilla con los datos proporcionados
                document.ReplaceText("<nombre>", nombreAlumno); //
                document.ReplaceText("<apellidos>", apellidoAlumno);
                document.ReplaceText("<num_cod>", codigoCurso);
                document.ReplaceText("<f_inicio>", fechaInicio.ToString("dd/MM/yyyy"));
                document.ReplaceText("<f_fin>", fechaFin.ToString("dd/MM/yyyy"));
                document.ReplaceText("<dni>", dni);
                document.ReplaceText("<num_dip>", numeroDiploma);
                document.ReplaceText("<num_cliente>", numeroAlumno);
                document.ReplaceText("<num_fact>", numeroFactura); // La platilla tiene una separacion *SE DEBE CORREGIR*
                document.ReplaceText("<ciudad>", ciudad);
                document.ReplaceText("<f_exp>", fechaExpedicion.ToString("dd/MM/yyyy"));

                // Guardar el documento Word
                document.SaveAs(rutaWord);
            }

            // Convertir el documento Word a PDF
            ConvertirWordAPdf(rutaWord, rutaPDF);

            //MessageBox.Show("Diploma de " + nombreAlumno + " generado correctamente", "Diplomas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void generarDiplomaWord(PersDiploma diploma, string rutaDestino)
        {
            if (diploma.Diploma != "Seleccionar Diploma")
            {
                int contador = Properties.Settings.Default.CONTADOR_DIPLOMAS;

                string nombreArchivo = $"{contador}_{diploma.AlumnoNombre}_" +
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
                    document.ReplaceText("<f_inicio>", diploma.FechaInicio.ToString());
                    document.ReplaceText("<f_fin>", diploma.FechaFin.ToString());
                    document.ReplaceText("<dni>", diploma.AlumnoDNI);
                    document.ReplaceText("<num_dip>", contador.ToString());
                    document.ReplaceText("<num_cliente>", diploma.AlumnoDNI);
                    document.ReplaceText("num_fact", diploma.NumFactura); // La platilla tiene una separacion *SE DEBE CORREGIR*
                    document.ReplaceText("<ciudad>", diploma.Ciudad);
                    document.ReplaceText("<f_exp>", diploma.FechaExpedicion.ToString());

                    // Guardar el documento Word
                    document.SaveAs(rutaDestinoCombinada);
                }
                Properties.Settings.Default.CONTADOR_DIPLOMAS = 1;
                Properties.Settings.Default.Save();
            }
        }

        public static void GenerarDiplomaRutaDestino(
            string nombreAlumno, string apellidoAlumno, string dni, string numeroAlumno, string numeroFactura,
            DateTime fechaInicio, DateTime fechaFin, DateTime fechaExpedicion, string codigoCurso, string numeroDiploma, string ciudad)
        {

            // Nombre del archivo
            string nombreArchivo = $"{nombreAlumno}_{apellidoAlumno}_{dni}";
            string rutaWord = Path.Combine(WORDFOLDER, $"{nombreArchivo}.docx");
            string rutaPDF = Path.Combine(PDFFOLDER, $"{nombreArchivo}.pdf");

            // Crear el documento Word usando la plantilla
            using (DocX document = DocX.Load(PLANTILLAPATHWORD))
            {
                // Reemplazar los marcadores de posición en la plantilla con los datos proporcionados
                document.ReplaceText("<nombre>", nombreAlumno); //
                document.ReplaceText("<apellidos>", apellidoAlumno);
                document.ReplaceText("<num_cod>", codigoCurso);
                document.ReplaceText("<f_inicio>", fechaInicio.ToString("dd/MM/yyyy"));
                document.ReplaceText("<f_fin>", fechaFin.ToString("dd/MM/yyyy"));
                document.ReplaceText("<dni>", dni);
                document.ReplaceText("<num_dip>", numeroDiploma);
                document.ReplaceText("<num_cliente>", numeroAlumno);
                document.ReplaceText("<num_fact>", numeroFactura); // La platilla tiene una separacion *SE DEBE CORREGIR*
                document.ReplaceText("<ciudad>", ciudad);
#pragma warning disable CS0618 // Type or member is obsolete
                document.ReplaceText("<f_exp>", fechaExpedicion.ToString("dd/MM/yyyy"));
#pragma warning restore CS0618 // Type or member is obsolete

                // Guardar el documento Word
                document.SaveAs(rutaWord);
            }

            // Convertir el documento Word a PDF
            ConvertirWordAPdf(rutaWord, rutaPDF);

            //MessageBox.Show("Diploma de " + nombreAlumno + " generado correctamente", "Diplomas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ConvertirWordAPdf(string rutaArchivoWord, string rutaArchivoPdf)
        {
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            try
            {
                wordApp.Visible = false;

                // Abrir el archivo Word
                Microsoft.Office.Interop.Word.Document wordDoc = wordApp.Documents.Open(rutaArchivoWord);

                // Guardar el archivo Word como PDF
                wordDoc.SaveAs2(rutaArchivoPdf, WdSaveFormat.wdFormatPDF);

                // Cerrar el archivo Word
                wordDoc.Close();

                // Cerrar la aplicación de Word
                wordApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al convertir el archivo Word a PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurarse de que se cierre la aplicación de Word
                if (wordApp != null)
                {
                    wordApp.Quit();
                }
            }
        }

    }
}