using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSpaceComarcal
{
    public partial class FormRutaDiploma : Form
    {
        private List<int> ids;
        public FormRutaDiploma(List<int> ids)
        {
            this.ids = ids;
            InitializeComponent();
            labelNumeroDiplomas.Text = ids.Count.ToString();
        }

        private void buttonSeleccionarRuta_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Seleccione una carpeta para guardar el archivo";
                folderDialog.ShowNewFolderButton = true;  // Permite crear nuevas carpetas
                folderDialog.RootFolder = Environment.SpecialFolder.MyComputer;  // Carpeta raíz por defecto

                // Mostrar el diálogo y obtener el resultado
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;
                    MessageBox.Show($"Carpeta seleccionada: {selectedPath}");
                    textBoxRutaDestino.Text = selectedPath;
                    // Puedes usar 'selectedPath' para guardar archivos o como necesites
                }
            }
        }

        private void buttonGenerar_Click(object sender, EventArgs e)
        {

        }
    }
}
