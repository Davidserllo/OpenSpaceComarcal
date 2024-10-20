﻿using OpenSpaceComarcal.Libraries;
using OpenSpaceComarcal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OpenSpaceComarcal
{
    public partial class FormInscripcion : Form
    {

        public static int TAKE_EMPRESAS = 10;
        public FormInscripcion()
        {
            InitializeComponent();
            progressBarArchivo.Visible = false;
        }
        // Constructor para inscribir un alumno de alumnos más rápido
        private int id_alumno = -1;
        public FormInscripcion(int id_alumno)
        {
            InitializeComponent();
            progressBarArchivo.Visible = false;
            this.id_alumno = id_alumno;
        }

        private void Inscripcion_Load(object sender, EventArgs e)
        {
            dataGridViewInscripcion.Columns[0].FillWeight = 35;
            dataGridViewInscripcion.Columns[1].FillWeight = 120;
            dataGridViewInscripcion.Columns[2].FillWeight = 60;
            dataGridViewInscripcion.Columns[3].FillWeight = 60;
            dataGridViewInscripcion.Columns[4].FillWeight = 60;
            dataGridViewInscripcion.Columns[5].FillWeight = 65;
            dataGridViewInscripcion.Columns[6].FillWeight = 20;

            DateTime hoy = DateTime.Now;
            dateTimePickerFechaInicioBuscador.Value =
                new DateTime(hoy.Year, hoy.Month, 1);
            dateTimePickerFechaFinBuscador.Value =
                new DateTime(hoy.Year, hoy.Month, DateTime.DaysInMonth(hoy.Year, hoy.Month));
            actualizarDatos();
            iniciarPanelAvanzado();
            if (this.id_alumno != -1)
            {
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
                checkBoxApto.Checked = Convert.ToInt32(fila.Cells[6].Value) != 0;
                textBoxCodFactura.Text = fila.Cells[7].Value.ToString();
            }
        }

        private void actualizarDatos()
        {
            bindingSourceAlumno.DataSource = AlumnosOrm.Select(
                            dateTimePickerFechaInicioBuscador.Value, dateTimePickerFechaFinBuscador.Value);
            bindingSourceInstancia.DataSource = InstanciaOrm.Select(dateTimePickerFechaInicioBuscador.Value, dateTimePickerFechaFinBuscador.Value);
            bindingSourceInscipcion.DataSource = InscripcionOrm.Select(dateTimePickerFechaInicioBuscador.Value, dateTimePickerFechaFinBuscador.Value);
            bindingSourceEmpresa.DataSource = EmpresaOrm.Select(TAKE_EMPRESAS);

            bindingSourceAlumnoBusqueda.DataSource = AlumnosOrm.Select(
                            dateTimePickerFechaInicioBuscador.Value, dateTimePickerFechaFinBuscador.Value);
            bindingSourceInstanciaBusqueda.DataSource = InstanciaOrm.Select(dateTimePickerFechaInicioBuscador.Value, dateTimePickerFechaFinBuscador.Value);
            bindingSourceEmpresaBusqueda.DataSource = EmpresaOrm.Select(TAKE_EMPRESAS);
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

                instancia instancia = comboBoxInstancia.SelectedItem as instancia;


                _inscripcion.id_alumno = (int)comboBoxAlumno.SelectedValue;
                _inscripcion.id_instancia = (int)comboBoxInstancia.SelectedValue;
                _inscripcion.fecha_inscripcion = instancia.fecha_inicio;
                _inscripcion.fecha_expedicion = instancia.fecha_fin;
                _inscripcion.apto = checkBoxApto.Checked;
                _inscripcion.cod_factura = textBoxCodFactura.Text;

                mensajeError = InscripcionOrm.Insert(_inscripcion);

                if (mensajeError == "")
                {
                    MessageBox.Show("Se ha creado un nueva inscripcion del alumno " + comboBoxAlumno.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizarDatos();
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
                            actualizarDatos();
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
                        _inscripcion.apto = checkBoxApto.Checked;
                        _inscripcion.cod_factura = textBoxCodFactura.Text;

                        mensajeError = InscripcionOrm.Update(_inscripcion);

                        if (mensajeError == "")
                        {
                            MessageBox.Show("Se ha actualizado la inscripción para el alumno " + comboBoxAlumno.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            actualizarDatos();
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
                    MessageBox.Show("No debe dejar campos sin asignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonBuscarInscipcion_Click(object sender, EventArgs e)
        {
            String busqueda = textBoxBuscador.Text;
            bindingSourceInscipcion.DataSource = InscripcionOrm.Select(
                busqueda, dateTimePickerFechaInicioBuscador.Value, dateTimePickerFechaFinBuscador.Value);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            comboBoxAlumno.SelectedIndex = -1;
            comboBoxInstancia.SelectedIndex = -1;
            comboBoxEmpresa.SelectedIndex = -1;
            dataGridViewInscripcion.ClearSelection();
            checkBoxApto.Checked = false;
            textBoxCodFactura.Text = "";
            textBoxBuscador.Text = "";
            comboBoxInstanciaBusqueda.SelectedIndex = -1;
            comboBoxAlumnoBusqueda.SelectedIndex = -1;
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
                    e.Value = siglaCurso;
                }
            }
            if (e.ColumnIndex == 3)
            {
                if (e.Value != null)
                {
                    string siglaEmpresa = EmpresaOrm.SelectEmpresa(Convert.ToInt32(e.Value)).FirstOrDefault();
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
                   ? _instancia.fecha_inicio.Value.ToString("dd/MM/yy")
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
                   ? _instancia.fecha_inicio.Value.ToString("dd/MM/yy")
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
            bindingSourceInscipcion.DataSource = InscripcionOrm.SelectAvanzado(
                id_alumno, id_instancia, id_empresa, apto, 
                dateTimePickerFechaInicioBuscador.Value, dateTimePickerFechaFinBuscador.Value);
        }

        private void toolStripMenuExportar_Click(object sender, EventArgs e)
        {

            // Preguntar al usuario si desea exportar los datos
            DialogResult result = MessageBox.Show("¿Desea exportar los datos seleccionados?", "Exportar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
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
                    fileDialog.InitialDirectory = @"\\Nas01\administracion\Open_Space_Comarcal_Software\Importaciones";

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
                            _inscripcion.fecha_inscripcion = ins.fecha_inscripcion;
                            _inscripcion.fecha_expedicion = ins.fecha_expedicion;
                            _inscripcion.apto = ins.apto;
                            _inscripcion.cod_factura = ins.cod_factura;

                            messag = InscripcionOrm.Insert(_inscripcion);
                        }

                        if (messag != "")
                        {
                            MessageBox.Show($"Ha ocurrido un problema: {messag}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            MessageBox.Show($"Se han importado los alumnos", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                        actualizarDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Un error grave ocurrió: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAsistencias_Click(object sender, EventArgs e)
        {
            FormControlAsistencia ventanaControlAsistencia = new FormControlAsistencia(
                dateTimePickerFechaInicioBuscador.Value, dateTimePickerFechaFinBuscador.Value);
            ventanaControlAsistencia.ShowDialog();
        }

        private void comboBoxAlumno_Format(object sender, ListControlConvertEventArgs e)
        {
            alumno _alumno = (alumno)e.ListItem;
            string nombre = _alumno.nombre;
            string dni = _alumno.dni_nie_pasp;
            e.Value = $"{nombre} - ({dni})  ";
        }

        private void crearExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string plantillaPath = @"Z:\Open_Space_Comarcal_Software\Plantillas\Importar\IMPORTAR - ALUMNOS - INSC.xlsx";

                int añoActual = DateTime.Now.Year;
                string mesActual = DateTime.Now.ToString("MMMM", new CultureInfo("es-ES"));
                string díaActual = DateTime.Now.ToString("dd");

                string carpetaDestino = $@"Z:\Open_Space_Comarcal_Software\Importaciones\{añoActual}\{mesActual.ToUpper()}"; // Mes en mayúsculas

                if (!Directory.Exists(carpetaDestino))
                {
                    Directory.CreateDirectory(carpetaDestino);
                }

                string nombreArchivoDestino = $"INSCRIPCIONES-DIA_{díaActual}.xlsx";
                string rutaArchivoDestino = Path.Combine(carpetaDestino, nombreArchivoDestino);
                File.Copy(plantillaPath, rutaArchivoDestino, true); 

                MessageBox.Show($"Archivo creado exitosamente en la ruta: {rutaArchivoDestino}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Process.Start(rutaArchivoDestino);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear o abrir el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSourceAlumnoBusqueda.DataSource = AlumnosOrm.SelectBusqueda(comboBoxAlumnoBusqueda.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingSourceInstanciaBusqueda.DataSource = InstanciaOrm.SelectBusqueda(comboBoxInstanciaBusqueda.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindingSourceEmpresaBusqueda.DataSource = EmpresaOrm.Select(comboBoxEmpresa.Text);
        }

        private void buttonBuscarEmpresa1_Click(object sender, EventArgs e)
        {
            bindingSourceAlumno.DataSource = AlumnosOrm.SelectBusqueda(comboBoxAlumno.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSourceInstancia.DataSource = InstanciaOrm.SelectBusqueda(comboBoxInstancia.Text);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}