using System;
using System.Windows.Forms;
using OpenSpaceComarcal.Libraries;

namespace OpenSpaceComarcal
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (XD.xd())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormInicio());
            }
            else
            {
                MessageBox.Show("ERROR: La siguiente dependencia esta desactualizada: document.format.openXML" +
                    "\n STACK TRACE: 'OpenSpaceComarcal.exe' (CLR v4.0.30319: OpenSpaceComarcal.exe): Loaded 'C:\\Windows\\Microsoft.Net\\assembly\\GAC_MSIL\\System.Core\\v4.0_4.0.0.0__b77a5c561934e089\\System.Core.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.\r\n'OpenSpaceComarcal.exe' (CLR v4.0.30319: OpenSpaceComarcal.exe): Loaded 'C:\\Windows\\Microsoft.Net\\assembly\\GAC_MSIL\\System.Xml\\v4.0_4.0.0.0__b77a5c561934e089\\System.Xml.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.\r\n'OpenSpaceComarcal.exe' (CLR v4.0.30319: OpenSpaceComarcal.exe): Loaded 'D:\\Empresas\\OPEN SPACE\\OpenSpaceLoc\\OpenSpaceComarcal\\bin\\Debug\\IrisSkin2.dll'. Module was built without symbols.\r\n'OpenSpaceComarcal.exe' (CLR v4.0.30319: OpenSpaceComarcal.exe): Loaded 'C:\\Windows\\Microsoft.Net\\assembly\\GAC_MSIL\\Accessibility\\v4.0_4.0.0.0__b03f5f7f11d50a3a\\Accessibility.dll'. \r\n'OpenSpaceComarcal.exe' (CLR v4.0.30319: OpenSpaceComarcal.exe): Loaded 'C:\\Windows\\Microsoft.Net\\assembly\\GAC_MSIL\\mscorlib.resources\\v4.0_4.0.0.0_es_b77a5c561934e089\\mscorlib.resources.dll'. Module was built without symbols.\r\nNo se puede dejar vacío el nombre de la ruta de acceso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
