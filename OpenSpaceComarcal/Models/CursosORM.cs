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

        public static String Delete(curso _curso)
        {
            String mensajeError = "";

            Orm.bd.curso.Remove(_curso);
            mensajeError = Orm.MySaveChanges();

            return mensajeError;
        }

        //public static String Update(alumno _alumno)
        //{
        //    String mensajeError = "";

        //    alumno alumnoAnterior = Orm.bd.alumno.Find(_alumno.dni);

        //    if (alumnoAnterior != null)
        //    {
        //        alumnoAnterior.nombre = _alumno.nombre;
        //        alumnoAnterior.apellidos = _alumno.apellidos;
        //        alumnoAnterior.telefono = _alumno.telefono;

        //        mensajeError = Orm.MySaveChanges();
        //    }
        //    return mensajeError;
        //}
    }
}