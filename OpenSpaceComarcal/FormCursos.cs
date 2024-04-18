using OpenSpaceComarcal.Models;
using System;
using System.Windows.Forms;

namespace OpenSpaceComarcal
{
    public partial class FormCursos : Form
    {
        public FormCursos()
        {
            InitializeComponent();
        }

        private void actualizarTextBoxes()
        {
            if (dataGridViewCursos.SelectedRows.Count == 1)
            {
                DataGridViewRow fila = dataGridViewCursos.SelectedRows[0];

                textBoxCodigo.Text = fila.Cells[0].Value.ToString();
                textBoxSiglas.Text = fila.Cells[1].Value.ToString();
                textBoxNombre.Text = fila.Cells[2].Value.ToString();
            }
        }

        private bool camposRellenados()
        {
            bool esValido = false;
            if (textBoxCodigo.Text != "" &&
                textBoxNombre.Text != "" &&
                textBoxSiglas.Text != ""
                )
                esValido = true;
            return esValido;
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            bindingSourceCursos.DataSource = CursosOrm.Select();
            actualizarTextBoxes();
        }

        private void buttonCrearCurso_Click(object sender, EventArgs e)
        {
            if (camposRellenados())
            {
                String mensajeError = "";

                curso _curso = new curso();

                _curso.codigo = textBoxCodigo.Text;
                _curso.siglas = textBoxSiglas.Text;
                _curso.nombre = textBoxNombre.Text;

                mensajeError = CursosOrm.Insert(_curso);

                if (mensajeError == "")
                {
                    MessageBox.Show("Se ha creado un nuevo curso llamado " + textBoxNombre.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindingSourceCursos.DataSource = CursosOrm.Select();
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

        private void buttonModificarCurso_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de modificar el curso?", "Modificar Curso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (camposRellenados())
                {
                    String mensajeError = "";

                    if (dataGridViewCursos.SelectedRows.Count == 1)
                    {
                        DataGridViewRow fila = dataGridViewCursos.SelectedRows[0];
                        curso _curso = (curso)fila.DataBoundItem;

                        _curso.siglas = textBoxSiglas.Text;
                        _curso.nombre = textBoxNombre.Text;

                        mensajeError = CursosOrm.Update(_curso);

                        if (mensajeError != "")
                        {
                            MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Se ha actualizado " + textBoxNombre.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bindingSourceCursos.DataSource = CursosOrm.Select();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay un curso seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No debe dejar campos en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonActualizarCursos_Click(object sender, EventArgs e)
        {
            bindingSourceCursos.DataSource = CursosOrm.Select();
        }

        private void dataGridViewCursos_SelectionChanged(object sender, EventArgs e)
        {
            actualizarTextBoxes();
        }

        private void buttonEliminarCurso_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar el curso?", "Eliminar Alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (camposRellenados())
                {
                    String mensajeError = "";

                    if (dataGridViewCursos.SelectedRows.Count == 1)
                    {
                        DataGridViewRow fila = dataGridViewCursos.SelectedRows[0];
                        curso _curso = (curso)fila.DataBoundItem;

                        mensajeError = CursosOrm.Delete(_curso);

                        if (mensajeError == "")
                        {
                            MessageBox.Show("Se ha eliminado " + textBoxNombre.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bindingSourceCursos.DataSource = CursosOrm.Select();
                        }
                        else
                        {
                            MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay un curso seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ha dejado campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            String busqueda = textBoxBusqueda.Text;
            bindingSourceCursos.DataSource = CursosOrm.Select(busqueda);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxCodigo.Text = "";
            textBoxSiglas.Text = "";
            textBoxNombre.Text = "";
            textBoxBusqueda.Text = "";
            dataGridViewCursos.ClearSelection();
        }
    }
}
