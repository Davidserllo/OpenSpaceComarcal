using OpenSpaceComarcal.Libraries;
using OpenSpaceComarcal.Models;
using System;
using System.Windows.Forms;

namespace OpenSpaceComarcal
{
    public partial class FormEmpresas : Form
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

        public FormEmpresas()
        {
            InitializeComponent();
            Apariencia.AplicarApariencia(skinEngineEmpresas);
        }

        private void actualizarTextBoxes()
        {
            if (dataGridViewEmpresas.SelectedRows.Count == 1)
            {
                DataGridViewRow fila = dataGridViewEmpresas.SelectedRows[0];

                textBoxCif.Text = fila.Cells[1].Value.ToString();
                textBoxSiglas.Text = fila.Cells[2].Value.ToString();
                textBoxNombre.Text = fila.Cells[3].Value.ToString();
                textBoxTelefono.Text = fila.Cells[4].Value.ToString();
                textBoxMail.Text = fila.Cells[5].Value.ToString();
                textBoxContacto.Text = fila.Cells[6].Value.ToString();
                textBoxNotas.Text = fila.Cells[7].Value.ToString();
            }
        }

        private bool camposRellenados()
        {
            bool esValido = false;
            if (textBoxCif.Text != "" &&
                textBoxNombre.Text != "" &&
                textBoxSiglas.Text != ""
                )
                esValido = true;
            return esValido;
        }

        private void Empresas_Load(object sender, EventArgs e)
        {
            bindingSourceEmpresa.DataSource = EmpresaOrm.Select();
        }

        private void buttonCrearEmpresa_Click(object sender, EventArgs e)
        {
            if (camposRellenados())
            {
                String mensajeError = "";

                empresa _empresa = new empresa();

                _empresa.cif = textBoxCif.Text;
                _empresa.siglas = textBoxSiglas.Text;
                _empresa.nombre = textBoxNombre.Text;
                _empresa.telefono = textBoxTelefono.Text;
                _empresa.email = textBoxMail.Text;
                _empresa.persona_contacto = textBoxContacto.Text;
                _empresa.notas = textBoxNotas.Text;

                mensajeError = EmpresaOrm.Insert(_empresa);

                if (mensajeError == "")
                {
                    MessageBox.Show("Se ha creado una nueva empresa llamada " + textBoxNombre.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindingSourceEmpresa.DataSource = EmpresaOrm.Select();
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

        private void buttonModificarEmpresa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de modificar la empresa?", "Modificar Empresa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (camposRellenados())
                {
                    String mensajeError = "";

                    if (dataGridViewEmpresas.SelectedRows.Count == 1)
                    {
                        DataGridViewRow fila = dataGridViewEmpresas.SelectedRows[0];
                        empresa _empresa = (empresa)fila.DataBoundItem;

                        _empresa.cif = textBoxCif.Text;
                        _empresa.siglas = textBoxSiglas.Text;
                        _empresa.nombre = textBoxNombre.Text;
                        _empresa.telefono = textBoxTelefono.Text;
                        _empresa.email = textBoxMail.Text;
                        _empresa.persona_contacto = textBoxContacto.Text;
                        _empresa.notas = textBoxNotas.Text;

                        mensajeError = EmpresaOrm.Update(_empresa);

                        if (mensajeError == "")
                        {
                            MessageBox.Show("Se ha actualizado " + textBoxNombre.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bindingSourceEmpresa.DataSource = EmpresaOrm.Select();
                        }
                        else
                        {
                            MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay una empresa seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No debe dejar campos en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonActualizarEmpresas_Click(object sender, EventArgs e)
        {
            bindingSourceEmpresa.DataSource = EmpresaOrm.Select();
        }

        private void dataGridViewEmpresas_SelectionChanged(object sender, EventArgs e)
        {
            actualizarTextBoxes();
        }

        private void buttonEliminarEmpresa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar la empresa?", "Eliminar Empresa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (camposRellenados())
                {
                    String mensajeError = "";

                    if (dataGridViewEmpresas.SelectedRows.Count == 1)
                    {
                        DataGridViewRow fila = dataGridViewEmpresas.SelectedRows[0];
                        empresa _empresa = (empresa)fila.DataBoundItem;

                        mensajeError = EmpresaOrm.Delete(_empresa);

                        if (mensajeError == "")
                        {
                            MessageBox.Show("Se ha eliminado " + textBoxNombre.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bindingSourceEmpresa.DataSource = EmpresaOrm.Select();
                        }
                        else
                        {
                            MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay una empresa seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            bindingSourceEmpresa.DataSource = EmpresaOrm.Select(busqueda);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxCif.Text = "";
            textBoxSiglas.Text = "";
            textBoxNombre.Text = "";
            textBoxBusqueda.Text = "";
            textBoxTelefono.Text = "";
            textBoxMail.Text = "";
            textBoxContacto.Text = "";
            textBoxNotas.Text = "";
            dataGridViewEmpresas.ClearSelection();
        }
    }
}
