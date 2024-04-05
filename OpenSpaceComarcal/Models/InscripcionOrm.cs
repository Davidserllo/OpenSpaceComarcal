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

        public static String Delete(inscripcion _inscripcion)
        {
            String mensajeError = "";

            Orm.bd.inscripcion.Remove(_inscripcion);
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