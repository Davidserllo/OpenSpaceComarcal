using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using OpenSpaceComarcal.Libraries;

namespace OpenSpaceComarcal.Models
{
    public static class AlumnosOrm
    {
        public static SortableBindingList<alumno> Select(DateTime fechaInicio, DateTime fechaFin)
        {
            List<alumno> _alumnos = Orm.bd.alumno
                .Where(n => n.fecha_registro >= fechaInicio && n.fecha_registro <= fechaFin)
                .OrderBy(n => n.id)
                .ToList();

            return new SortableBindingList<alumno>(_alumnos);
        }

        public static int SelectID(string dni, string apellidos)
        {

            int id = Orm.bd.alumno
                .OrderBy(n => n.id)
                .Where(n => n.dni_nie_pasp == dni && n.apellidos == apellidos)
                .Select(n => n.id)
                .FirstOrDefault();
            return id;
        }


        public static SortableBindingList<alumno> Select(string busqueda, DateTime fechaInicio, DateTime fechaFin)
        {
            if (string.IsNullOrEmpty(busqueda))
            {
                List<alumno> _alumnos = Orm.bd.alumno.OrderBy(a => a.id)
                    .Where(n => n.fecha_registro >= fechaInicio && n.fecha_registro <= fechaFin)
                    .ToList();
                return new SortableBindingList<alumno>(_alumnos);
            }

            var query = Orm.bd.alumno
                .Where(n => n.fecha_registro >= fechaInicio && n.fecha_registro <= fechaFin)
                .Where(a => a.id.ToString().Contains(busqueda)
                            || a.dni_nie_pasp.Contains(busqueda)
                            || a.apellidos.Contains(busqueda)
                            || a.nombre.Contains(busqueda)
                            || a.telefono.Contains(busqueda)
                            || a.email.Contains(busqueda)
                            || a.fecha_registro.ToString().Contains(busqueda)
                            || a.notas.Contains(busqueda))
                .OrderBy(a => a.id)
                .ToList();

            return new SortableBindingList<alumno>(query);
        }

        public static SortableBindingList<alumno> SelectBusqueda(string busqueda)
        {
            if (string.IsNullOrEmpty(busqueda))
            {
                List<alumno> _alumnos = Orm.bd.alumno.OrderBy(a => a.id)
                    .ToList();
                return new SortableBindingList<alumno>(_alumnos);
            }

            var query = Orm.bd.alumno
                .Where(a => a.id.ToString().Contains(busqueda)
                            || a.dni_nie_pasp.Contains(busqueda)
                            || a.apellidos.Contains(busqueda)
                            || a.nombre.Contains(busqueda)
                            || a.telefono.Contains(busqueda)
                            || a.email.Contains(busqueda)
                            || a.fecha_registro.ToString().Contains(busqueda)
                            || a.notas.Contains(busqueda))
                .OrderBy(a => a.id)
                .ToList();

            return new SortableBindingList<alumno>(query);
        }

        public static SortableBindingList<alumno> SelectAvanzado(int empresaId, DateTime fechaInicio, DateTime fechaFin)
        {
            var query = Orm.bd.alumno.AsQueryable();

            if (empresaId != -1)
            {
                query = query
                    .Where(n => n.fecha_registro >= fechaInicio && n.fecha_registro <= fechaFin)
                    .Where(i => i.id_empresa == empresaId);
            }

            query = query
                .Where(n => n.fecha_registro >= fechaInicio && n.fecha_registro <= fechaFin)
                .OrderBy(i => i.id);

            return new SortableBindingList<alumno>(query.ToList());
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
                alumnoAnterior.fecha_registro = _alumno.fecha_registro;
                alumnoAnterior.notas = _alumno.notas;

                mensajeError = Orm.MySaveChanges();
            }
            return mensajeError;
        }
    }
}
