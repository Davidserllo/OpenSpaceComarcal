using System;
using System.Windows.Forms;

namespace OpenSpaceComarcal
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void toolStripButtonCursos_Click(object sender, EventArgs e)
        {
            Cursos frm = new Cursos();
            frm.Show();
        }

        private void pictureBoxAlumnos_Click(object sender, EventArgs e)
        {
            Alumnos frm = new Alumnos();
            frm.Show();
        }

        private void buttonAlumnos_Click(object sender, EventArgs e)
        {
            Alumnos frm = new Alumnos();
            frm.Show();
        }

        private void pictureBoxClientes_Click(object sender, EventArgs e)
        {
            Clientes frm = new Clientes();
            frm.Show();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            Clientes frm = new Clientes();
            frm.Show();
        }

        private void pictureBoxInstancia_Click(object sender, EventArgs e)
        {
            Instancia frm = new Instancia();
            frm.Show();
        }

        private void buttonInstancia_Click(object sender, EventArgs e)
        {
            Instancia frm = new Instancia();
            frm.Show();
        }

        private void pictureBoxInscripcion_Click(object sender, EventArgs e)
        {
            Inscripcion frm = new Inscripcion();
            frm.Show();
        }

        private void buttonInscripcion_Click(object sender, EventArgs e)
        {
            Inscripcion frm = new Inscripcion();
            frm.Show();
        }
    }
}
