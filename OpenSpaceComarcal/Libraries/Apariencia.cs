using Sunisoft.IrisSkin;
using System;

namespace OpenSpaceComarcal.Libraries
{
    internal class Apariencia
    {
        public static void AplicarApariencia(SkinEngine skinEngine)
        {
            String NombreApariencia = Properties.Settings.Default.NomApariencia;
            skinEngine.SkinFile = NombreApariencia;
        }

        public static void CambiarApariencia(SkinEngine skinEngine, String NombreApariencia)
        {
            Properties.Settings.Default.NomApariencia = NombreApariencia;
            Properties.Settings.Default.Save();
            skinEngine.SkinFile = NombreApariencia;
        }

    }
}