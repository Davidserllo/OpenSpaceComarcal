using Sunisoft.IrisSkin;
using System;
using System.IO;

namespace OpenSpaceComarcal.Libraries
{
    internal class Apariencia
    {
        // Ruta relativa de las apariencias
        //public static string RelativePath = @"..\..\Resources\TemasInterfaz\Emerald\";
        public static string RelativePath = @"..\Resources\TemasInterfaz\Emerald\";
        public static void AplicarApariencia(SkinEngine skinEngine)
        {
            // Obtener nombre de la apariencia a aplicar
            String NombreApariencia = Properties.Settings.Default.NomApariencia;

            // Localizar ruta de la apariencia
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string fullPath = Path.GetFullPath(Path.Combine(basePath, RelativePath));

            // Aplicar la apariencia
            skinEngine.SkinFile = fullPath + NombreApariencia;
        }

        public static void CambiarApariencia(SkinEngine skinEngine, String NombreApariencia)
        {
            // Cambiar aparencia y guardar los cambios
            Properties.Settings.Default.NomApariencia = NombreApariencia;
            Properties.Settings.Default.Save();

            // Localizar ruta de la apariencia
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string fullPath = Path.GetFullPath(Path.Combine(basePath, RelativePath));

            // Aplicar la apariencia
            skinEngine.SkinFile = fullPath + NombreApariencia;
        }

    }
}