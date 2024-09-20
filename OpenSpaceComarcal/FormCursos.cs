using OpenSpaceComarcal.Libraries;
using OpenSpaceComarcal.Models;
using System;
using System.Windows.Forms;

namespace OpenSpaceComarcal
{
    public partial class FormCursos : Form
    {

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

        public FormCursos()
        {
            InitializeComponent();

            // Ocultar barra de progreso
            progressBarArchivo.Visible = false;
        }

        private void actualizarTextBoxes()
        {
            if (dataGridViewCursos.SelectedRows.Count == 1)
            {
                DataGridViewRow fila = dataGridViewCursos.SelectedRows[0];

                textBoxSiglas.Text = fila.Cells[1].Value.ToString();
                textBoxNombre.Text = fila.Cells[2].Value.ToString();
            }
        }

        private bool camposRellenados()
        {
            bool esValido = false;
            if (
                textBoxNombre.Text != "" &&
                textBoxSiglas.Text != ""
                )
                esValido = true;
            return esValido;
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            bindingSourceCursos.DataSource = CursosOrm.Select();
        }

        private void buttonCrearCurso_Click(object sender, EventArgs e)
        {
            if (camposRellenados())
            {
                String mensajeError = "";

                curso _curso = new curso();

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
            textBoxSiglas.Text = "";
            textBoxNombre.Text = "";
            textBoxBusqueda.Text = "";
            dataGridViewCursos.ClearSelection();
        }

        private void toolStripMenuExportar_Click(object sender, EventArgs e)
        {

            // Preguntar al usuario si desea exportar los datos
            DialogResult result = MessageBox.Show("¿Desea exportar los datos seleccionados?", "Exportar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Exportar los datos a Excel
                Exportar.ExportarDataGridViewExcel(dataGridViewCursos, "Cursos", progressBarArchivo);

                // Ocultar la barra de progreso al finalizar la exportación
                progressBarArchivo.Visible = false;
            }
        }

        private void ToolStripMenuImportar_Click(object sender, EventArgs e)
        {

        }
    }
}
