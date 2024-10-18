using ClosedXML.Excel;
using OpenSpaceComarcal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace OpenSpaceComarcal.Libraries
{
    public class Importar
    {
        public static List<alumno> importarAlumnosDeExcel(string rutaExcel, ProgressBar progressBar)
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
                        // Crear una instancia de Alumno y llenar con datos de la fila
                        var alu = new alumno
                        {
                            dni_nie_pasp = row.Cell(1).GetValue<string>(),
                            apellidos = row.Cell(2).GetValue<string>(),
                            nombre = row.Cell(3).GetValue<string>(),
                            telefono = row.Cell(4).GetValue<string>(),
                            email = row.Cell(5).GetValue<string>(),
                            id_empresa = int.TryParse(row.Cell(6).GetValue<string>(), out int idEmpresa) ? idEmpresa : (int?)null,
                            fecha_registro = DateTime.Today,
                            notas = row.Cell(7).GetValue<string>(),
                        };
                        
                        // Añadir el alumno a la lista
                        alumnos.Add(alu);
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Un proceso esta usando este excel, cierrelo o finalice el proceso. {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        var alu = new alumno
                        {
                            dni_nie_pasp = row.Cell(1).GetValue<string>(),
                            apellidos = row.Cell(2).GetValue<string>(),
                            nombre = row.Cell(3).GetValue<string>(),
                            telefono = row.Cell(4).GetValue<string>(),
                            email = row.Cell(5).GetValue<string>(),
                            id_empresa = int.TryParse(row.Cell(6).GetValue<string>(), out int idEmpresa) ? idEmpresa : (int?)null,
                            fecha_registro = DateTime.Today,
                            notas = row.Cell(7).GetValue<string>(),
                        };

                        int idAlumno = AlumnosOrm.SelectID(alu.dni_nie_pasp, alu.apellidos);

                        if (idAlumno == 0)
                        {
                            AlumnosOrm.Insert(alu);
                        }

                        int idInstancia = row.Cell(8).GetValue<int>();
                        DateTime? fechaInicioCurso = InstanciaOrm.SelectDate(idInstancia);
                        DateTime? fechaFinCurso = InstanciaOrm.SelectEndDate(idInstancia);

                        idAlumno = AlumnosOrm.SelectID(alu.dni_nie_pasp, alu.apellidos);

                        var ins = new inscripcion
                        {

                            id_alumno = idAlumno,
                            id_instancia = row.Cell(8).GetValue<int>(),
                            fecha_inscripcion = fechaInicioCurso,
                            fecha_expedicion = fechaFinCurso,
                            apto = bool.TryParse(row.Cell(9).GetValue<string>(), out bool aptoBool) && aptoBool,
                            cod_factura = row.Cell(10).GetValue<string>(),
                        };
                        inscripciones.Add(ins);
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"ERROR: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return inscripciones;
        }

        
    }
}
