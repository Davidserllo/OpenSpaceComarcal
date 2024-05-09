namespace OpenSpaceComarcal
{
    partial class FormCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCursos));
            this.groupBoxBuscador = new System.Windows.Forms.GroupBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelSiglasBuscarCurso = new System.Windows.Forms.Label();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.groupBoxInformacionCurso = new System.Windows.Forms.GroupBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonModificarCurso = new System.Windows.Forms.Button();
            this.buttonEliminarCurso = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonCrearCurso = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDNINIA = new System.Windows.Forms.Label();
            this.textBoxSiglas = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelSiglas = new System.Windows.Forms.Label();
            this.dataGridViewCursos = new System.Windows.Forms.DataGridView();
            this.bindingSourceCursos = new System.Windows.Forms.BindingSource(this.components);
            this.labelCursos = new System.Windows.Forms.Label();
            this.buttonActualizarCursos = new System.Windows.Forms.Button();
            this.skinEngineCursos = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxBuscador.SuspendLayout();
            this.groupBoxInformacionCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBuscador
            // 
            this.groupBoxBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBuscador.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxBuscador.Controls.Add(this.buttonBuscar);
            this.groupBoxBuscador.Controls.Add(this.labelSiglasBuscarCurso);
            this.groupBoxBuscador.Controls.Add(this.textBoxBusqueda);
            this.groupBoxBuscador.Location = new System.Drawing.Point(8, 55);
            this.groupBoxBuscador.Name = "groupBoxBuscador";
            this.groupBoxBuscador.Size = new System.Drawing.Size(568, 52);
            this.groupBoxBuscador.TabIndex = 2;
            this.groupBoxBuscador.TabStop = false;
            this.groupBoxBuscador.Text = "Buscador";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscar.Location = new System.Drawing.Point(457, 13);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(95, 31);
            this.buttonBuscar.TabIndex = 5;
            this.buttonBuscar.Text = "Buscar Curso";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelSiglasBuscarCurso
            // 
            this.labelSiglasBuscarCurso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSiglasBuscarCurso.AutoSize = true;
            this.labelSiglasBuscarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSiglasBuscarCurso.Location = new System.Drawing.Point(6, 20);
            this.labelSiglasBuscarCurso.Name = "labelSiglasBuscarCurso";
            this.labelSiglasBuscarCurso.Size = new System.Drawing.Size(124, 16);
            this.labelSiglasBuscarCurso.TabIndex = 3;
            this.labelSiglasBuscarCurso.Text = "Cualquier campo";
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBusqueda.Location = new System.Drawing.Point(147, 18);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(293, 20);
            this.textBoxBusqueda.TabIndex = 4;
            // 
            // groupBoxInformacionCurso
            // 
            this.groupBoxInformacionCurso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInformacionCurso.Controls.Add(this.buttonLimpiar);
            this.groupBoxInformacionCurso.Controls.Add(this.buttonModificarCurso);
            this.groupBoxInformacionCurso.Controls.Add(this.buttonEliminarCurso);
            this.groupBoxInformacionCurso.Controls.Add(this.textBoxNombre);
            this.groupBoxInformacionCurso.Controls.Add(this.buttonCrearCurso);
            this.groupBoxInformacionCurso.Controls.Add(this.labelNombre);
            this.groupBoxInformacionCurso.Controls.Add(this.labelDNINIA);
            this.groupBoxInformacionCurso.Controls.Add(this.textBoxSiglas);
            this.groupBoxInformacionCurso.Controls.Add(this.textBoxCodigo);
            this.groupBoxInformacionCurso.Controls.Add(this.labelSiglas);
            this.groupBoxInformacionCurso.Location = new System.Drawing.Point(7, 424);
            this.groupBoxInformacionCurso.Name = "groupBoxInformacionCurso";
            this.groupBoxInformacionCurso.Size = new System.Drawing.Size(568, 126);
            this.groupBoxInformacionCurso.TabIndex = 7;
            this.groupBoxInformacionCurso.TabStop = false;
            this.groupBoxInformacionCurso.Text = "Informacion del Curso";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpiar.Location = new System.Drawing.Point(323, 70);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(103, 33);
            this.buttonLimpiar.TabIndex = 16;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonModificarCurso
            // 
            this.buttonModificarCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModificarCurso.Location = new System.Drawing.Point(446, 30);
            this.buttonModificarCurso.Name = "buttonModificarCurso";
            this.buttonModificarCurso.Size = new System.Drawing.Size(106, 34);
            this.buttonModificarCurso.TabIndex = 15;
            this.buttonModificarCurso.Text = "Modificar Curso";
            this.buttonModificarCurso.UseVisualStyleBackColor = true;
            this.buttonModificarCurso.Click += new System.EventHandler(this.buttonModificarCurso_Click);
            // 
            // buttonEliminarCurso
            // 
            this.buttonEliminarCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminarCurso.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonEliminarCurso.Location = new System.Drawing.Point(446, 69);
            this.buttonEliminarCurso.Name = "buttonEliminarCurso";
            this.buttonEliminarCurso.Size = new System.Drawing.Size(106, 34);
            this.buttonEliminarCurso.TabIndex = 17;
            this.buttonEliminarCurso.Text = "Eliminar Curso";
            this.buttonEliminarCurso.UseVisualStyleBackColor = true;
            this.buttonEliminarCurso.Click += new System.EventHandler(this.buttonEliminarCurso_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNombre.Location = new System.Drawing.Point(100, 88);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(194, 20);
            this.textBoxNombre.TabIndex = 13;
            // 
            // buttonCrearCurso
            // 
            this.buttonCrearCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrearCurso.Location = new System.Drawing.Point(323, 30);
            this.buttonCrearCurso.Name = "buttonCrearCurso";
            this.buttonCrearCurso.Size = new System.Drawing.Size(103, 34);
            this.buttonCrearCurso.TabIndex = 14;
            this.buttonCrearCurso.Text = "Nuevo Curso";
            this.buttonCrearCurso.UseVisualStyleBackColor = true;
            this.buttonCrearCurso.Click += new System.EventHandler(this.buttonCrearCurso_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(20, 89);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(62, 16);
            this.labelNombre.TabIndex = 12;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDNINIA
            // 
            this.labelDNINIA.AutoSize = true;
            this.labelDNINIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDNINIA.Location = new System.Drawing.Point(19, 26);
            this.labelDNINIA.Name = "labelDNINIA";
            this.labelDNINIA.Size = new System.Drawing.Size(57, 16);
            this.labelDNINIA.TabIndex = 8;
            this.labelDNINIA.Text = "Código";
            // 
            // textBoxSiglas
            // 
            this.textBoxSiglas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSiglas.Location = new System.Drawing.Point(100, 55);
            this.textBoxSiglas.Name = "textBoxSiglas";
            this.textBoxSiglas.Size = new System.Drawing.Size(193, 20);
            this.textBoxSiglas.TabIndex = 11;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCodigo.Location = new System.Drawing.Point(100, 24);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(193, 20);
            this.textBoxCodigo.TabIndex = 9;
            // 
            // labelSiglas
            // 
            this.labelSiglas.AutoSize = true;
            this.labelSiglas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSiglas.Location = new System.Drawing.Point(20, 58);
            this.labelSiglas.Name = "labelSiglas";
            this.labelSiglas.Size = new System.Drawing.Size(51, 16);
            this.labelSiglas.TabIndex = 10;
            this.labelSiglas.Text = "Siglas";
            // 
            // dataGridViewCursos
            // 
            this.dataGridViewCursos.AllowUserToAddRows = false;
            this.dataGridViewCursos.AllowUserToDeleteRows = false;
            this.dataGridViewCursos.AllowUserToOrderColumns = true;
            this.dataGridViewCursos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCursos.AutoGenerateColumns = false;
            this.dataGridViewCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewCursos.DataSource = this.bindingSourceCursos;
            this.dataGridViewCursos.Location = new System.Drawing.Point(8, 113);
            this.dataGridViewCursos.MultiSelect = false;
            this.dataGridViewCursos.Name = "dataGridViewCursos";
            this.dataGridViewCursos.ReadOnly = true;
            this.dataGridViewCursos.RowHeadersVisible = false;
            this.dataGridViewCursos.RowHeadersWidth = 72;
            this.dataGridViewCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCursos.Size = new System.Drawing.Size(568, 305);
            this.dataGridViewCursos.TabIndex = 6;
            this.dataGridViewCursos.SelectionChanged += new System.EventHandler(this.dataGridViewCursos_SelectionChanged);
            // 
            // bindingSourceCursos
            // 
            this.bindingSourceCursos.DataSource = typeof(OpenSpaceComarcal.Models.curso);
            // 
            // labelCursos
            // 
            this.labelCursos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCursos.AutoSize = true;
            this.labelCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCursos.Location = new System.Drawing.Point(245, 13);
            this.labelCursos.Name = "labelCursos";
            this.labelCursos.Size = new System.Drawing.Size(107, 31);
            this.labelCursos.TabIndex = 1;
            this.labelCursos.Text = "Cursos";
            // 
            // buttonActualizarCursos
            // 
            this.buttonActualizarCursos.Location = new System.Drawing.Point(8, 12);
            this.buttonActualizarCursos.Name = "buttonActualizarCursos";
            this.buttonActualizarCursos.Size = new System.Drawing.Size(75, 32);
            this.buttonActualizarCursos.TabIndex = 0;
            this.buttonActualizarCursos.Text = "Actualizar";
            this.buttonActualizarCursos.UseVisualStyleBackColor = true;
            this.buttonActualizarCursos.Click += new System.EventHandler(this.buttonActualizarCursos_Click);
            // 
            // skinEngineCursos
            // 
            this.skinEngineCursos.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngineCursos.SkinFile = "";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "siglas";
            this.dataGridViewTextBoxColumn2.HeaderText = "Siglas";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "instancia";
            this.dataGridViewTextBoxColumn4.HeaderText = "instancia";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // FormCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(587, 562);
            this.Controls.Add(this.buttonActualizarCursos);
            this.Controls.Add(this.groupBoxBuscador);
            this.Controls.Add(this.groupBoxInformacionCurso);
            this.Controls.Add(this.dataGridViewCursos);
            this.Controls.Add(this.labelCursos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCursos";
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
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelSiglasBuscarCurso;
        private System.Windows.Forms.TextBox textBoxBusqueda;
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
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelSiglas;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siglasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diplomaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instanciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonLimpiar;
        private Sunisoft.IrisSkin.SkinEngine skinEngineCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}