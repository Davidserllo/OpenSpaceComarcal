using OpenSpaceComarcal.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OpenSpaceComarcal
{
    public partial class FormAlumnos : Form
    {
        public FormAlumnos()
        {
            InitializeComponent();
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            bindingSourceAlumno.DataSource = AlumnosOrm.Select();
            bindingSourceEmpresa.DataSource = EmpresaOrm.Select();
        }

        private void actualizarTextBoxes()
        {
            if (dataGridViewAlumno.SelectedRows.Count == 1)
            {
                DataGridViewRow fila = dataGridViewAlumno.SelectedRows[0];

                textBoxDniNie.Text = fila.Cells[1].Value.ToString();
                textBoxApellidos.Text = fila.Cells[2].Value.ToString();
                textBoxNombre.Text = fila.Cells[3].Value.ToString();
                textBoxTelefono.Text = fila.Cells[4].Value.ToString();
                textBoxEmail.Text = fila.Cells[5].Value.ToString();
                if (fila.Cells[6].Value != null)
                {
                    comboBoxEmpresa.SelectedValue = fila.Cells[6].Value;
                }
                else
                {
                    comboBoxEmpresa.SelectedIndex = -1;
                }
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            bindingSourceAlumno.DataSource = AlumnosOrm.Select();
            bindingSourceEmpresa.DataSource = EmpresaOrm.Select();
        }

        private bool camposRellenados()
        {
            bool esValido = false;
            if (textBoxDniNie.Text != "" &&
                textBoxNombre.Text != "" &&
                textBoxApellidos.Text != ""
                )
                esValido = true;
            return esValido;
        }


        private void buttonCrearAlumno_Click(object sender, EventArgs e)
        {
            if (camposRellenados())
            {
                String mensajeError = "";

                alumno _alumno = new alumno();

                _alumno.dni_nie_pasp = textBoxDniNie.Text;
                _alumno.apellidos = textBoxApellidos.Text;
                _alumno.nombre = textBoxNombre.Text;
                _alumno.telefono = textBoxTelefono.Text;
                _alumno.email = textBoxEmail.Text;

                if (comboBoxEmpresa.SelectedItem != null)
                { 
                    _alumno.id_empresa = (int)comboBoxEmpresa.SelectedValue;
                }
                

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
                MessageBox.Show("Ha dejado campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewAlumno_SelectionChanged(object sender, EventArgs e)
        {
            actualizarTextBoxes();
        }

        private void buttonEliminarAlumno_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar al alumno?", "Eliminar Alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
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
        }

        private void buttonModificarAlumno_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de modificar al alumno?", "Modificar Alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (camposRellenados())
                {
                    String mensajeError = "";

                    if (dataGridViewAlumno.SelectedRows.Count == 1)
                    {
                        DataGridViewRow fila = dataGridViewAlumno.SelectedRows[0];
                        alumno _alumno = (alumno)fila.DataBoundItem;

                        _alumno.dni_nie_pasp = textBoxDniNie.Text;
                        _alumno.nombre = textBoxNombre.Text;
                        _alumno.apellidos = textBoxApellidos.Text;
                        _alumno.telefono = textBoxTelefono.Text;
                        _alumno.email = textBoxEmail.Text;

                        if (comboBoxEmpresa.SelectedItem != null)
                        {
                            _alumno.id_empresa = (int)comboBoxEmpresa.SelectedValue;
                        }

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

        private void BuscarAlumno_Click(object sender, EventArgs e)
        {
            String busqueda = textBoxBuscador.Text;
            bindingSourceAlumno.DataSource = AlumnosOrm.Select(busqueda);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxDniNie.Text = "";
            textBoxApellidos.Text = "";
            textBoxNombre.Text = "";
            textBoxTelefono.Text = "";
            textBoxEmail.Text = "";
            comboBoxEmpresa.SelectedIndex = -1;
            dataGridViewAlumno.ClearSelection();
            textBoxBuscador.Text = "";
        }

        private void dataGridViewAlumno_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (e.Value != null)
                {
                    e.Value = EmpresaOrm.Select(Convert.ToInt32(e.Value)).FirstOrDefault();
                }
                else
                {
                    e.Value = "P001";
                }
            }
        }
    }
}
