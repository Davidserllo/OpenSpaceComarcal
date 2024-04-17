using System;
using System.Text.RegularExpressions;

namespace OpenSpaceComarcal.Libraries
{
    public static class ValidarAlumno
    {
        private static bool ValidarDNI(string dni)
        {
            if (string.IsNullOrEmpty(dni))
                return false;

            dni = dni.Trim().ToUpper();

            Regex regexDNI = new Regex(@"^\d{8}[A-Z]$");

            if (!regexDNI.IsMatch(dni))
                return false;

            int numero;
            if (!int.TryParse(dni.Substring(0, 8), out numero))
                return false;

            string letraCalculada = ObtenerLetraDNI(numero);

            return dni.EndsWith(letraCalculada);
        }

        private static bool ValidarNIE(string nie)
        {
            if (string.IsNullOrEmpty(nie))
                return false;

            nie = nie.ToUpper().Trim();
            Regex regexNIE = new Regex(@"^[XYZ]\d{7}[A-Z]$");

            if (!regexNIE.IsMatch(nie))
                return false;

            nie = nie.Replace("X", "0").Replace("Y", "1").Replace("Z", "2");

            if (int.TryParse(nie.Substring(0, 8), out int numero))
            {
                string letraCalculada = ObtenerLetraDNI(numero);
                return nie[8] == letraCalculada[0];
            }

            return false;
        }

        private static string ObtenerLetraDNI(int numero)
        {
            string[] letras = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            return letras[numero % 23];
        }
        public static String validarDniNie(String dniNie)
        {
            String msgError = "";
            if (!(ValidarDNI(dniNie) || ValidarNIE(dniNie)))
            {
                msgError = "El DNI o NIE es incorrecto, ¿desea seguir?";
            }
            return msgError;
        }
    }
}
