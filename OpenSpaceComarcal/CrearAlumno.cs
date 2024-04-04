using OpenSpaceComarcal.Libraries;
using OpenSpaceComarcal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        private bool camposRellenados()
        {
            bool esValido = false;
            if (textBoxDNI.Text != "" &&
                textBoxNombre.Text != "" &&
                textBoxApellidos.Text != "" &&
                textBoxTelefono.Text != ""
                )
                esValido = true;
            return esValido;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            if (camposRellenados())
            {
                String msgError = ValidarAlumno.validarDniNie(textBoxDNI.Text);

                if (msgError == "")
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
                else
                {
                    MessageBox.Show(msgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ha dejado campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
