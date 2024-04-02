using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSpaceComarcal.Models
{
    public static class AlumnosOrm
    {
        public static List<alumno> Select()
        {
            List<alumno> _alumnos = Orm.bd.alumno
                .OrderBy(n => n.nombre)
                .ToList();

            return _alumnos;
        }

        public static String Insert(alumno _alumno)
        {
            String missatge = "";

            Orm.bd.alumno.Add(_alumno);
            missatge = Orm.MySaveChanges();

            return missatge;
        }
    }
}
