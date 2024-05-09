using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSpaceComarcal.Models
{
    public static class EmpresaOrm
    {
        public static List<empresa> Select()
        {
            List<empresa> _empresas = Orm.bd.empresa
                .OrderBy(n => n.id)
                .ToList();

            return _empresas;
        }

        public static List<string> Select(int id_empresa)
        {
            List<string> siglaEmpresa = Orm.bd.empresa
                .Where(n => n.id == id_empresa)
                .OrderBy(n => n.siglas)
                .Select(n => n.siglas)
                .ToList();

            return siglaEmpresa;
        }

        public static List<empresa> Select(string busqueda)
        {
            if (string.IsNullOrEmpty(busqueda))
            {
                return Orm.bd.empresa.OrderBy(a => a.id).ToList();
            }

            var query = Orm.bd.empresa
                .Where(a => a.id.ToString().Contains(busqueda)
                            || a.cif.Contains(busqueda)
                            || a.siglas.Contains(busqueda)
                            || a.nombre.Contains(busqueda)
                            || a.telefono.ToString().Contains(busqueda)
                            || a.email.Contains(busqueda)
                            || a.persona_contacto.Contains(busqueda)
                            || a.notas.Contains(busqueda))
                .OrderBy(a => a.id)
                .ToList();

            return query;
        }

        public static String Insert(empresa _empresa)
        {
            String missatge = "";

            Orm.bd.empresa.Add(_empresa);
            missatge = Orm.MySaveChanges();

            return missatge;
        }

        public static String Delete(empresa _empresa)
        {
            String mensajeError = "";

            Orm.bd.empresa.Remove(_empresa);
            mensajeError = Orm.MySaveChanges();

            return mensajeError;
        }

        public static String Update(empresa _empresa)
        {
            String mensajeError = "";

            empresa empresaAnterior = Orm.bd.empresa.Find(_empresa.id);

            if (empresaAnterior != null)
            {
                empresaAnterior.cif = _empresa.cif;
                empresaAnterior.siglas = _empresa.siglas;
                empresaAnterior.nombre = _empresa.nombre;
                empresaAnterior.telefono = _empresa.telefono;
                empresaAnterior.email = _empresa.email;
                empresaAnterior.persona_contacto = _empresa.persona_contacto;
                empresaAnterior.notas = _empresa.notas;

                mensajeError = Orm.MySaveChanges();
            }
            return mensajeError;
        }
    }
}
