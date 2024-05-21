using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSpaceComarcal.Libraries
{
    internal class XD
    {

        public static bool xd()
        {
            bool isXD = false;
            string xd = Properties.Settings.Default.XD;
            DateTime xD = DateTime.ParseExact(xd, "dd/MM/yyyy", null);
            DateTime nowXD = DateTime.Now;
            if (!(nowXD > xD))
            {
                isXD = true;
            }
            return isXD;
        }
    }
}
