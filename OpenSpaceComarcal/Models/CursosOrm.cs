using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSpaceComarcal.Models
{
    internal class CursosOrm
    {
        public static List<curso> Select()
        {
            List<curso> _curso = Orm.bd.curso
                .OrderBy(n => n.nombre)
                .ToList();

            return _curso;
        }

        public static String Insert(curso _curso)
        {
            String missatge = "";

            Orm.bd.curso.Add(_curso);
            missatge = Orm.MySaveChanges();

            return missatge;
        }
    }
}