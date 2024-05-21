using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace OpenSpaceComarcal.Libraries
{
    internal class Exportar
    {

        public static void ExportarDataGridViewExcel(DataGridView dataGridView, string nameArchivo, ProgressBar progressBar)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar como";

            DateTime fechaActual = DateTime.Now;
            string fechaHoraFormateada = fechaActual.ToString("yyyy-MM-dd");
            saveFileDialog.FileName = $"OpenSpaceComarcal_{nameArchivo}_{fechaHoraFormateada}.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false;

                try
                {
                    Excel.Workbook workbook = excelApp.Workbooks.Add();
                    Excel.Worksheet worksheet = workbook.Sheets[1];

                    int totalRows = dataGridView.Rows.Count;
                    int totalColumns = dataGridView.Columns.Count;

                    progressBar.Visible = true;
                    progressBar.Maximum = totalRows;

                    object[,] data = new object[totalRows, totalColumns];

                    // Llenar la matriz de datos
                    for (int i = 0; i < totalRows; i++)
                    {
                        for (int j = 0; j < totalColumns; j++)
                        {
                            object cellValue = dataGridView.Rows[i].Cells[j].Value;
                            if (cellValue != null)
                            {
                                if (cellValue is DateTime)
                                {
                                    DateTime fecha = (DateTime)cellValue;
                                    data[i, j] = fecha.ToShortDateString();
                                }
                                else
                                {
                                    data[i, j] = cellValue.ToString();
                                }
                            }
                            else
                            {
                                data[i, j] = "";
                            }
                        }
                        progressBar.Value = i + 1;
                    }

                    // Escribir la matriz de datos en Excel
                    Excel.Range startCell = worksheet.Cells[1, 1];
                    Excel.Range endCell = worksheet.Cells[totalRows, totalColumns];
                    Excel.Range writeRange = worksheet.Range[startCell, endCell];
                    writeRange.Value = data;

                    worksheet.Columns.AutoFit();

                    workbook.SaveAs(filePath);
                    workbook.Close();

                    MessageBox.Show($"La exportación de {nameArchivo} se ha realizado correctamente.\n\nRuta del archivo:\n{filePath}", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al exportar a Excel: {ex.Message}");
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