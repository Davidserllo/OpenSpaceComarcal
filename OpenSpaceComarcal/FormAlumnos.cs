using ClosedXML.Excel;
using OpenSpaceComarcal.Libraries;
using OpenSpaceComarcal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OpenSpaceComarcal
{
    public partial class FormAlumnos : Form
    {
        public const string EXPLICACION_BUSQUEDA = "Busca la primera coincidencia de una fila." +
            " Busqueda por todos los campos exceptuando: Empresa e ID." +
            " (Use el buscador avanzado para estos)";

        private ToolTip toolTipExplicacionBusqueda;

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


        public FormAlumnos()
        {
            InitializeComponent();
            Apariencia.AplicarApariencia(skinEngineAlumnos);
            configToolTip();
        }

        private void configToolTip()
        {
            toolTipExplicacionBusqueda = new ToolTip();
            toolTipExplicacionBusqueda.AutoPopDelay = 10000;
            toolTipExplicacionBusqueda.InitialDelay = 100;
            toolTipExplicacionBusqueda.ReshowDelay = 100;
            toolTipExplicacionBusqueda.SetToolTip(groupBoxBuscador, EXPLICACION_BUSQUEDA);
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            bindingSourceAlumno.DataSource = AlumnosOrm.Select();
            bindingSourceEmpresa.DataSource = EmpresaOrm.Select();
            bindingSourceInstancia.DataSource = InstanciaOrm.Select();
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
                textBoxNotas.Text = fila.Cells[8].Value.ToString();
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            bindingSourceAlumno.DataSource = AlumnosOrm.Select();
            bindingSourceEmpresa.DataSource = EmpresaOrm.Select();
            bindingSourceInstancia.DataSource = InstanciaOrm.Select();
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

                if (comboBoxEmpresa.SelectedItem != null && comboBoxEmpresa.Text  != "")
                { 
                    _alumno.id_empresa = (int)comboBoxEmpresa.SelectedValue;
                }

                _alumno.fecha_registro = DateTime.Now;
                _alumno.notas = textBoxNotas.Text;

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
            textBoxNotas.Text = "";
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

        private List<alumno> leerAlumnosDeExcel(string rutaExcel)
        {
            var alumnos = new List<alumno>();

            try
            {
                using (var workbook = new XLWorkbook(rutaExcel))
                {
                    // Acceder a la primera hoja
                    var worksheet = workbook.Worksheet(1);

                    foreach (var row in worksheet.RowsUsed())
                    {
                        // Crear una instancia de Alumno y llenar con datos de la fila
                        var alu = new alumno
                        {
                            dni_nie_pasp = row.Cell(1).GetValue<string>(),
                            apellidos = row.Cell(2).GetValue<string>(),
                            nombre = row.Cell(3).GetValue<string>(),
                            telefono = row.Cell(4).GetValue<string>(),
                            email = row.Cell(5).GetValue<string>(),
                            id_empresa = row.Cell(6).GetValue<int>(),
                            fecha_registro = row.Cell(7).GetValue<DateTime>(),
                            notas = row.Cell(8).GetValue<string>(),
                        };

                        // Añadir el alumno a la lista
                        alumnos.Add(alu);
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Un proceso esta usando este excel, cierrelo o finalice el proceso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
            return alumnos;
        }

        private void ToolStripMenuImportar_Click(object sender, EventArgs e)
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
                }
            }
            List<alumno> listaAlumnos = leerAlumnosDeExcel(rutaExcel);
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

            dataGridViewAlumno.Refresh();
        }
    }
}
