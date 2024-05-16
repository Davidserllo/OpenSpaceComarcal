using ClosedXML.Excel;
using OpenSpaceComarcal.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSpaceComarcal.Libraries
{
    public class Importar
    {
        public static List<alumno> importarAlumnosDeExcel(string rutaExcel)
        {
            var alumnos = new List<alumno>();

            try
            {
                using (var workbook = new XLWorkbook(rutaExcel))
                {
                    // Acceder a la primera hoja
                    var worksheet = workbook.Worksheet(1);

                    foreach (var row in worksheet.RowsUsed())
                    {
                        // Crear una instancia de Alumno y llenar con datos de la fila
                        var alu = new alumno
                        {
                            dni_nie_pasp = row.Cell(1).GetValue<string>(),
                            apellidos = row.Cell(2).GetValue<string>(),
                            nombre = row.Cell(3).GetValue<string>(),
                            telefono = row.Cell(4).GetValue<string>(),
                            email = row.Cell(5).GetValue<string>(),
                            id_empresa = row.Cell(6).GetValue<int>(),
                            fecha_registro = row.Cell(7).GetValue<DateTime>(),
                            notas = row.Cell(8).GetValue<string>(),
                        };

                        // Añadir el alumno a la lista
                        alumnos.Add(alu);
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Un proceso esta usando este excel, cierrelo o finalice el proceso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return alumnos;
        }
    }
}
