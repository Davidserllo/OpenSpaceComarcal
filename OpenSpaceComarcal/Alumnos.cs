using OpenSpaceComarcal.Libraries;
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
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            bindingSourceAlumno.DataSource = AlumnosOrm.Select();
            actualizarTextBoxes();
        }

        private void actualizarTextBoxes()
        {
            if (dataGridViewAlumno.SelectedRows.Count == 1)
            {
                DataGridViewRow fila = dataGridViewAlumno.SelectedRows[0];

                textBoxDniNie.Text = fila.Cells[0].Value.ToString();
                textBoxApellidos.Text = fila.Cells[1].Value.ToString();
                textBoxNombre.Text = fila.Cells[2].Value.ToString();
                textBoxTelefono.Text = fila.Cells[3].Value.ToString();
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            bindingSourceAlumno.DataSource = AlumnosOrm.Select();
        }

        private bool camposRellenados()
        {
            bool esValido = false;
            if (textBoxDniNie.Text != "" &&
                textBoxNombre.Text != "" &&
                textBoxApellidos.Text != "" &&
                textBoxTelefono.Text != ""
                )
                esValido = true;
            return esValido;
        }


        private void buttonCrearAlumno_Click(object sender, EventArgs e)
        {
            if (camposRellenados())
            {
                String msgError = ValidarAlumno.validarDniNie(textBoxDniNie.Text);

                if (msgError == "")
                {
                    String mensajeError = "";

                    alumno _alumno = new alumno();

                    _alumno.dni = textBoxDniNie.Text;
                    _alumno.apellidos = textBoxApellidos.Text;
                    _alumno.nombre = textBoxNombre.Text;
                    _alumno.telefono = textBoxTelefono.Text;

                    mensajeError = AlumnosOrm.Insert(_alumno);

                    if (mensajeError == "")
                    {
                        MessageBox.Show("Se ha creado un nuevo alumno llamado " + textBoxNombre.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindingSourceAlumno.DataSource = AlumnosOrm.Select();
                    }
                    else
                    {
                        MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dataGridViewAlumno_SelectionChanged(object sender, EventArgs e)
        {
            actualizarTextBoxes();
        }

        private void buttonEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (camposRellenados())
            {
                String mensajeError = "";

                if (dataGridViewAlumno.SelectedRows.Count == 1)
                {
                    DataGridViewRow fila = dataGridViewAlumno.SelectedRows[0];
                    alumno _alumno = (alumno)fila.DataBoundItem;

                    mensajeError = AlumnosOrm.Delete(_alumno);

                    if (mensajeError == "")
                    {
                        MessageBox.Show("Se ha eliminado " + textBoxNombre.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindingSourceAlumno.DataSource = AlumnosOrm.Select();
                    }
                    else
                    {
                        MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No hay un alumno seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ha dejado campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonModificarAlumno_Click(object sender, EventArgs e)
        {
            if (camposRellenados())
            {
                String mensajeError = "";

                if (dataGridViewAlumno.SelectedRows.Count == 1)
                {
                    DataGridViewRow fila = dataGridViewAlumno.SelectedRows[0];
                    alumno _alumno = (alumno)fila.DataBoundItem;

                    _alumno.nombre = textBoxNombre.Text;
                    _alumno.apellidos = textBoxApellidos.Text;
                    _alumno.telefono= textBoxTelefono.Text;

                    mensajeError = AlumnosOrm.Update(_alumno);

                    if (mensajeError != "")
                    {
                        MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Se ha actualizado " + textBoxNombre.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindingSourceAlumno.DataSource = AlumnosOrm.Select();
                    }
                }
                else
                {
                    MessageBox.Show("No hay un alumno seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No debe dejar campos en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
