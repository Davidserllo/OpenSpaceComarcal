using System;
using System.Windows.Forms;

namespace OpenSpaceComarcal
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void buttonAlumnos_Click(object sender, EventArgs e)
        {
            Alumnos ventanaAlumnos = new Alumnos();
            ventanaAlumnos.Show();
        }

        private void buttonEmpresas_Click(object sender, EventArgs e)
        {
            Empresas ventanaEmpresas = new Empresas();
            ventanaEmpresas.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Cursos ventanaCursos = new Cursos();
            ventanaCursos.Show();
        }

        private void buttonInstancia_Click(object sender, EventArgs e)
        {
            Instancia ventanaInstancia = new Instancia();
            ventanaInstancia.Show();
        }

        private void buttonInscripcion_Click(object sender, EventArgs e)
        {
            Inscripcion ventanaInscripcion = new Inscripcion();
            ventanaInscripcion.Show();
        }
    }
}
