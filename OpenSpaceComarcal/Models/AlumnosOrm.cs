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

        public static List<alumno> Select(string busqueda)
        {
            if (string.IsNullOrEmpty(busqueda))
            {
                return Orm.bd.alumno.OrderBy(a => a.nombre).ToList();
            }

            var query = Orm.bd.alumno
                .Where(a => a.dni.Contains(busqueda)
                            || a.nombre.Contains(busqueda)
                            || a.apellidos.Contains(busqueda)
                            || a.telefono.Contains(busqueda))
                .OrderBy(a => a.nombre)
                .ToList();

            return query;
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
