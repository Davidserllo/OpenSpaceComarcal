using OpenSpaceComarcal.Libraries;
using OpenSpaceComarcal.Models;
using OpenSpaceComarcal.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OpenSpaceComarcal
{
    public partial class FormRutaDiploma : Form
    {
        private List<int> ids;

        // Sobreescribe la propiedad CreateParams para personalizar los parámetros de creación del formulario
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public FormRutaDiploma(List<int> ids)
        {
            this.ids = ids;
            InitializeComponent();
            progressBar1.Visible = false;
            labelNumeroDiplomas.Text = ids.Count.ToString();
            Apariencia.AplicarApariencia(skinEngineDiploma);
        }

        private void buttonSeleccionarRuta_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Seleccione una carpeta para guardar el archivo";
                folderDialog.ShowNewFolderButton = true; 
                folderDialog.RootFolder = Environment.SpecialFolder.MyComputer;

                // Mostrar el diálogo y obtener el resultado
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;
                    MessageBox.Show($"Carpeta seleccionada: {selectedPath}", "Ruta destino", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxRutaDestino.Text = selectedPath;
                }
            }
        }
        
        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            buttonGenerar.Enabled = false;
            List<PersDiploma> diplomas = InscripcionOrm.SelectDatosDiploma(ids);
            if (diplomas.Count > 0 && !string.IsNullOrEmpty(textBoxRutaDestino.Text))
            {
                progressBar1.Visible = true;
                progressBar1.Maximum = diplomas.Count;
                progressBar1.Value = 0;

                foreach (var diploma in diplomas)
                {
                    Diploma.generarDiplomaWord(diploma, textBoxRutaDestino.Text, checkBoxPDF.Checked);

                    progressBar1.Value += 1;
                }
                progressBar1.Visible = false;
                MessageBox.Show("Se han creado los diplomas", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No ha puesto la ruta del destino o no hay alumnos seleccionados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            buttonGenerar.Enabled = true;
        }
    }
}
