using OpenSpaceComarcal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSpaceComarcal.Objects
{
    public class PersAsistencias
    {
        public string NombreCurso { get; set; }
        public string CodCurso { get; set; }
        public int InstanciaId { get; set; }
        public int? Sesiones { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public List<alumno> Alumnos { get; set; }
    }
}
