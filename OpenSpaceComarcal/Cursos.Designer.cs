namespace OpenSpaceComarcal
{
    partial class Cursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxBuscador = new System.Windows.Forms.GroupBox();
            this.BuscarCurso = new System.Windows.Forms.Button();
            this.labelSiglasBuscarCurso = new System.Windows.Forms.Label();
            this.textBoxSiglasBuscarSiglas = new System.Windows.Forms.TextBox();
            this.groupBoxInformacionCurso = new System.Windows.Forms.GroupBox();
            this.dataGridViewCursos = new System.Windows.Forms.DataGridView();
            this.labelCursos = new System.Windows.Forms.Label();
            this.buttonActualizarCursos = new System.Windows.Forms.Button();
            this.buttonModificarCurso = new System.Windows.Forms.Button();
            this.buttonEliminarCurso = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonCrearCurso = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDNINIA = new System.Windows.Forms.Label();
            this.textBoxSiglas = new System.Windows.Forms.TextBox();
            this.textBoxDniNie = new System.Windows.Forms.TextBox();
            this.labelSiglas = new System.Windows.Forms.Label();
            this.bindingSourceCursos = new System.Windows.Forms.BindingSource(this.components);
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siglasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diplomaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instanciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxBuscador.SuspendLayout();
            this.groupBoxInformacionCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBuscador
            // 
            this.groupBoxBuscador.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxBuscador.Controls.Add(this.BuscarCurso);
            this.groupBoxBuscador.Controls.Add(this.labelSiglasBuscarCurso);
            this.groupBoxBuscador.Controls.Add(this.textBoxSiglasBuscarSiglas);
            this.groupBoxBuscador.Location = new System.Drawing.Point(8, 55);
            this.groupBoxBuscador.Name = "groupBoxBuscador";
            this.groupBoxBuscador.Size = new System.Drawing.Size(527, 52);
            this.groupBoxBuscador.TabIndex = 22;
            this.groupBoxBuscador.TabStop = false;
            this.groupBoxBuscador.Text = "Buscador";
            // 
            // BuscarCurso
            // 
            this.BuscarCurso.Location = new System.Drawing.Point(416, 13);
            this.BuscarCurso.Name = "BuscarCurso";
            this.BuscarCurso.Size = new System.Drawing.Size(95, 31);
            this.BuscarCurso.TabIndex = 0;
            this.BuscarCurso.Text = "Buscar Curso";
            this.BuscarCurso.UseVisualStyleBackColor = true;
            // 
            // labelSiglasBuscarCurso
            // 
            this.labelSiglasBuscarCurso.AutoSize = true;
            this.labelSiglasBuscarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSiglasBuscarCurso.Location = new System.Drawing.Point(6, 20);
            this.labelSiglasBuscarCurso.Name = "labelSiglasBuscarCurso";
            this.labelSiglasBuscarCurso.Size = new System.Drawing.Size(124, 16);
            this.labelSiglasBuscarCurso.TabIndex = 5;
            this.labelSiglasBuscarCurso.Text = "Cualquier campo";
            // 
            // textBoxSiglasBuscarSiglas
            // 
            this.textBoxSiglasBuscarSiglas.Location = new System.Drawing.Point(147, 18);
            this.textBoxSiglasBuscarSiglas.Name = "textBoxSiglasBuscarSiglas";
            this.textBoxSiglasBuscarSiglas.Size = new System.Drawing.Size(252, 20);
            this.textBoxSiglasBuscarSiglas.TabIndex = 6;
            // 
            // groupBoxInformacionCurso
            // 
            this.groupBoxInformacionCurso.Controls.Add(this.buttonModificarCurso);
            this.groupBoxInformacionCurso.Controls.Add(this.buttonEliminarCurso);
            this.groupBoxInformacionCurso.Controls.Add(this.textBoxNombre);
            this.groupBoxInformacionCurso.Controls.Add(this.buttonCrearCurso);
            this.groupBoxInformacionCurso.Controls.Add(this.labelNombre);
            this.groupBoxInformacionCurso.Controls.Add(this.labelDNINIA);
            this.groupBoxInformacionCurso.Controls.Add(this.textBoxSiglas);
            this.groupBoxInformacionCurso.Controls.Add(this.textBoxDniNie);
            this.groupBoxInformacionCurso.Controls.Add(this.labelSiglas);
            this.groupBoxInformacionCurso.Location = new System.Drawing.Point(7, 352);
            this.groupBoxInformacionCurso.Name = "groupBoxInformacionCurso";
            this.groupBoxInformacionCurso.Size = new System.Drawing.Size(527, 126);
            this.groupBoxInformacionCurso.TabIndex = 21;
            this.groupBoxInformacionCurso.TabStop = false;
            this.groupBoxInformacionCurso.Text = "Informacion del Curso";
            // 
            // dataGridViewCursos
            // 
            this.dataGridViewCursos.AllowUserToAddRows = false;
            this.dataGridViewCursos.AllowUserToDeleteRows = false;
            this.dataGridViewCursos.AllowUserToOrderColumns = true;
            this.dataGridViewCursos.AutoGenerateColumns = false;
            this.dataGridViewCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.siglasDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.diplomaDataGridViewTextBoxColumn,
            this.instanciaDataGridViewTextBoxColumn});
            this.dataGridViewCursos.DataSource = this.bindingSourceCursos;
            this.dataGridViewCursos.Location = new System.Drawing.Point(8, 113);
            this.dataGridViewCursos.MultiSelect = false;
            this.dataGridViewCursos.Name = "dataGridViewCursos";
            this.dataGridViewCursos.ReadOnly = true;
            this.dataGridViewCursos.RowHeadersVisible = false;
            this.dataGridViewCursos.RowHeadersWidth = 72;
            this.dataGridViewCursos.Size = new System.Drawing.Size(527, 233);
            this.dataGridViewCursos.TabIndex = 19;
            // 
            // labelCursos
            // 
            this.labelCursos.AutoSize = true;
            this.labelCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCursos.Location = new System.Drawing.Point(225, 13);
            this.labelCursos.Name = "labelCursos";
            this.labelCursos.Size = new System.Drawing.Size(107, 31);
            this.labelCursos.TabIndex = 18;
            this.labelCursos.Text = "Cursos";
            // 
            // buttonActualizarCursos
            // 
            this.buttonActualizarCursos.Location = new System.Drawing.Point(8, 12);
            this.buttonActualizarCursos.Name = "buttonActualizarCursos";
            this.buttonActualizarCursos.Size = new System.Drawing.Size(75, 32);
            this.buttonActualizarCursos.TabIndex = 23;
            this.buttonActualizarCursos.Text = "Actualizar";
            this.buttonActualizarCursos.UseVisualStyleBackColor = true;
            // 
            // buttonModificarCurso
            // 
            this.buttonModificarCurso.Location = new System.Drawing.Point(405, 30);
            this.buttonModificarCurso.Name = "buttonModificarCurso";
            this.buttonModificarCurso.Size = new System.Drawing.Size(106, 34);
            this.buttonModificarCurso.TabIndex = 16;
            this.buttonModificarCurso.Text = "Modificar Curso";
            this.buttonModificarCurso.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarCurso
            // 
            this.buttonEliminarCurso.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonEliminarCurso.Location = new System.Drawing.Point(405, 69);
            this.buttonEliminarCurso.Name = "buttonEliminarCurso";
            this.buttonEliminarCurso.Size = new System.Drawing.Size(106, 34);
            this.buttonEliminarCurso.TabIndex = 17;
            this.buttonEliminarCurso.Text = "Eliminar Curso";
            this.buttonEliminarCurso.UseVisualStyleBackColor = true;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(100, 88);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(153, 20);
            this.textBoxNombre.TabIndex = 25;
            // 
            // buttonCrearCurso
            // 
            this.buttonCrearCurso.Location = new System.Drawing.Point(282, 30);
            this.buttonCrearCurso.Name = "buttonCrearCurso";
            this.buttonCrearCurso.Size = new System.Drawing.Size(103, 73);
            this.buttonCrearCurso.TabIndex = 26;
            this.buttonCrearCurso.Text = "Nuevo Curso";
            this.buttonCrearCurso.UseVisualStyleBackColor = true;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(20, 89);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(62, 16);
            this.labelNombre.TabIndex = 24;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDNINIA
            // 
            this.labelDNINIA.AutoSize = true;
            this.labelDNINIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDNINIA.Location = new System.Drawing.Point(19, 26);
            this.labelDNINIA.Name = "labelDNINIA";
            this.labelDNINIA.Size = new System.Drawing.Size(57, 16);
            this.labelDNINIA.TabIndex = 18;
            this.labelDNINIA.Text = "Código";
            // 
            // textBoxSiglas
            // 
            this.textBoxSiglas.Location = new System.Drawing.Point(100, 55);
            this.textBoxSiglas.Name = "textBoxSiglas";
            this.textBoxSiglas.Size = new System.Drawing.Size(152, 20);
            this.textBoxSiglas.TabIndex = 23;
            // 
            // textBoxDniNie
            // 
            this.textBoxDniNie.Location = new System.Drawing.Point(100, 24);
            this.textBoxDniNie.Name = "textBoxDniNie";
            this.textBoxDniNie.Size = new System.Drawing.Size(152, 20);
            this.textBoxDniNie.TabIndex = 19;
            // 
            // labelSiglas
            // 
            this.labelSiglas.AutoSize = true;
            this.labelSiglas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSiglas.Location = new System.Drawing.Point(20, 58);
            this.labelSiglas.Name = "labelSiglas";
            this.labelSiglas.Size = new System.Drawing.Size(51, 16);
            this.labelSiglas.TabIndex = 22;
            this.labelSiglas.Text = "Siglas";
            // 
            // bindingSourceCursos
            // 
            this.bindingSourceCursos.DataSource = typeof(OpenSpaceComarcal.Models.curso);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siglasDataGridViewTextBoxColumn
            // 
            this.siglasDataGridViewTextBoxColumn.DataPropertyName = "siglas";
            this.siglasDataGridViewTextBoxColumn.HeaderText = "Siglas";
            this.siglasDataGridViewTextBoxColumn.Name = "siglasDataGridViewTextBoxColumn";
            this.siglasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diplomaDataGridViewTextBoxColumn
            // 
            this.diplomaDataGridViewTextBoxColumn.DataPropertyName = "diploma";
            this.diplomaDataGridViewTextBoxColumn.HeaderText = "diploma";
            this.diplomaDataGridViewTextBoxColumn.Name = "diplomaDataGridViewTextBoxColumn";
            this.diplomaDataGridViewTextBoxColumn.ReadOnly = true;
            this.diplomaDataGridViewTextBoxColumn.Visible = false;
            // 
            // instanciaDataGridViewTextBoxColumn
            // 
            this.instanciaDataGridViewTextBoxColumn.DataPropertyName = "instancia";
            this.instanciaDataGridViewTextBoxColumn.HeaderText = "instancia";
            this.instanciaDataGridViewTextBoxColumn.Name = "instanciaDataGridViewTextBoxColumn";
            this.instanciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.instanciaDataGridViewTextBoxColumn.Visible = false;
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(546, 490);
            this.Controls.Add(this.buttonActualizarCursos);
            this.Controls.Add(this.groupBoxBuscador);
            this.Controls.Add(this.groupBoxInformacionCurso);
            this.Controls.Add(this.dataGridViewCursos);
            this.Controls.Add(this.labelCursos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CURSOS - OPEN SPACE COMARCAL";
            this.Load += new System.EventHandler(this.Cursos_Load);
            this.groupBoxBuscador.ResumeLayout(false);
            this.groupBoxBuscador.PerformLayout();
            this.groupBoxInformacionCurso.ResumeLayout(false);
            this.groupBoxInformacionCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBuscador;
        private System.Windows.Forms.Button BuscarCurso;
        private System.Windows.Forms.Label labelSiglasBuscarCurso;
        private System.Windows.Forms.TextBox textBoxSiglasBuscarSiglas;
        private System.Windows.Forms.GroupBox groupBoxInformacionCurso;
        private System.Windows.Forms.DataGridView dataGridViewCursos;
        private System.Windows.Forms.Label labelCursos;
        private System.Windows.Forms.Button buttonActualizarCursos;
        private System.Windows.Forms.BindingSource bindingSourceCursos;
        private System.Windows.Forms.Button buttonModificarCurso;
        private System.Windows.Forms.Button buttonEliminarCurso;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonCrearCurso;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDNINIA;
        private System.Windows.Forms.TextBox textBoxSiglas;
        private System.Windows.Forms.TextBox textBoxDniNie;
        private System.Windows.Forms.Label labelSiglas;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siglasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diplomaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instanciaDataGridViewTextBoxColumn;
    }
}