using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenSpaceComarcal.Models
{
    public static class InscripcionOrm
    {
        public static List<inscripcion> Select()
        {
            List<inscripcion> _inscripcion = Orm.bd.inscripcion
                .OrderBy(n => n.id)
                .ToList();

            return _inscripcion;
        }
        public static List<inscripcion> Select(string busqueda)
        {
            if (string.IsNullOrEmpty(busqueda))
            {
                return Orm.bd.inscripcion.OrderBy(a => a.id).ToList();
            }

            var query = Orm.bd.inscripcion
                .Where(a => a.id.ToString().Contains(busqueda)
                            || a.id_alumno.ToString().Contains(busqueda)
                            || a.id_instancia.ToString().Contains(busqueda)
                            || a.fecha_inscripcion.ToString().Contains(busqueda)
                            || a.fecha_expedicion.ToString().Contains(busqueda)
                            || a.apto.ToString().Contains(busqueda)
                            || a.cod_factura.Contains(busqueda))
                .OrderBy(a => a.id)
                .ToList();

            return query;
        }

        //public static List<string> SelectSigla(string id_instancia)
        //{
        //    List<string> siglaCurso = Orm.bd.curso
        //        .Where(n => n.codigo == id_curso)
        //        .OrderBy(n => n.siglas)
        //        .Select(n => n.siglas)
        //        .ToList();

        //    return siglaCurso;
        //}
        

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

        public static String Update(inscripcion _inscripcion)
        {
            String mensajeError = "";

            inscripcion inscripcionAnterior = Orm.bd.inscripcion.Find(_inscripcion.id);

            if (inscripcionAnterior != null)
            {
                inscripcionAnterior.id_alumno = _inscripcion.id_alumno;
                inscripcionAnterior.id_instancia = _inscripcion.id_instancia;
                inscripcionAnterior.fecha_inscripcion = _inscripcion.fecha_inscripcion;
                inscripcionAnterior.fecha_expedicion = _inscripcion.fecha_expedicion;
                inscripcionAnterior.apto = _inscripcion.apto;
                inscripcionAnterior.cod_factura = _inscripcion.cod_factura;

                mensajeError = Orm.MySaveChanges();
            }
            return mensajeError;
        }
    }
}