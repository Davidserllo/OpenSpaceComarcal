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

                    foreach (var row in worksheet.RowsUsed().Skip(1))
                    {
                        DateTime? fechaRegistro = null;
                        string fechaRegistroRaw = row.Cell(4).GetValue<string>();
                        if (DateTime.TryParse(fechaRegistroRaw, out DateTime parsedDate))
                        {
                            fechaRegistro = parsedDate;
                        }
                        // Crear una instancia de Alumno y llenar con datos de la fila
                        var alu = new alumno
                        {
                            dni_nie_pasp = row.Cell(1).GetValue<string>(),
                            apellidos = row.Cell(2).GetValue<string>(),
                            nombre = row.Cell(3).GetValue<string>(),
                            telefono = row.Cell(4).GetValue<string>(),
                            email = row.Cell(5).GetValue<string>(),
                            id_empresa = int.TryParse(row.Cell(6).GetValue<string>(), out int idEmpresa) ? idEmpresa : (int?)null,
                            fecha_registro = fechaRegistro,
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

        public static List<inscripcion> importarInscripcionesDeExcel(string rutaExcel)
        {
            var inscripciones = new List<inscripcion>();
            try
            {
                using (var workbook = new XLWorkbook(rutaExcel))
                {
                    var worksheet = workbook.Worksheet(1);

                    foreach (var row in worksheet.RowsUsed().Skip(1))
                    {
                        DateTime? fechaInscripcion = null;
                        DateTime? fechaExpedicion = null;
                        string fechaInscripcionRaw = row.Cell(4).GetValue<string>();  
                        string fechaExpedicionRaw = row.Cell(5).GetValue<string>();  
                        if (DateTime.TryParse(fechaInscripcionRaw, out DateTime parsedDate))
                        {
                            fechaInscripcion = parsedDate; 
                        }
                        if (DateTime.TryParse(fechaExpedicionRaw, out DateTime parsedDate2))
                        {
                            fechaExpedicion = parsedDate;
                        }
                        var ins = new inscripcion
                        {
                            id_alumno = row.Cell(1).GetValue<int>(),
                            id_instancia = row.Cell(2).GetValue<int>(),
                            id_empresa = int.TryParse(row.Cell(3).GetValue<string>(), out int idEmpresa) ? idEmpresa : (int?)null,
                            fecha_inscripcion = fechaInscripcion,
                            fecha_expedicion = fechaExpedicion,
                            apto = bool.TryParse(row.Cell(6).GetValue<string>(), out bool aptoBool) && aptoBool,
                            cod_factura = row.Cell(7).GetValue<string>(),
                        };
                        inscripciones.Add(ins);
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Un proceso esta usando este excel, cierrelo o finalice el proceso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return inscripciones;
        }
    }
}
