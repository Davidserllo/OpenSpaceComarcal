using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenSpaceComarcal.Models
{
    public static class AlumnosOrm
    {
        public static List<alumno> Select()
        {
            List<alumno> _alumnos = Orm.bd.alumno
                .OrderBy(n => n.id)
                .ToList();

            return _alumnos;
        }

        public static List<alumno> Select(string busqueda)
        {
            if (string.IsNullOrEmpty(busqueda))
            {
                return Orm.bd.alumno.OrderBy(a => a.id).ToList();
            }

            var query = Orm.bd.alumno
                .Where(a => a.id.ToString().Contains(busqueda)
                            || a.dni_nie_pasp.Contains(busqueda)
                            || a.apellidos.Contains(busqueda)
                            || a.nombre.Contains(busqueda)
                            || a.telefono.Contains(busqueda)
                            || a.email.Contains(busqueda)
                            || a.id_empresa.ToString().Contains(busqueda))
                .OrderBy(a => a.id)
                .ToList();

            return query;
        }

        public static List<string> SelectNombre(int id_alumno)
        {
            List<string> nombreAlumno = Orm.bd.alumno
                .Where(n => n.id == id_alumno)
                .OrderBy(n => n.nombre)
                .Select(n => n.nombre)
                .ToList();

            return nombreAlumno;
        }

        public static List<string> SelectCod(int id_alumno)
        {
            List<string> codAlumno = Orm.bd.alumno
                .Where(n => n.id == id_alumno)
                .OrderBy(n => n.dni_nie_pasp)
                .Select(n => n.dni_nie_pasp)
                .ToList();

            return codAlumno;
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

            alumno alumnoAnterior = Orm.bd.alumno.Find(_alumno.id);

            if (alumnoAnterior != null)
            {
                alumnoAnterior.dni_nie_pasp = _alumno.dni_nie_pasp;
                alumnoAnterior.apellidos = _alumno.apellidos;
                alumnoAnterior.nombre = _alumno.nombre;
                alumnoAnterior.telefono = _alumno.telefono;
                alumnoAnterior.email = _alumno.email;
                alumnoAnterior.id_empresa = _alumno.id_empresa;

                mensajeError = Orm.MySaveChanges();
            }
            return mensajeError;
        }
    }
}
