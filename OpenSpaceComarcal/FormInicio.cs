using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OpenSpaceComarcal
{
    public partial class FormInicio : Form
    {
        private FormLoading loading;
        private Version version = Assembly.GetExecutingAssembly().GetName().Version;

        public FormInicio()
        {
            InitializeComponent();


            string versionText = $"v{version.Major}.{version.Minor}.{version.Build}";
            string releaseStage = "Alpha";
            labelVersion.Text = $"{versionText} {releaseStage}";
        }

        private bool checkUpdate()
        {
            bool isValid = false;
            string versionInfoPath = @"\\Nas01\administracion\Open_Space_Comarcal_Software\Versiones\version.txt";
            if (File.Exists(versionInfoPath))
            {
                var lines = File.ReadAllLines(versionInfoPath);
                string latestVersion = lines[0].Trim();

                string currentVersion = GetCurrentVersion();

                if (latestVersion != currentVersion)
                {
                    isValid = true;
                } else {
                    MessageBox.Show("La aplicación ya esta actualizada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return isValid;
        }


        private string GetCurrentVersion()
        {
            return $"{version.Major}.{version.Minor}.{version.Build}";
        }

        private async void buttonAlumnos_Click(object sender, EventArgs e)
        {
            OpenForm<FormAlumnos>();
        }

        private void buttonEmpresas_Click(object sender, EventArgs e)
        {
            OpenForm<FormEmpresas>();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenForm<FormCursos>();
        }

        private void buttonInstancia_Click(object sender, EventArgs e)
        {
            OpenForm<FormInstancia>();
        }

        private void buttonInscripcion_Click(object sender, EventArgs e)
        {
            OpenForm<FormInscripcion>();
        }

        // Método para mostrar la ventana de carga
        private void ShowLoading()
        {
            loading = new FormLoading();
            loading.Show(this);
        }

        // Método para ocultar la ventana de carga
        private void HideLoading()
        {
            if (loading != null && !loading.IsDisposed)
            {
                loading.Close();
                loading.Dispose();
            }
        }

        // Método genérico para abrir formas
        private async void OpenForm<T>() where T : Form, new()
        {
            ShowLoading();

            await Task.Delay(50);

            T form = new T();

            form.Load += (sender, e) =>
            {
                HideLoading();
            };

            form.Show();
        }

        private void toolStripButtonCheckUpdate_Click(object sender, EventArgs e)
        {
            if (checkUpdate())
            {
                string setupFilePath = @"\\Nas01\administracion\Open_Space_Comarcal_Software\Publicaciones\setup.exe";

                // Verificar si el archivo setup.exe existe
                if (File.Exists(setupFilePath))
                {
                    // Mostrar un mensaje al usuario
                    var result = MessageBox.Show("Se ha encontrado una actualización. ¿Desea instalarla ahora?", "Actualización Disponible", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        // Ejecutar el instalador
                        StartInstaller(setupFilePath);
                    }
                }
                else
                {
                    MessageBox.Show("El archivo de actualización no se encontró en la ubicación especificada.");
                }
            }
        }

        private void StartInstaller(string installerPath)
        {
            try
            {
                // Configurar el proceso para ejecutar el setup.exe
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = installerPath,
                    Arguments = "/silent", // Argumentos opcionales para ejecutar en modo silencioso (sin interacción con el usuario)
                    UseShellExecute = true
                };

                // Iniciar el proceso
                Process.Start(processStartInfo);

                // Opcional: Cerrar la aplicación actual
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar el instalador: {ex.Message}");
            }
        }
    }
}