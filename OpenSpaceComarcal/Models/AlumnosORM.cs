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
            List<alumno> _artistas = Orm.bd.alumno
                .OrderBy(n => n.nombre)
                .ToList();

            return _artistas;
        }
    }
}
