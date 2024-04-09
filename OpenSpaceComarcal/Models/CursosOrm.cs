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

        public static List<curso> Select(string busqueda)
        {
            if (string.IsNullOrEmpty(busqueda))
            {
                return Orm.bd.curso.OrderBy(a => a.nombre).ToList();
            }

            var query = Orm.bd.curso
                .Where(a => a.codigo.Contains(busqueda)
                            || a.siglas.Contains(busqueda)
                            || a.nombre.Contains(busqueda))
                .OrderBy(a => a.nombre)
                .ToList();

            return query;
        }

        public static String Insert(curso _curso)
        {
            String missatge = "";

            Orm.bd.curso.Add(_curso);
            missatge = Orm.MySaveChanges();

            return missatge;
        }

        public static String Delete(curso _curso)
        {
            String mensajeError = "";

            Orm.bd.curso.Remove(_curso);
            mensajeError = Orm.MySaveChanges();

            return mensajeError;
        }

        public static String Update(curso _curso)
        {
            String mensajeError = "";

            curso cursoAnterior = Orm.bd.curso.Find(_curso.codigo);

            if (cursoAnterior != null)
            {
                cursoAnterior.siglas = _curso.siglas;
                cursoAnterior.nombre = _curso.nombre;

                mensajeError = Orm.MySaveChanges();
            }
            return mensajeError;
        }
    }
}