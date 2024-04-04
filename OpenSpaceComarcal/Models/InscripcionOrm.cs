using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSpaceComarcal.Models
{
    internal class InscripcionOrm
    {
        public static List<inscripcion> Select()
        {
            List<inscripcion> _inscripcion = Orm.bd.inscripcion
                .OrderBy(n => n.id)
                .ToList();

            return _inscripcion;
        }

        public static String Insert(inscripcion _inscripcion)
        {
            String missatge = "";

            Orm.bd.inscripcion.Add(_inscripcion);
            missatge = Orm.MySaveChanges();

            return missatge;
        }
    }
}