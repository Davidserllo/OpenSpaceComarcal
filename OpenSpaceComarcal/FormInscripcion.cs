using OpenSpaceComarcal.Libraries;
using OpenSpaceComarcal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OpenSpaceComarcal
{
    public partial class FormInscripcion : Form
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

        public FormInscripcion()
        {
            InitializeComponent();

            // Ocultar barra de progreso
            progressBarArchivo.Visible = false;
        }
        // Constructor para inscribir un alumno de alumnos más rápido
        private int id_alumno = -1;
        public FormInscripcion(int id_alumno)
        {
            InitializeComponent();

            // Ocultar barra de progreso
            progressBarArchivo.Visible = false;
            this.id_alumno = id_alumno;
        }

        private void Inscripcion_Load(object sender, EventArgs e)
        {
            bindingSourceAlumno.DataSource = AlumnosOrm.Select();
            bindingSourceInstancia.DataSource = InstanciaOrm.Select();
            bindingSourceInscipcion.DataSource = InscripcionOrm.Select();
            bindingSourceEmpresa.DataSource = EmpresaOrm.Select();
            iniciarPanelAvanzado();
            if (this.id_alumno != -1)
            {
                LimpiarCampos();
                comboBoxAlumno.SelectedValue = id_alumno;
            }
        }

        private void iniciarPanelAvanzado()
        {
            comboBoxInstanciaBusqueda.SelectedIndex = -1;
            comboBoxAlumnoBusqueda.SelectedIndex = -1;
            comboBoxEmpresa.SelectedIndex = -1;
        }

        private void actualizarTextBoxes()
        {
            if (dataGridViewInscripcion.SelectedRows.Count == 1)
            {
                DataGridViewRow fila = dataGridViewInscripcion.SelectedRows[0];

                comboBoxAlumno.SelectedValue = fila.Cells[1].Value;
                comboBoxInstancia.SelectedValue = fila.Cells[2].Value;
                dateTimePickerInscripcion.Text = fila.Cells[4].Value.ToString();
                dateTimePickerExpedicion.Text = fila.Cells[5].Value.ToString();
                checkBoxApto.Checked = Convert.ToInt32(fila.Cells[6].Value) != 0;
                textBoxCodFactura.Text = fila.Cells[7].Value.ToString();
            }
        }

        private void actualizarDatos()
        {
            bindingSourceAlumno.DataSource = AlumnosOrm.Select();
            bindingSourceInstancia.DataSource = InstanciaOrm.Select();
            bindingSourceInscipcion.DataSource = InscripcionOrm.Select();
            bindingSourceEmpresa.DataSource = EmpresaOrm.Select();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            actualizarDatos();
        }

        private bool camposRellenados()
        {
            bool esValido = false;
            if (comboBoxAlumno.SelectedItem != null &&
                comboBoxInstancia.SelectedItem != null
                )
                esValido = true;
            return esValido;
        }

        private void buttonCrearInscripcion_Click(object sender, EventArgs e)
        {
            if (camposRellenados())
            {
                String mensajeError = "";

                inscripcion _inscripcion = new inscripcion();

                _inscripcion.id_alumno = (int)comboBoxAlumno.SelectedValue;
                _inscripcion.id_instancia = (int)comboBoxInstancia.SelectedValue;
                _inscripcion.fecha_inscripcion = dateTimePickerInscripcion.Value;
                _inscripcion.fecha_expedicion = dateTimePickerExpedicion.Value;
                _inscripcion.apto = checkBoxApto.Checked;
                _inscripcion.cod_factura = textBoxCodFactura.Text;

                mensajeError = InscripcionOrm.Insert(_inscripcion);

                if (mensajeError == "")
                {
                    MessageBox.Show("Se ha creado un nueva inscripcion del alumno " + comboBoxAlumno.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindingSourceInscipcion.DataSource = InscripcionOrm.Select();
                }
                else
                {
                    MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ha dejado algun campo sin asignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewInscripcion_SelectionChanged(object sender, EventArgs e)
        {
            actualizarTextBoxes();
        }

        private void buttonEliminarInscripcion_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar esta inscipción?", "Eliminar Inscripción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (camposRellenados())
                {
                    String mensajeError = "";

                    if (dataGridViewInscripcion.SelectedRows.Count == 1)
                    {
                        DataGridViewRow fila = dataGridViewInscripcion.SelectedRows[0];
                        inscripcion _inscripcion = (inscripcion)fila.DataBoundItem;

                        mensajeError = InscripcionOrm.Delete(_inscripcion);

                        if (mensajeError == "")
                        {
                            MessageBox.Show("Se ha eliminado " + comboBoxAlumno.Text + " de la inscripción", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bindingSourceInscipcion.DataSource = InscripcionOrm.Select();
                        }
                        else
                        {
                            MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay una inscripción seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ha dejado campos sin asignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonModificarInscripcion_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de modificar la inscripción?", "Modificar Inscripción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (camposRellenados())
                {
                    String mensajeError = "";

                    if (dataGridViewInscripcion.SelectedRows.Count == 1)
                    {
                        DataGridViewRow fila = dataGridViewInscripcion.SelectedRows[0];
                        inscripcion _inscripcion = (inscripcion)fila.DataBoundItem;

                        _inscripcion.id_alumno = (int)comboBoxAlumno.SelectedValue;
                        _inscripcion.id_instancia = (int)comboBoxInstancia.SelectedValue;
                        _inscripcion.fecha_inscripcion = dateTimePickerInscripcion.Value;
                        _inscripcion.fecha_expedicion = dateTimePickerExpedicion.Value;
                        _inscripcion.apto = checkBoxApto.Checked;
                        _inscripcion.cod_factura = textBoxCodFactura.Text;

                        mensajeError = InscripcionOrm.Update(_inscripcion);

                        if (mensajeError != "")
                        {
                            MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Se ha actualizado la inscripción para el alumno " + comboBoxAlumno.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bindingSourceInscipcion.DataSource = InscripcionOrm.Select();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay una inscripción seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No debe dejar campos sin asignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonBuscarInscipcion_Click(object sender, EventArgs e)
        {
            String busqueda = textBoxBuscador.Text;
            bindingSourceInscipcion.DataSource = InscripcionOrm.Select(busqueda);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos y la selección
            LimpiarCampos();
        }

        private void dataGridViewInscripcion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (e.Value != null)
                {
                    string nombreAlumno = AlumnosOrm.SelectNombre(Convert.ToInt32(e.Value)).FirstOrDefault();
                    string codAlumno = AlumnosOrm.SelectCod(Convert.ToInt32(e.Value)).FirstOrDefault();
                    e.Value = nombreAlumno + " (" + codAlumno + ")";
                }
            }
            if (e.ColumnIndex == 2)
            {
                if (e.Value != null)
                {
                    string siglaCurso = CursosOrm.SelectSigla(
                        InstanciaOrm.SelectIdCurso(Convert.ToInt32(e.Value)).FirstOrDefault())
                        .FirstOrDefault();
                    string fechaPrograma = InscripcionOrm.SelectFecha(Convert.ToInt32(e.Value)).FirstOrDefault();
                    e.Value = siglaCurso + " (" + fechaPrograma + ")";
                }
            }
            if (e.ColumnIndex == 3)
            {
                if (e.Value != null)
                {
                    string siglaEmpresa = EmpresaOrm.Select(Convert.ToInt32(e.Value)).FirstOrDefault();
                    e.Value = siglaEmpresa;
                }
                else
                {
                    e.Value = "P001";
                }

            }
            if (e.ColumnIndex == 6)
            {
                if ((bool)e.Value == true)
                {
                    e.Value = "✓";
                }
                else
                {
                    e.Value = "✗";
                }
            }
        }



        private void buttonGenerarDiplomas_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();
            // Obtenemos la lista de ids y se la pasamos a la nueva ventana
            foreach (DataGridViewRow row in dataGridViewInscripcion.Rows)
            {
                if (!row.IsNewRow)
                {
                    int idInscripcion = Convert.ToInt32(row.Cells[0].Value);
                    ids.Add(idInscripcion);
                }
            }

            FormRutaDiploma formRutaDiploma = new FormRutaDiploma(ids);
            formRutaDiploma.ShowDialog();
        }


        private void comboBoxInscripBusqueda_Format(object sender, ListControlConvertEventArgs e)
        {
            instancia _instancia = (instancia)e.ListItem;
            string fecha = _instancia.fecha_inicio.HasValue
                   ? _instancia.fecha_inicio.Value.ToString("yy/MM/dd")
                   : "Error";
            string siglaCurso = CursosOrm.SelectSigla(
                        InstanciaOrm.SelectIdCurso(Convert.ToInt32(_instancia.id)).FirstOrDefault())
                        .FirstOrDefault();

            e.Value = $"{siglaCurso} - ({fecha})  ";
        }

        private void comboBoxInstancia_Format(object sender, ListControlConvertEventArgs e)
        {
            instancia _instancia = (instancia)e.ListItem;
            string fecha = _instancia.fecha_inicio.HasValue
                   ? _instancia.fecha_inicio.Value.ToString("yy/MM/dd")
                   : "Error";
            string siglaCurso = CursosOrm.SelectSigla(
                        InstanciaOrm.SelectIdCurso(Convert.ToInt32(_instancia.id)).FirstOrDefault())
                        .FirstOrDefault();

            e.Value = $"{siglaCurso} - ({fecha})  ";
        }

        private void buttonBusquedaAvanzada_Click_1(object sender, EventArgs e)
        {
            int id_alumno;
            int id_instancia;
            int id_empresa;
            if (comboBoxAlumnoBusqueda.SelectedValue == null || comboBoxAlumnoBusqueda.Text == "")
            {
                id_alumno = -1;
            }
            else
            {
                id_alumno = (int)comboBoxAlumnoBusqueda.SelectedValue;
            }

            if (comboBoxInstanciaBusqueda.SelectedValue == null || comboBoxInstanciaBusqueda.Text == "")
            {
                id_instancia = -1;
            }
            else
            {
                id_instancia = (int)comboBoxInstanciaBusqueda.SelectedValue;
            }

            if (comboBoxEmpresa.SelectedValue == null || comboBoxEmpresa.Text == "")
            {
                id_empresa = -1;
            }
            else
            {
                id_empresa = (int)comboBoxEmpresa.SelectedValue;
            }

            bool apto = checkBoxAptoBusqueda.Checked;
            bindingSourceInscipcion.DataSource = InscripcionOrm.SelectAvanzado(id_alumno, id_instancia, id_empresa, apto);
        }

        private void toolStripMenuExportar_Click(object sender, EventArgs e)
        {

            // Preguntar al usuario si desea exportar los datos
            DialogResult result = MessageBox.Show("¿Desea exportar los datos seleccionados?", "Exportar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Limpiar los campos y la selección
                LimpiarCampos();

                // Exportar los datos a Excel
                Exportar.ExportarDataGridViewExcel(dataGridViewInscripcion, "Inscripcion", progressBarArchivo);

                // Ocultar la barra de progreso al finalizar la exportación
                progressBarArchivo.Visible = false;
            }
        }

        private void ToolStripMenuImportar_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaExcel = "";
                using (OpenFileDialog fileDialog = new OpenFileDialog())
                {
                    fileDialog.Title = "Seleccione un archivo Excel para importarlo";
                    fileDialog.Filter = "Archivos Excel|*.xls;*.xlsx";
                    fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Puedes ajustar el directorio inicial como prefieras

                    // Mostrar el diálogo y obtener el resultado
                    if (fileDialog.ShowDialog() == DialogResult.OK)
                    {
                        rutaExcel = fileDialog.FileName;
                        MessageBox.Show($"Archivo Excel seleccionado: {rutaExcel}", "Archivo Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        List<inscripcion> listaInscripciones = Importar.importarInscripcionesDeExcel(rutaExcel);
                        string messag = "";
                        // Insertamos los alumnos en la BD
                        foreach (var ins in listaInscripciones)
                        {
                            inscripcion _inscripcion = new inscripcion();

                            _inscripcion.id_alumno = ins.id_alumno;
                            _inscripcion.id_instancia = ins.id_instancia;
                            _inscripcion.fecha_inscripcion = DateTime.Now;
                            _inscripcion.fecha_expedicion = DateTime.Now;
                            _inscripcion.apto = ins.apto;
                            _inscripcion.cod_factura = ins.cod_factura;

                            messag = InscripcionOrm.Insert(_inscripcion);
                        }

                        MessageBox.Show($"Se han importado los alumnos" + messag, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        actualizarDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Un error grave ocurrió: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            // Limpiar los campos y la selección
            comboBoxAlumno.SelectedIndex = -1;
            comboBoxInstancia.SelectedIndex = -1;
            comboBoxEmpresa.SelectedIndex = -1;
            dataGridViewInscripcion.ClearSelection();
            checkBoxApto.Checked = false;
            dateTimePickerExpedicion.Value = DateTime.Now;
            dateTimePickerInscripcion.Value = DateTime.Now;
            textBoxCodFactura.Text = "";
            textBoxBuscador.Text = "";
            comboBoxInstanciaBusqueda.SelectedIndex = -1;
            comboBoxAlumnoBusqueda.SelectedIndex = -1;
        }

        private void comboBoxAlumno_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBoxBuscador.Text.Trim(); // Obtener el texto del textBoxBuscador
            bindingSourceAlumno.Filter = $"nombre LIKE '*{filtro}*'";
        }

        private void comboBoxInstancia_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBoxBuscador.Text.Trim(); // Obtener el texto del textBoxBuscador
            bindingSourceInstancia.Filter = $"nombre LIKE '*{filtro}*'";
        }

        private void comboBoxAlumnoBusqueda_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBoxBuscador.Text.Trim(); // Obtener el texto del textBoxBuscador
            bindingSourceAlumno.Filter = $"nombre LIKE '*{filtro}*'";
        }

        private void comboBoxInstanciaBusqueda_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBoxBuscador.Text.Trim(); // Obtener el texto del textBoxBuscador
            bindingSourceInstancia.Filter = $"nombre LIKE '*{filtro}*'";
        }

        private void comboBoxEmpresa_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBoxBuscador.Text.Trim(); // Obtener el texto del textBoxBuscador
            bindingSourceEmpresa.Filter = $"nombre LIKE '*{filtro}*'";
        }

        private void buttonAsistencias_Click(object sender, EventArgs e)
        {
            FormControlAsistencia ventanaControlAsistencia = new FormControlAsistencia();
            ventanaControlAsistencia.ShowDialog();
        }

        private void comboBoxAlumno_Format(object sender, ListControlConvertEventArgs e)
        {
            alumno _alumno = (alumno)e.ListItem;
            string nombre = _alumno.nombre;
            string dni = _alumno.dni_nie_pasp;
            e.Value = $"{nombre} - ({dni})  ";
        }
    }
}