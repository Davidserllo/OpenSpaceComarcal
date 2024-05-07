using OpenSpaceComarcal.Libraries;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSpaceComarcal
{
    public partial class FormInicio : Form
    {

        private FormLoading loading;
        private static String nomApariencia;
        private static bool AcessoFormCursos = true;
        private static bool AcessoFormAlumnos = true;
        private static bool AcessoFormEmpresas = true;
        private static bool AcessoFormInstancia = true;
        private static bool AcessoFormInscripcion = true;
        public FormInicio()
        {
            InitializeComponent();
            Apariencia.AplicarApariencia(skinEngineInicio);
            CheckTema(Properties.Settings.Default.NomApariencia);
        }

        public void CheckTema(string nomtema)
        {
            switch (nomtema)
            {
                case "EmeraldCyan.ssk":
                    nomtema = "EmeraldCyan.ssk";
                    this.toolStripMenuEmeraldCyan.Image = Properties.Resources.check_icono;
                    this.ToolStripMenuEmeraldBlue.Image = null;
                    this.ToolStripMenuEmeraldGreen.Image = null;
                    this.ToolStripMenuEmeraldBrown.Image = null;
                    break;
                case "EmeraldBlue.ssk":
                    nomtema = "EmeraldBlue.ssk";
                    this.ToolStripMenuEmeraldBlue.Image = Properties.Resources.check_icono;
                    this.toolStripMenuEmeraldCyan.Image = null;
                    this.ToolStripMenuEmeraldGreen.Image = null;
                    this.ToolStripMenuEmeraldBrown.Image = null;
                    break;
                case "EmeraldGreen.ssk":
                    nomtema = "EmeraldGreen.ssk";
                    this.ToolStripMenuEmeraldGreen.Image = Properties.Resources.check_icono;
                    this.ToolStripMenuEmeraldBlue.Image = null;
                    this.toolStripMenuEmeraldCyan.Image = null;
                    this.ToolStripMenuEmeraldBrown.Image = null;
                    break;
                case "EmeraldBrown.ssk":
                    nomtema = "EmeraldBrown.ssk";
                    this.ToolStripMenuEmeraldBrown.Image = Properties.Resources.check_icono;
                    this.ToolStripMenuEmeraldBlue.Image = null;
                    this.ToolStripMenuEmeraldGreen.Image = null;
                    this.toolStripMenuEmeraldCyan.Image = null;
                    break;
                default:
                    break;
            }
        }

        private async void buttonAlumnos_Click(object sender, EventArgs e)
        {
            OpenForm<FormAlumnos>(AcessoFormAlumnos);
            AcessoFormAlumnos = false;
        }

        private void buttonEmpresas_Click(object sender, EventArgs e)
        {
            OpenForm<FormEmpresas>(AcessoFormEmpresas);
            AcessoFormEmpresas = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenForm<FormCursos>(AcessoFormCursos);
            AcessoFormCursos = false;
        }

        private void buttonInstancia_Click(object sender, EventArgs e)
        {
            OpenForm<FormInstancia>(AcessoFormInstancia);
            AcessoFormInstancia = false;
        }

        private void buttonInscripcion_Click(object sender, EventArgs e)
        {
            OpenForm<FormInscripcion>(AcessoFormInscripcion);
            AcessoFormInscripcion = false;
        }

        private void toolStripMenuEmeraldCyan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si desea aplicar los cambios correctamente, cierre todas las ventanas abiertas.", "Cambio de apariencia - Emerald Cyan");
            nomApariencia = "EmeraldCyan.ssk";
            Apariencia.CambiarApariencia(skinEngineInicio, nomApariencia);
            CheckTema(Properties.Settings.Default.NomApariencia);
        }

        private void ToolStripMenuEmeraldBlue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si desea aplicar los cambios correctamente, cierre todas las ventanas abiertas.", "Cambio de apariencia - Emerald Blue");
            nomApariencia = "EmeraldBlue.ssk";
            Apariencia.CambiarApariencia(skinEngineInicio, nomApariencia);
            CheckTema(Properties.Settings.Default.NomApariencia);
        }

        private void ToolStripMenuEmeraldGreen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si desea aplicar los cambios correctamente, cierre todas las ventanas abiertas.", "Cambio de apariencia - Emerald Green");
            nomApariencia = "EmeraldGreen.ssk";
            Apariencia.CambiarApariencia(skinEngineInicio, nomApariencia);
            CheckTema(Properties.Settings.Default.NomApariencia);
        }

        private void ToolStripMenuEmeraldBrown_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si desea aplicar los cambios correctamente, cierre todas las ventanas abiertas.", "Cambio de apariencia - Emerald Brown");
            nomApariencia = "EmeraldBrown.ssk";
            Apariencia.CambiarApariencia(skinEngineInicio, nomApariencia);
            CheckTema(Properties.Settings.Default.NomApariencia);
        }

        // Método para llamar a loading y abrir el formulario
        private async void OpenForm<T>(bool accessPermission) where T : Form, new()
        {
            if (accessPermission)
            {
                loading = new FormLoading();
                loading.Show();

                await Task.Delay(2000); // Timer de 2s

                T form = new T();
                form.Show();

                loading.Close();
                loading.Dispose();
            }
            else
            {
                T form = new T();
                form.Show();
            }
        }

        private void ShowLoading()
        {
            loading = new FormLoading();
            loading.Show();
        }

        private void HideLoading()
        {
            if (loading != null && !loading.IsDisposed)
            {
                loading.Close();
                loading.Dispose();
            }
        }

    }
}
