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
    }
}
