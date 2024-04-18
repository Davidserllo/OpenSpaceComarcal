using System;
using System.Windows.Forms;

namespace OpenSpaceComarcal
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
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
    }
}
