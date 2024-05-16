using OpenSpaceComarcal.Libraries;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSpaceComarcal
{
    public partial class FormInicio : Form
    {
        private FormLoading loading;
        private static String nomApariencia;

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

        public FormInicio()
        {
            InitializeComponent();
            Apariencia.AplicarApariencia(skinEngineInicio);
            CheckTema(Properties.Settings.Default.NomApariencia);
        }

        public void CheckTema(string nomtema)
        {
            Dictionary<string, ToolStripMenuItem> temaMap = new Dictionary<string, ToolStripMenuItem>
            {
                { "EmeraldCyan.ssk", toolStripMenuEmeraldCyan },
                { "EmeraldBlue.ssk", ToolStripMenuEmeraldBlue },
                { "EmeraldGreen.ssk", ToolStripMenuEmeraldGreen },
                { "EmeraldBrown.ssk", ToolStripMenuEmeraldBrown }
            };

            foreach (var kvp in temaMap)
            {
                kvp.Value.Image = (kvp.Key == nomtema) ? Properties.Resources.check_icono : null;
            }
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
    }
}