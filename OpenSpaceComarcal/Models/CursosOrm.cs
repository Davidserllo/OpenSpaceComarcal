using System.Collections.Generic;
using System.Linq;
using System;

namespace OpenSpaceComarcal.Models
{
    public static class CursosOrm
    {
        public static List<curso> Select()
        {
            List<curso> _curso = Orm.bd.curso
                .OrderBy(n => n.id)
                .ToList();

            return _curso;
        }

        public static List<string> SelectSigla(int id_curso)
        {
            List<string> siglaCurso = Orm.bd.curso
                .Where(n => n.id == id_curso)
                .OrderBy(n => n.siglas)
                .Select(n => n.siglas)
                .ToList();

            return siglaCurso;
        }

        public static List<curso> Select(string busqueda)
        {
            if (string.IsNullOrEmpty(busqueda))
            {
                return Orm.bd.curso.OrderBy(a => a.id).ToList();
            }

            var query = Orm.bd.curso
                .Where(a => a.id.ToString().Contains(busqueda)
                            || a.codigo.Contains(busqueda)
                            || a.siglas.Contains(busqueda)
                            || a.nombre.Contains(busqueda))
                .OrderBy(a => a.id)
                .ToList();

            return query;
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

        public static String Update(curso _curso)
        {
            String mensajeError = "";

            curso cursoAnterior = Orm.bd.curso.Find(_curso.id);

            if (cursoAnterior != null)
            {
                cursoAnterior.codigo = _curso.codigo;
                cursoAnterior.siglas = _curso.siglas;
                cursoAnterior.nombre = _curso.nombre;

                mensajeError = Orm.MySaveChanges();
            }
            return mensajeError;
        }
    }
}