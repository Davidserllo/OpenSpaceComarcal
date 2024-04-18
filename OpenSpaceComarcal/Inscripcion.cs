using OpenSpaceComarcal.Libraries;
using OpenSpaceComarcal.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace OpenSpaceComarcal
{
    public partial class Inscripcion : Form
    {
        public Inscripcion()
        {
            InitializeComponent();
        }

        private void Inscripcion_Load(object sender, EventArgs e)
        {
            bindingSourceAlumno.DataSource = AlumnosOrm.Select();
            bindingSourceInstancia.DataSource = InstanciaOrm.Select();
            bindingSourceInscipcion.DataSource = InscripcionOrm.Select();
        }

        private void actualizarTextBoxes()
        {
            if (dataGridViewInscripcion.SelectedRows.Count == 1)
            {
                DataGridViewRow fila = dataGridViewInscripcion.SelectedRows[0];
                
                comboBoxAlumno.SelectedValue = fila.Cells[1].Value;
                comboBoxInstancia.SelectedValue = fila.Cells[2].Value;
                dateTimePickerInscripcion.Text = fila.Cells[3].Value.ToString();
                dateTimePickerExpedicion.Text = fila.Cells[4].Value.ToString();
                checkBoxApto.Checked = Convert.ToInt32(fila.Cells[5].Value) != 0;
                textBoxCodFactura.Text = fila.Cells[6].Value.ToString();
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            bindingSourceAlumno.DataSource = AlumnosOrm.Select();
            bindingSourceInstancia.DataSource = InstanciaOrm.Select();
            bindingSourceInscipcion.DataSource = InscripcionOrm.Select();
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

                _inscripcion.id_alumno = (int) comboBoxAlumno.SelectedValue;
                _inscripcion.id_instancia = (int) comboBoxInstancia.SelectedValue;
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
            comboBoxAlumno.SelectedIndex = -1;
            comboBoxInstancia.SelectedIndex = -1;
            dataGridViewInscripcion.ClearSelection();
            checkBoxApto.Checked = false;
            dateTimePickerExpedicion.Value = DateTime.Now;
            dateTimePickerInscripcion.Value = DateTime.Now;
            textBoxCodFactura.Text = "";
        }

        private void dataGridViewInscripcion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (e.Value != null)
                {
                    e.Value = AlumnosOrm.SelectNombre(Convert.ToInt32(e.Value)).FirstOrDefault();
                }
            }
            //if (e.ColumnIndex == 2)
            //{
            //    if (e.Value != null)
            //    {
            //        e.Value = InscripcionOrm.SelectSigla(e.Value.ToString()).FirstOrDefault();
            //    }
            //}
        }


        private void button2_Click(object sender, EventArgs e)
        {

            // Ejecuciomn del metodo Generarar diploma
            //Diploma.GenerarDiploma();

            // Ejecuciomn del metodo Generarar diploma
            //Diploma.GenerarDiploma(
            //    textBoxNombre.Text, textBoxApellidos.Text, textBoxDniNie.Text, "3327", "FCT33",
            //    DateTime.Now, DateTime.Now.AddMonths(6), DateTime.Now.AddMonths(6), "43", "ffxd", "Puerto de Sagunto");

            // Contador de milisegundos
            //Stopwatch timeMeasure = new Stopwatch();
            //timeMeasure.Start();
            //int operacion = 10 / 4;

            //// bucle para porbar velocidad de generacion de diplomas
            //int counter = 0;
            //while (counter < 20)
            //{
            //    Console.WriteLine($"Hello World! The counter is {counter}");
            //    Diploma.GenerarDiploma(
            //        counter + "Pedro David", "Serrano Llorca", "45803581R", "3327", "FCT33",
            //        DateTime.Now, DateTime.Now.AddMonths(6), DateTime.Now.AddMonths(6), "43", "ffxd", "Puerto de Sagunto");
            //    counter++;
            //}
            //timeMeasure.Stop();
            //Console.WriteLine($"Tiempo: {timeMeasure.Elapsed.TotalMilliseconds} ms");
        }
    }
}