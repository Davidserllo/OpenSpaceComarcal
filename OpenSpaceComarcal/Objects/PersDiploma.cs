using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSpaceComarcal.Objects
{
    
    public class PersDiploma
    {
        // Cnst
        public static string CIUDAD = "Sagunto (Valencia)";
        // Atrib
        public int AlumnoId { get; set; }
        public string AlumnoDNI { get; set; }
        public string AlumnoNombre { get; set; }
        public string AlumnoApellidos { get; set; }
        public string Ciudad {  get; set; }
        public string NumFactura { get; set; }
        public DateTime? FechaExpedicion { get; set; }
        public string CodCurso { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int NumeroDiploma { get; set; }
        public string Diploma { get; set; }

        public PersDiploma()
        {
            Ciudad = CIUDAD;
        }
    }
}
