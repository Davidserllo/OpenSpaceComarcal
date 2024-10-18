using OpenSpaceComarcal.Libraries;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenSpaceComarcal.Models
{
    public static class InstanciaOrm
    {
        public static SortableBindingList<instancia> Select(DateTime fechaInicio, DateTime fechaFin)
        {
            List<instancia> _instancia = Orm.bd.instancia
                .Where(n => n.fecha_inicio >= fechaInicio && n.fecha_inicio <= fechaFin ||
                n.fecha_fin >= fechaInicio && n.fecha_fin <= fechaFin)
                .OrderBy(n => n.id)
                .ToList();

            return new SortableBindingList<instancia>(_instancia);
        }

        public static DateTime? SelectDate(int id_instancia)
        {
            DateTime? fechaCurso = Orm.bd.instancia
                .Where(n => n.id == id_instancia)
                .Select(n => n.fecha_inicio)
                .FirstOrDefault();
            return fechaCurso;
        }

        public static DateTime? SelectEndDate(int id_instancia)
        {
            DateTime? fechaCurso = Orm.bd.instancia
                .Where(n => n.id == id_instancia)
                .Select(n => n.fecha_fin)
                .FirstOrDefault();
            return fechaCurso;
        }

        public static SortableBindingList<instancia> Select(string busqueda, DateTime fechaInicio, DateTime fechaFin)
        {
            if (string.IsNullOrEmpty(busqueda))
            {
                List<instancia> _instancias = Orm.bd.instancia
                    .Where(n => n.fecha_inicio >= fechaInicio && n.fecha_inicio <= fechaFin ||
                    n.fecha_fin >= fechaInicio && n.fecha_fin <= fechaFin)
                    .OrderBy(a => a.id).ToList();

                return new SortableBindingList<instancia>(_instancias);
            }

            var query = Orm.bd.instancia
                .Where(n => n.fecha_inicio >= fechaInicio && n.fecha_inicio <= fechaFin ||
                n.fecha_fin >= fechaInicio && n.fecha_fin <= fechaFin)
                .Where(a => a.id.ToString().Contains(busqueda)
                            || a.fecha_inicio.ToString().Contains(busqueda)
                            || a.fecha_fin.ToString().Contains(busqueda)
                            || a.diploma.Contains(busqueda)
                            || a.codigo.Contains(busqueda)
                            || a.sesion.ToString().Contains(busqueda))
                .OrderBy(a => a.id)
                .ToList();

            return new SortableBindingList<instancia>(query);
        }

        public static SortableBindingList<instancia> SelectBusqueda(string busqueda)
        {
            if (string.IsNullOrEmpty(busqueda))
            {
                List<instancia> _instancias = Orm.bd.instancia
                    .OrderBy(a => a.id).ToList();

                return new SortableBindingList<instancia>(_instancias);
            }

            var query = Orm.bd.instancia
                .Where(a => a.id.ToString().Contains(busqueda)
                            || a.fecha_inicio.ToString().Contains(busqueda)
                            || a.fecha_fin.ToString().Contains(busqueda)
                            || a.diploma.Contains(busqueda)
                            || a.codigo.Contains(busqueda)
                            || a.sesion.ToString().Contains(busqueda)

                            || a.curso.nombre.Contains(busqueda)
                            || a.curso.siglas.Contains(busqueda))

                .OrderBy(a => a.id)
                .ToList();

            return new SortableBindingList<instancia>(query);
        }

        public static List<int> SelectIdCurso(int id_instancia)
        {
            List<int> idCurso = Orm.bd.instancia
                .Where(n => n.id == id_instancia)
                .OrderBy(n => n.id)
                .Select(n => n.id_curso)
                .ToList();

            return idCurso;
        }

        public static String Insert(instancia _instancia)
        {
            String missatge = "";

            Orm.bd.instancia.Add(_instancia);
            missatge = Orm.MySaveChanges();

            return missatge;
        }

        public static String Delete(instancia _instancia)
        {
            String mensajeError = "";

            Orm.bd.instancia.Remove(_instancia);
            mensajeError = Orm.MySaveChanges();

            return mensajeError;
        }

        public static String Update(instancia _instancia)
        {
            String mensajeError = "";

            instancia instanciaAnterior = Orm.bd.instancia.Find(_instancia.id);

            if (instanciaAnterior != null)
            {
                instanciaAnterior.id_curso = _instancia.id_curso;
                instanciaAnterior.fecha_inicio = _instancia.fecha_inicio;
                instanciaAnterior.fecha_fin = _instancia.fecha_fin;
                instanciaAnterior.diploma = _instancia.diploma;
                instanciaAnterior.codigo = _instancia.codigo;
                instanciaAnterior.sesion = _instancia.sesion;

                mensajeError = Orm.MySaveChanges();
            }
            return mensajeError;
        }
    }
}
