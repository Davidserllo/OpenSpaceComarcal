using OpenSpaceComarcal.Libraries;
using System;
using System.Windows.Forms;

namespace OpenSpaceComarcal
{
    public partial class FormInicio : Form
    {
        public static String nomApariencia;
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

        private void buttonAlumnos_Click(object sender, EventArgs e)
        {
            FormAlumnos ventanaAlumnos = new FormAlumnos();
            ventanaAlumnos.Show();
        }

        private void buttonEmpresas_Click(object sender, EventArgs e)
        {
            FormEmpresas ventanaEmpresas = new FormEmpresas();
            ventanaEmpresas.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormCursos ventanaCursos = new FormCursos();
            ventanaCursos.Show();
        }

        private void buttonInstancia_Click(object sender, EventArgs e)
        {
            FormInstancia ventanaInstancia = new FormInstancia();
            ventanaInstancia.Show();
        }

        private void buttonInscripcion_Click(object sender, EventArgs e)
        {
            FormInscripcion ventanaInscripcion = new FormInscripcion();
            ventanaInscripcion.Show();
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

    }
}
