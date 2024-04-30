﻿using Microsoft.Office.Interop.Word;
using OpenSpaceComarcal.Objects;
using System;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace OpenSpaceComarcal.Libraries
{
    internal class Diploma
    {
        public static void generarDiplomaWord(PersDiploma diploma, string rutaDestino, bool saveAsPDF)
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
                Properties.Settings.Default.CONTADOR_DIPLOMAS = 1;
                Properties.Settings.Default.Save();
            }
        }

        public static void ConvertirWordAPdf(string rutaArchivoWord, string rutaArchivoPdf)
        {
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document wordDoc = null;
            try
            {
                wordApp.Visible = false;

                // Abrir el archivo Word
                wordDoc = wordApp.Documents.Open(rutaArchivoWord, ReadOnly: false, Visible: false);

                // Guardar el archivo Word como PDF
                wordDoc.SaveAs2(rutaArchivoPdf, WdSaveFormat.wdFormatPDF);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al convertir el archivo Word a PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar el archivo Word
                wordDoc?.Close(false);
                Marshal.ReleaseComObject(wordDoc);

                // Cerrar la aplicación de Word
                wordApp.Quit();
                Marshal.ReleaseComObject(wordApp);
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

    }
}