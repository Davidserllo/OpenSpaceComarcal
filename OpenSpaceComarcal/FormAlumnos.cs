﻿using OpenSpaceComarcal.Libraries;
using OpenSpaceComarcal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OpenSpaceComarcal
{
    public partial class FormAlumnos : Form
    {
        public FormAlumnos()
        {
            InitializeComponent();
            progressBarArchivo.Visible = false;
        }

        public static int TAKE_EMPRESAS = 10;

        private void Alumnos_Load(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            dateTimePickerFechaInicioBuscador.Value = 
                new DateTime(hoy.Year, hoy.Month, 1);
            dateTimePickerFechaFinBuscador.Value = 
                new DateTime(hoy.Year, hoy.Month, DateTime.DaysInMonth(hoy.Year, hoy.Month));
            comboBoxEmpresaBusqueda.SelectedIndex = -1;
            dataGridViewAlumno.Columns[0].FillWeight = 35;
            dataGridViewAlumno.Columns[1].FillWeight = 75;
            dataGridViewAlumno.Columns[2].FillWeight = 150;
            dataGridViewAlumno.Columns[4].FillWeight = 75;
            dataGridViewAlumno.Columns[5].FillWeight = 150;
            dataGridViewAlumno.Columns[7].FillWeight = 75;
            actualizarDatos();
        }

        private void actualizarDatos()
        {
            bindingSourceAlumno.DataSource = AlumnosOrm.Select(dateTimePickerFechaInicioBuscador.Value, dateTimePickerFechaFinBuscador.Value); 
            bindingSourceEmpresa.DataSource = EmpresaOrm.Select(TAKE_EMPRESAS);
            bindingSourceBusquedaEmpresa.DataSource = EmpresaOrm.Select(TAKE_EMPRESAS);
            actualizarTextBoxes();
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
                comboBoxEmpresaBusqueda.SelectedIndex = -1;
                textBoxNotas.Text = fila.Cells[8].Value.ToString();
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            actualizarDatos();
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

                if (comboBoxEmpresa.SelectedItem != null && comboBoxEmpresa.Text != "")
                {
                    _alumno.id_empresa = (int)comboBoxEmpresa.SelectedValue;
                }

                _alumno.fecha_registro = DateTime.Now;
                _alumno.notas = textBoxNotas.Text;

                mensajeError = AlumnosOrm.Insert(_alumno);

                if (mensajeError == "")
                {
                    String msg = ValidarAlumno.validarDniNie(_alumno.dni_nie_pasp);
                    if (msg != "")
                    {
                        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    MessageBox.Show("Se ha creado un nuevo alumno llamado " + textBoxNombre.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizarDatos();
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
            if (dataGridViewAlumno.SelectedRows.Count == 1)
            {
                actualizarTextBoxes();
            }
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
                            actualizarDatos();
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

                        if (comboBoxEmpresa.SelectedItem != null && comboBoxEmpresa.Text != "")
                        {
                            _alumno.id_empresa = (int)comboBoxEmpresa.SelectedValue;
                        }
                        else
                        {
                            _alumno.id_empresa = null;
                        }

                        _alumno.notas = textBoxNotas.Text;

                        mensajeError = AlumnosOrm.Update(_alumno);

                        if (mensajeError == "")
                        {
                            String msg = ValidarAlumno.validarDniNie(_alumno.dni_nie_pasp);
                            if (msg != "")
                            {
                                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            MessageBox.Show("Se ha actualizado " + textBoxNombre.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            actualizarDatos();
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
                    MessageBox.Show("No debe dejar campos en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BuscarAlumno_Click(object sender, EventArgs e)
        {
            String busqueda = textBoxBuscador.Text;
            bindingSourceAlumno.DataSource = AlumnosOrm.Select(
                busqueda, dateTimePickerFechaInicioBuscador.Value, dateTimePickerFechaFinBuscador.Value);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxBuscador.Text = "";
            textBoxDniNie.Text = "";
            textBoxApellidos.Text = "";
            textBoxNombre.Text = "";
            textBoxTelefono.Text = "";
            textBoxEmail.Text = "";
            comboBoxEmpresa.SelectedIndex = -1;
            dataGridViewAlumno.ClearSelection();
            textBoxBuscador.Text = "";
            textBoxNotas.Text = "";
            comboBoxEmpresaBusqueda.SelectedIndex = -1;
        }

        private void dataGridViewAlumno_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (e.Value != null)
                {
                    e.Value = EmpresaOrm.SelectEmpresa(Convert.ToInt32(e.Value)).FirstOrDefault();
                }
                else
                {
                    e.Value = "P001";
                }
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

                        List<alumno> listaAlumnos = Importar.importarAlumnosDeExcel(rutaExcel, progressBarArchivo);
                        string messag = "";
                        // Insertamos los alumnos en la BD
                        foreach (var alu in listaAlumnos)
                        {
                            alumno _alumno = new alumno();

                            _alumno.dni_nie_pasp = alu.dni_nie_pasp;
                            _alumno.apellidos = alu.apellidos;
                            _alumno.nombre = alu.nombre;
                            _alumno.telefono = alu.telefono;
                            _alumno.email = alu.email;
                            _alumno.id_empresa = alu.id_empresa;
                            _alumno.fecha_registro = DateTime.Now;
                            _alumno.notas = alu.notas;

                            messag = AlumnosOrm.Insert(_alumno);
                        }

                        MessageBox.Show($"Se han importado los alumnos" + messag, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        progressBarArchivo.Visible = false;
                        actualizarDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Un error ocurrió: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuExportar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea exportar los datos seleccionados?", "Exportar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Exportar.ExportarDataGridViewExcel(dataGridViewAlumno, "Alumnos", progressBarArchivo);
                OpenFileExplorer(@"\\Nas01\administracion\Open_Space_Comarcal_Software\Exportaciones");
                progressBarArchivo.Visible = false;
            }
        }

        private void buttonInscribir_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlumno.SelectedRows.Count == 1)
            {
                DataGridViewRow fila = dataGridViewAlumno.SelectedRows[0];

                FormInscripcion ventanaInscripcion = new FormInscripcion((int)fila.Cells[0].Value);
                ventanaInscripcion.Show();
            }

        }

        private void buttonBuscarPorCampo_Click(object sender, EventArgs e)
        {
            int id_empresa;
            if (comboBoxEmpresaBusqueda.SelectedValue == null || comboBoxEmpresaBusqueda.Text == "")
            {
                id_empresa = -1;
            }
            else
            {
                id_empresa = (int)comboBoxEmpresaBusqueda.SelectedValue;
            }

            bindingSourceAlumno.DataSource = AlumnosOrm.SelectAvanzado(
                id_empresa, dateTimePickerFechaInicioBuscador.Value, dateTimePickerFechaFinBuscador.Value);
        }

        private void buttonBuscarEmpresa1_Click(object sender, EventArgs e)
        {
            bindingSourceEmpresa.DataSource = EmpresaOrm.Select(comboBoxEmpresa.Text);
        }

        private void buttonBuscarEmpresa2_Click(object sender, EventArgs e)
        {
            bindingSourceBusquedaEmpresa.DataSource = EmpresaOrm.Select(comboBoxEmpresaBusqueda.Text);
        }

        private void OpenFileExplorer(string path)
        {
            try
            {
                // Verificar si la ruta existe
                if (Directory.Exists(path))
                {
                    // Iniciar el Explorador de Archivos en la ruta especificada
                    Process.Start("explorer.exe", path);
                }
                else
                {
                    MessageBox.Show("La ruta especificada no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el Explorador de Archivos: {ex.Message}");
            }
        }
    }
}
