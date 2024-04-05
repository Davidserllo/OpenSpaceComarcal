using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSpaceComarcal.Models
{
    internal class InstanciaOrm
    {
        public static List<instancia> Select()
        {
            List<instancia> _instancia = Orm.bd.instancia
                .OrderBy(n => n.id)
                .ToList();

            return _instancia;
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
