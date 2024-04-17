using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenSpaceComarcal.Models
{
    public static class InstanciaOrm
    {
        public static List<instancia> Select()
        {
            List<instancia> _instancia = Orm.bd.instancia
                .OrderBy(n => n.id)
                .ToList();

            return _instancia;
        }

        public static List<instancia> Select(string busqueda)
        {
            if (string.IsNullOrEmpty(busqueda))
            {
                return Orm.bd.instancia.OrderBy(a => a.id).ToList();
            }

            var query = Orm.bd.instancia
                .Where(a => a.id.ToString().Contains(busqueda)
                            || a.id_curso.Contains(busqueda)
                            || a.fecha_inicio.ToString().Contains(busqueda)
                            || a.fecha_fin.ToString().Contains(busqueda)
                            || a.diploma.Contains(busqueda))
                .OrderBy(a => a.id)
                .ToList();

            return query;
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

                mensajeError = Orm.MySaveChanges();
            }
            return mensajeError;
        }
    }
}
