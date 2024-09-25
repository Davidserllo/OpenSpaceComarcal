using OpenSpaceComarcal.Libraries;
using OpenSpaceComarcal.Models;
using OpenSpaceComarcal.Objects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace OpenSpaceComarcal
{
    public partial class FormRutaDiploma : Form
    {
        public const string RUTA_DESTINO = @"\\Nas01\administracion\Open_Space_Comarcal_Software\Diplomas";
        
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
        }

        private void buttonSeleccionarRuta_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Seleccione una carpeta para guardar el archivo";
                folderDialog.ShowNewFolderButton = true;
                folderDialog.SelectedPath = RUTA_DESTINO;
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
                string rutaCombinada = "";

                progressBar1.Visible = true;
                progressBar1.Maximum = diplomas.Count;
                progressBar1.Value = 0;

                foreach (var diploma in diplomas)
                {
                    rutaCombinada = Diploma.generarDiplomaWord(diploma, textBoxRutaDestino.Text, checkBoxPDF.Checked);

                    progressBar1.Value += 1;
                }
                progressBar1.Visible = false;
                if (checkBoxCombinar.Checked)
                {
                    Diploma.combinarDiplomas(rutaCombinada);
                }
                MessageBox.Show("Se han creado los diplomas", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenFileExplorer(textBoxRutaDestino.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("No ha puesto la ruta del destino o no hay alumnos seleccionados que esten Aptos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            buttonGenerar.Enabled = true;
        }

        private void FormRutaDiploma_Load(object sender, EventArgs e)
        {
            textBoxRutaDestino.Text = RUTA_DESTINO;
        }

        private void OpenFileExplorer(string path)
        {
            try
            {
                // Verificar si la ruta existe
                if (Directory.Exists(path))
                {
                    // Iniciar el Explorador de Archivos en la ruta especificada
                    Process.Start("explorer.exe", path);
                }
                else
                {
                    MessageBox.Show("La ruta especificada no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el Explorador de Archivos: {ex.Message}");
            }
        }
    }
}
