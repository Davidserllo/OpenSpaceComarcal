using OpenSpaceComarcal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSpaceComarcal
{
    public partial class CrearAlumno : Form
    {
        public CrearAlumno()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            textBoxDNI.Text= string.Empty;
            textBoxNombre.Text= string.Empty;
            textBoxApellidos.Text= string.Empty;
            textBoxTelefono.Text= string.Empty;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            String message = "";

            alumno _alumno = new alumno();

            _alumno.dni = textBoxDNI.Text;
            _alumno.apellidos = textBoxApellidos.Text;
            _alumno.nombre = textBoxNombre.Text;
            _alumno.telefono = textBoxTelefono.Text;

            message = AlumnosOrm.Insert(_alumno);

            if (message == "")
            {
                MessageBox.Show("Se ha creado un nuevo alumno llamado " + textBoxNombre.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
