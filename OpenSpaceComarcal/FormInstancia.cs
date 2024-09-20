using OpenSpaceComarcal.Libraries;
using OpenSpaceComarcal.Models;
using System;
using System.Linq;
using System.Windows.Forms;


namespace OpenSpaceComarcal
{
    public partial class FormInstancia : Form
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

        public FormInstancia()
        {
            InitializeComponent();
        }

        private void Instancia_Load(object sender, System.EventArgs e)
        {
            bindingSourceInstancia.DataSource = InstanciaOrm.Select();
            bindingSourceCursos.DataSource = CursosOrm.Select();
            setToolTip();

            // Ocultar barra de progreso
            progressBarArchivo.Visible = false;
        }

        ToolTip toolTip1 = new ToolTip();

        private void setToolTip()
        {
            toolTip1.AutoPopDelay = 2000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(buttonSeleccionarDiploma, buttonSeleccionarDiploma.Text);
        }

        private void actualizarTextBoxes()
        {
            if (dataGridViewCurso.SelectedRows.Count == 1)
            {
                DataGridViewRow fila = dataGridViewCurso.SelectedRows[0];

                if (fila.Cells[1].Value != null)
                {
                    comboBoxCursosSiglas.SelectedValue = fila.Cells[1].Value;
                }
                else
                {
                    comboBoxCursosSiglas.SelectedIndex = -1;
                }


                dateTimePickerFechaInicio.Text = fila.Cells[2].Value.ToString();
                dateTimePickerFechaFin.Text = fila.Cells[3].Value.ToString();
                buttonSeleccionarDiploma.Text = fila.Cells[4].Value.ToString();
                textBoxCodigo.Text = fila.Cells[5].Value.ToString();
                numericUpDownSesion.Value = (int)fila.Cells[6].Value;
                toolTip1.SetToolTip(buttonSeleccionarDiploma, buttonSeleccionarDiploma.Text);
            }
        }
        private void buttonActualizar_Click(object sender, System.EventArgs e)
        {
            // Actualizar tabla
            bindingSourceCursos.DataSource = CursosOrm.Select();
            bindingSourceInstancia.DataSource = InstanciaOrm.Select();
        }
        private bool camposRellenados()
        {
            bool esValido = false;
            if (comboBoxCursosSiglas.SelectedItem != null &&
                textBoxCodigo.Text != "")
                esValido = true;
            return esValido;
        }

        private void buttonCrearPrograma_Click(object sender, System.EventArgs e)
        {
            if (camposRellenados())
            {
                String mensajeError = "";

                instancia _instancia = new instancia();

                _instancia.id_curso = (int)comboBoxCursosSiglas.SelectedValue;
                _instancia.fecha_inicio = dateTimePickerFechaInicio.Value;
                _instancia.fecha_fin = dateTimePickerFechaFin.Value;
                _instancia.diploma = buttonSeleccionarDiploma.Text;
                _instancia.codigo = textBoxCodigo.Text;
                _instancia.sesion = (int)numericUpDownSesion.Value;

                mensajeError = InstanciaOrm.Insert(_instancia);

                if (mensajeError == "")
                {
                    MessageBox.Show("Se ha creado un curso programado del curso " + comboBoxCursosSiglas.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindingSourceInstancia.DataSource = InstanciaOrm.Select();
                }
                else
                {
                    MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ha dejado el curso sin asignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonEliminarPrograma_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar el programa?", "Eliminar Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (camposRellenados())
                {
                    String mensajeError = "";

                    if (dataGridViewCurso.SelectedRows.Count == 1)
                    {
                        DataGridViewRow fila = dataGridViewCurso.SelectedRows[0];
                        instancia _instancia = (instancia)fila.DataBoundItem;

                        mensajeError = InstanciaOrm.Delete(_instancia);

                        if (mensajeError == "")
                        {
                            MessageBox.Show("Se ha eliminado el programa " + comboBoxCursosSiglas.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bindingSourceInstancia.DataSource = InstanciaOrm.Select();
                        }
                        else
                        {
                            MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay un programa seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ha dejado algun campo sin asignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewCurso_SelectionChanged(object sender, EventArgs e)
        {
            actualizarTextBoxes();
        }

        private void buttonModificarPrograma_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de modificar el programa?", "Modificar Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (camposRellenados())
                {
                    String mensajeError = "";

                    if (dataGridViewCurso.SelectedRows.Count == 1)
                    {
                        DataGridViewRow fila = dataGridViewCurso.SelectedRows[0];
                        instancia _instancia = (instancia)fila.DataBoundItem;

                        if (comboBoxCursosSiglas.SelectedItem != null)
                        {
                            _instancia.id_curso = (int)comboBoxCursosSiglas.SelectedValue;
                        }
                        _instancia.fecha_inicio = dateTimePickerFechaInicio.Value;
                        _instancia.fecha_fin = dateTimePickerFechaFin.Value;
                        _instancia.diploma = buttonSeleccionarDiploma.Text;
                        _instancia.codigo = textBoxCodigo.Text;
                        _instancia.sesion = (int)numericUpDownSesion.Value;

                        mensajeError = InstanciaOrm.Update(_instancia);

                        if (mensajeError != "")
                        {
                            MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Se ha actualizado " + comboBoxCursosSiglas.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bindingSourceInstancia.DataSource = InstanciaOrm.Select();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay un programa seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No debe dejar campos sin asignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonBuscarCurso_Click(object sender, EventArgs e)
        {
            String busqueda = textBoxBuscador.Text;
            bindingSourceInstancia.DataSource = InstanciaOrm.Select(busqueda);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            dateTimePickerFechaInicio.Value = DateTime.Now;
            dateTimePickerFechaFin.Value = DateTime.Now;
            buttonSeleccionarDiploma.Text = "Seleccionar Diploma";
            dataGridViewCurso.ClearSelection();
            comboBoxCursosSiglas.SelectedIndex = -1;
            numericUpDownSesion.Value = 1;
            textBoxBuscador.Text = "";
            textBoxCodigo.Text = "";
        }

        private void dataGridViewCurso_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (e.Value != null)
                {
                    e.Value = CursosOrm.SelectSigla((int)e.Value).FirstOrDefault();
                }
            }
        }

        private void buttonSeleccionarDiploma_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"Z:\Open_Space_Comarcal_Software\Plantillas\Diplomas";
                openFileDialog.Filter = "Microsoft Word (*.docx)|*.docx";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    buttonSeleccionarDiploma.Text = filePath;
                }
            }
        }

        private void toolStripMenuExportar_Click(object sender, EventArgs e)
        {
            // Preguntar al usuario si desea exportar los datos
            DialogResult result = MessageBox.Show("¿Desea exportar los datos seleccionados?", "Exportar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Exportar los datos a Excel
                Exportar.ExportarDataGridViewExcel(dataGridViewCurso, "Cursos_Programados", progressBarArchivo);

                // Ocultar la barra de progreso al finalizar la exportación
                progressBarArchivo.Visible = false;
            }
        }

        private void ToolStripMenuImportar_Click(object sender, EventArgs e)
        {

        }


        private void comboBoxCursosSiglas_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBoxBuscador.Text.Trim(); // Obtener el texto del textBoxBuscador
            bindingSourceCursos.Filter = $"nombre LIKE '*{filtro}*'";
        }
    }
}
