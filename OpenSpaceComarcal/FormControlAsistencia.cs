using DocumentFormat.OpenXml.Office2010.Excel;
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
    public partial class FormControlAsistencia : Form
    {
        public FormControlAsistencia()
        {
            InitializeComponent();
            progressBar1.Visible = false;
        }

        private void FormControlAsistencia_Load(object sender, EventArgs e)
        {
            bindingSourceInstancia.DataSource = InstanciaOrm.Select();
        }

        private string elegirRuta()
        {
            string selectedPath = "";
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Seleccione una carpeta para guardar el archivo";
                folderDialog.ShowNewFolderButton = true;
                folderDialog.RootFolder = Environment.SpecialFolder.MyComputer;

                // Mostrar el diálogo y obtener el resultado
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedPath = folderDialog.SelectedPath;
                    MessageBox.Show($"Carpeta seleccionada: {selectedPath}", "Ruta destino", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return selectedPath;
        }

        private string elegirRutaPlantilla()
        {
            string selectedFilePath = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccione el archivo de plantilla";
                openFileDialog.Filter = "Documentos de Word (*.doc;*.docx)|*.doc;*.docx";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // Mostrar el diálogo y obtener el resultado
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = openFileDialog.FileName;
                    MessageBox.Show($"Archivo seleccionado: {selectedFilePath}", "Archivo seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return selectedFilePath;
        }

        private void buttonSeleccionarRuta_Click(object sender, EventArgs e)
        {
            textBoxRutaDestino.Text = elegirRuta();
        }

        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            buttonGenerar.Enabled = false;
            PersAsistencias asistencia = InscripcionOrm.SelectDatosAsistencia((int) comboBoxInstancia.SelectedValue);
            if (asistencia != null && !string.IsNullOrEmpty(textBoxRutaDestino.Text) && !string.IsNullOrEmpty(textBoxRutaPlantilla.Text))
            {
                Diploma.generarControlAsistencia(asistencia, textBoxRutaDestino.Text, textBoxRutaPlantilla.Text);

                MessageBox.Show("Se han creado los diplomas", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No ha puesto la ruta del destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            buttonGenerar.Enabled = true;
        }

        private void buttonSeleccionarRutaPlantilla_Click(object sender, EventArgs e)
        {
            textBoxRutaPlantilla.Text = elegirRutaPlantilla();
        }
    }
}
