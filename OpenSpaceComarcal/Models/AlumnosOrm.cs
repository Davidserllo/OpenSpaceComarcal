using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            String mensajeError = "";

            Orm.bd.alumno.Add(_alumno);
            mensajeError = Orm.MySaveChanges();

            return mensajeError;
        }

        public static String Delete(alumno _alumno)
        {
            String mensajeError = "";

            Orm.bd.alumno.Remove(_alumno);
            mensajeError = Orm.MySaveChanges();

            return mensajeError;
        }

        public static String Update(alumno _alumno)
        {
            String mensajeError = "";

            alumno alumnoAnterior = Orm.bd.alumno.Find(_alumno.dni);

            if (alumnoAnterior != null)
            {
                alumnoAnterior.nombre = _alumno.nombre;
                alumnoAnterior.apellidos = _alumno.apellidos;
                alumnoAnterior.telefono = _alumno.telefono;

                mensajeError = Orm.MySaveChanges();
            }
            return mensajeError;
        }
    }
}
