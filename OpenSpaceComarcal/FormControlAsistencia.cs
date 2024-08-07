using OpenSpaceComarcal.Libraries;
using OpenSpaceComarcal.Models;
using OpenSpaceComarcal.Objects;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OpenSpaceComarcal
{
    public partial class FormControlAsistencia : Form
    {
        public const string RUTA_DESTINO = @"\\Nas01\administracion\Open_Space_Comarcal_Software\C. Asistencias";
        public const string RUTA_PLANTILLA = @"\\Nas01\administracion\Open_Space_Comarcal_Software\Plantillas\C. Asistencias\CONTROL-ASISTENCIAS.docx";
        public FormControlAsistencia()
        {
            InitializeComponent();
            progressBar1.Visible = false;
        }

        private void FormControlAsistencia_Load(object sender, EventArgs e)
        {
            bindingSourceInstancia.DataSource = InstanciaOrm.Select();
            textBoxRutaDestino.Text = RUTA_DESTINO;
            textBoxRutaPlantilla.Text = RUTA_PLANTILLA;
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
            PersAsistencias asistencia = InscripcionOrm.SelectDatosAsistencia((int)comboBoxInstancia.SelectedValue);

            if (asistencia != null && !string.IsNullOrEmpty(textBoxRutaDestino.Text) && !string.IsNullOrEmpty(textBoxRutaPlantilla.Text))
            {
                Diploma.generarControlAsistencia(asistencia, textBoxRutaDestino.Text, textBoxRutaPlantilla.Text);
                

                MessageBox.Show("Se han creado los controles de asistencia", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenFileExplorer(textBoxRutaDestino.Text);
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

        private void comboBoxInstancia_Format(object sender, ListControlConvertEventArgs e)
        {
            instancia _instancia = (instancia)e.ListItem;
            string fecha = _instancia.fecha_inicio.HasValue
                   ? _instancia.fecha_inicio.Value.ToString("yy/MM/dd")
                   : "Error";
            string siglaCurso = CursosOrm.SelectSigla(
                        InstanciaOrm.SelectIdCurso(Convert.ToInt32(_instancia.id)).FirstOrDefault())
                        .FirstOrDefault();

            e.Value = $"{siglaCurso} - ({fecha})  ";
        }
    }
}
