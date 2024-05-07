using OpenSpaceComarcal.Objects;
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

        public static List<PersDiploma> SelectDatosDiploma(List<int> listaDeIds)
        {
            var query = Orm.bd.inscripcion
                .Where(inscripcion => listaDeIds.Contains(inscripcion.id) && inscripcion.apto == true)
                .Select(inscripcion => new
                {
                    // Inscripcion
                    inscripcion.cod_factura,
                    inscripcion.fecha_expedicion,

                    // Instancia
                    inscripcion.instancia.curso.codigo,
                    inscripcion.instancia.fecha_inicio,
                    inscripcion.instancia.fecha_fin,
                    inscripcion.instancia.diploma,

                    //Alumno
                    inscripcion.alumno.id,
                    inscripcion.alumno.dni_nie_pasp,
                    inscripcion.alumno.nombre,
                    inscripcion.alumno.apellidos,
                    inscripcion.alumno.id_empresa
                })
                .ToList();

            List<PersDiploma> resultados = query.Select(x => new PersDiploma
            {
                NumFactura = x.cod_factura,
                FechaExpedicion = x.fecha_expedicion,
                CodCurso = x.codigo,
                FechaInicio = x.fecha_inicio,
                FechaFin = x.fecha_fin,
                AlumnoId = x.id,
                EmpresaId = x.id_empresa.ToString(),
                AlumnoDNI = x.dni_nie_pasp,
                AlumnoNombre = x.nombre,
                AlumnoApellidos = x.apellidos,
                Diploma = x.diploma,
            }).ToList();

            return resultados;
        }

        public static List<inscripcion> SelectAvanzado(int alumnoId, int instanciaId, bool apto)
        {
            var query = Orm.bd.inscripcion.AsQueryable();

            if (alumnoId != -1)
            {
                query = query.Where(i => i.id_alumno == alumnoId);
            }

            if (instanciaId != -1)
            {
                query = query.Where(i => i.id_instancia == instanciaId);
            }

            if (apto == true)
            {
                query = query.Where(i => i.apto == apto);
            }

            query = query.OrderBy(i => i.id);

            return query.ToList();
        }
        public static List<string> SelectFecha(int id_instancia)
        {
            List<string> siglaCurso = Orm.bd.instancia
                .Where(n => n.id == id_instancia)
                .OrderBy(n => n.fecha_inicio)
                .AsEnumerable()
                .Select(n => n.fecha_inicio.HasValue ? n.fecha_inicio.Value.ToString("yyyy-MM-dd") : "Error")
                .ToList();

            return siglaCurso;
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