using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace OpenSpaceComarcal.Libraries
{
    internal class Exportar
    {

        public static void ExportarDataGridViewExcel(DataGridView dataGridView, String nameArchivo)
        {
            // Crear un diálogo de guardado de archivos
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar como";

            // Obtiene la fecha actual para el nombre predeterminado del archivo
            DateTime fechaActual = DateTime.Now;
            string fechaHoraFormateada = fechaActual.ToString("yyyy-MM-dd"); // Para añadir la hora "yyyy-MM-dd_HH:mm"
            saveFileDialog.FileName = "OpenSpaceComarcal_" + nameArchivo + "_" + fechaHoraFormateada + ".xlsx"; // Nombre predeterminado del archivo

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado por el usuario
                string filePath = saveFileDialog.FileName;

                // Crear una instancia de Excel
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false; // Oculta la aplicación de Excel

                try
                {
                    Excel.Workbook workbook = excelApp.Workbooks.Add();
                    Excel.Worksheet worksheet = workbook.Sheets[1];

                    // Exportar los encabezados de las columnas
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
                    }

                    // Exportar los datos de las celdas
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            if (dataGridView.Rows[i].Cells[j].Value is DateTime)
                            {
                                DateTime fecha = (DateTime)dataGridView.Rows[i].Cells[j].Value;
                                // Formatear la fecha y alinear el texto a la izquierda
                                worksheet.Cells[i + 2, j + 1].NumberFormat = "@";
                                worksheet.Cells[i + 2, j + 1] = fecha.ToShortDateString();
                            }
                            else
                            {
                                // Si no es una fecha, solo se escribe el valor
                                worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }

                    // Ajustar el ancho de las columnas automáticamente
                    worksheet.Columns.AutoFit();

                    // Guardar el archivo Excel en la ubicación seleccionada por el usuario
                    workbook.SaveAs(filePath);
                    workbook.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar a Excel: " + ex.Message);
                }
                finally
                {
                    excelApp.Quit();
                    ReleaseObject(excelApp);
                }
            }
        }

        // Método para liberar recursos COM
        private static void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Error al liberar objeto " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

    }
}