namespace OpenSpaceComarcal
{
    partial class FormEmpresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpresas));
            this.buttonActualizarEmpresas = new System.Windows.Forms.Button();
            this.groupBoxBuscador = new System.Windows.Forms.GroupBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelSiglasBuscarCurso = new System.Windows.Forms.Label();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.groupBoxInformacionEmpresa = new System.Windows.Forms.GroupBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonModificarEmpresa = new System.Windows.Forms.Button();
            this.buttonEliminarEmpresa = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonCrearEmpresa = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDNINIA = new System.Windows.Forms.Label();
            this.textBoxSiglas = new System.Windows.Forms.TextBox();
            this.textBoxCif = new System.Windows.Forms.TextBox();
            this.labelSiglas = new System.Windows.Forms.Label();
            this.dataGridViewEmpresas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siglasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceEmpresa = new System.Windows.Forms.BindingSource(this.components);
            this.labelCursos = new System.Windows.Forms.Label();
            this.skinEngineEmpresas = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.groupBoxBuscador.SuspendLayout();
            this.groupBoxInformacionEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonActualizarEmpresas
            // 
            this.buttonActualizarEmpresas.Location = new System.Drawing.Point(12, 12);
            this.buttonActualizarEmpresas.Name = "buttonActualizarEmpresas";
            this.buttonActualizarEmpresas.Size = new System.Drawing.Size(75, 32);
            this.buttonActualizarEmpresas.TabIndex = 0;
            this.buttonActualizarEmpresas.Text = "Actualizar";
            this.buttonActualizarEmpresas.UseVisualStyleBackColor = true;
            this.buttonActualizarEmpresas.Click += new System.EventHandler(this.buttonActualizarEmpresas_Click);
            // 
            // groupBoxBuscador
            // 
            this.groupBoxBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBuscador.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxBuscador.Controls.Add(this.buttonBuscar);
            this.groupBoxBuscador.Controls.Add(this.labelSiglasBuscarCurso);
            this.groupBoxBuscador.Controls.Add(this.textBoxBusqueda);
            this.groupBoxBuscador.Location = new System.Drawing.Point(12, 55);
            this.groupBoxBuscador.Name = "groupBoxBuscador";
            this.groupBoxBuscador.Size = new System.Drawing.Size(527, 52);
            this.groupBoxBuscador.TabIndex = 2;
            this.groupBoxBuscador.TabStop = false;
            this.groupBoxBuscador.Text = "Buscador";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscar.Location = new System.Drawing.Point(416, 13);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(95, 31);
            this.buttonBuscar.TabIndex = 5;
            this.buttonBuscar.Text = "Buscar Empresa";
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
            this.textBoxBusqueda.Size = new System.Drawing.Size(252, 20);
            this.textBoxBusqueda.TabIndex = 4;
            // 
            // groupBoxInformacionEmpresa
            // 
            this.groupBoxInformacionEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInformacionEmpresa.Controls.Add(this.buttonLimpiar);
            this.groupBoxInformacionEmpresa.Controls.Add(this.buttonModificarEmpresa);
            this.groupBoxInformacionEmpresa.Controls.Add(this.buttonEliminarEmpresa);
            this.groupBoxInformacionEmpresa.Controls.Add(this.textBoxNombre);
            this.groupBoxInformacionEmpresa.Controls.Add(this.buttonCrearEmpresa);
            this.groupBoxInformacionEmpresa.Controls.Add(this.labelNombre);
            this.groupBoxInformacionEmpresa.Controls.Add(this.labelDNINIA);
            this.groupBoxInformacionEmpresa.Controls.Add(this.textBoxSiglas);
            this.groupBoxInformacionEmpresa.Controls.Add(this.textBoxCif);
            this.groupBoxInformacionEmpresa.Controls.Add(this.labelSiglas);
            this.groupBoxInformacionEmpresa.Location = new System.Drawing.Point(11, 352);
            this.groupBoxInformacionEmpresa.Name = "groupBoxInformacionEmpresa";
            this.groupBoxInformacionEmpresa.Size = new System.Drawing.Size(527, 126);
            this.groupBoxInformacionEmpresa.TabIndex = 7;
            this.groupBoxInformacionEmpresa.TabStop = false;
            this.groupBoxInformacionEmpresa.Text = "Informacion de la Empresa";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpiar.Location = new System.Drawing.Point(282, 70);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(103, 33);
            this.buttonLimpiar.TabIndex = 16;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonModificarEmpresa
            // 
            this.buttonModificarEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModificarEmpresa.Location = new System.Drawing.Point(405, 30);
            this.buttonModificarEmpresa.Name = "buttonModificarEmpresa";
            this.buttonModificarEmpresa.Size = new System.Drawing.Size(106, 34);
            this.buttonModificarEmpresa.TabIndex = 15;
            this.buttonModificarEmpresa.Text = "Modificar Empresa";
            this.buttonModificarEmpresa.UseVisualStyleBackColor = true;
            this.buttonModificarEmpresa.Click += new System.EventHandler(this.buttonModificarEmpresa_Click);
            // 
            // buttonEliminarEmpresa
            // 
            this.buttonEliminarEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminarEmpresa.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonEliminarEmpresa.Location = new System.Drawing.Point(405, 69);
            this.buttonEliminarEmpresa.Name = "buttonEliminarEmpresa";
            this.buttonEliminarEmpresa.Size = new System.Drawing.Size(106, 34);
            this.buttonEliminarEmpresa.TabIndex = 17;
            this.buttonEliminarEmpresa.Text = "Eliminar Empresa";
            this.buttonEliminarEmpresa.UseVisualStyleBackColor = true;
            this.buttonEliminarEmpresa.Click += new System.EventHandler(this.buttonEliminarEmpresa_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNombre.Location = new System.Drawing.Point(100, 88);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(153, 20);
            this.textBoxNombre.TabIndex = 13;
            // 
            // buttonCrearEmpresa
            // 
            this.buttonCrearEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrearEmpresa.Location = new System.Drawing.Point(282, 30);
            this.buttonCrearEmpresa.Name = "buttonCrearEmpresa";
            this.buttonCrearEmpresa.Size = new System.Drawing.Size(103, 34);
            this.buttonCrearEmpresa.TabIndex = 14;
            this.buttonCrearEmpresa.Text = "Nueva Empresa";
            this.buttonCrearEmpresa.UseVisualStyleBackColor = true;
            this.buttonCrearEmpresa.Click += new System.EventHandler(this.buttonCrearEmpresa_Click);
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
            this.labelDNINIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDNINIA.Location = new System.Drawing.Point(19, 26);
            this.labelDNINIA.Name = "labelDNINIA";
            this.labelDNINIA.Size = new System.Drawing.Size(57, 16);
            this.labelDNINIA.TabIndex = 8;
            this.labelDNINIA.Text = "CIF";
            // 
            // textBoxSiglas
            // 
            this.textBoxSiglas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSiglas.Location = new System.Drawing.Point(100, 55);
            this.textBoxSiglas.Name = "textBoxSiglas";
            this.textBoxSiglas.Size = new System.Drawing.Size(152, 20);
            this.textBoxSiglas.TabIndex = 11;
            // 
            // textBoxCif
            // 
            this.textBoxCif.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCif.Location = new System.Drawing.Point(100, 24);
            this.textBoxCif.Name = "textBoxCif";
            this.textBoxCif.Size = new System.Drawing.Size(152, 20);
            this.textBoxCif.TabIndex = 9;
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
            // dataGridViewEmpresas
            // 
            this.dataGridViewEmpresas.AllowUserToAddRows = false;
            this.dataGridViewEmpresas.AllowUserToDeleteRows = false;
            this.dataGridViewEmpresas.AllowUserToOrderColumns = true;
            this.dataGridViewEmpresas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmpresas.AutoGenerateColumns = false;
            this.dataGridViewEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.cifDataGridViewTextBoxColumn,
            this.siglasDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.alumnoDataGridViewTextBoxColumn});
            this.dataGridViewEmpresas.DataSource = this.bindingSourceEmpresa;
            this.dataGridViewEmpresas.Location = new System.Drawing.Point(12, 113);
            this.dataGridViewEmpresas.MultiSelect = false;
            this.dataGridViewEmpresas.Name = "dataGridViewEmpresas";
            this.dataGridViewEmpresas.ReadOnly = true;
            this.dataGridViewEmpresas.RowHeadersVisible = false;
            this.dataGridViewEmpresas.RowHeadersWidth = 72;
            this.dataGridViewEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmpresas.Size = new System.Drawing.Size(527, 233);
            this.dataGridViewEmpresas.TabIndex = 6;
            this.dataGridViewEmpresas.SelectionChanged += new System.EventHandler(this.dataGridViewEmpresas_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cifDataGridViewTextBoxColumn
            // 
            this.cifDataGridViewTextBoxColumn.DataPropertyName = "cif";
            this.cifDataGridViewTextBoxColumn.HeaderText = "CIF";
            this.cifDataGridViewTextBoxColumn.Name = "cifDataGridViewTextBoxColumn";
            this.cifDataGridViewTextBoxColumn.ReadOnly = true;
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
            // alumnoDataGridViewTextBoxColumn
            // 
            this.alumnoDataGridViewTextBoxColumn.DataPropertyName = "alumno";
            this.alumnoDataGridViewTextBoxColumn.HeaderText = "Alumno";
            this.alumnoDataGridViewTextBoxColumn.Name = "alumnoDataGridViewTextBoxColumn";
            this.alumnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.alumnoDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSourceEmpresa
            // 
            this.bindingSourceEmpresa.DataSource = typeof(OpenSpaceComarcal.Models.empresa);
            // 
            // labelCursos
            // 
            this.labelCursos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCursos.AutoSize = true;
            this.labelCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCursos.Location = new System.Drawing.Point(203, 13);
            this.labelCursos.Name = "labelCursos";
            this.labelCursos.Size = new System.Drawing.Size(144, 31);
            this.labelCursos.TabIndex = 1;
            this.labelCursos.Text = "Empresas";
            // 
            // skinEngineEmpresas
            // 
            this.skinEngineEmpresas.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngineEmpresas.SkinFile = "";
            // 
            // FormEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 489);
            this.Controls.Add(this.buttonActualizarEmpresas);
            this.Controls.Add(this.groupBoxBuscador);
            this.Controls.Add(this.groupBoxInformacionEmpresa);
            this.Controls.Add(this.dataGridViewEmpresas);
            this.Controls.Add(this.labelCursos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEmpresas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMPRESAS - OPEN SPACE COMARCAL";
            this.Load += new System.EventHandler(this.Empresas_Load);
            this.groupBoxBuscador.ResumeLayout(false);
            this.groupBoxBuscador.PerformLayout();
            this.groupBoxInformacionEmpresa.ResumeLayout(false);
            this.groupBoxInformacionEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonActualizarEmpresas;
        private System.Windows.Forms.GroupBox groupBoxBuscador;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelSiglasBuscarCurso;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.GroupBox groupBoxInformacionEmpresa;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonModificarEmpresa;
        private System.Windows.Forms.Button buttonEliminarEmpresa;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonCrearEmpresa;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDNINIA;
        private System.Windows.Forms.TextBox textBoxSiglas;
        private System.Windows.Forms.TextBox textBoxCif;
        private System.Windows.Forms.Label labelSiglas;
        private System.Windows.Forms.DataGridView dataGridViewEmpresas;
        private System.Windows.Forms.Label labelCursos;
        private System.Windows.Forms.BindingSource bindingSourceEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siglasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumnoDataGridViewTextBoxColumn;
        private Sunisoft.IrisSkin.SkinEngine skinEngineEmpresas;
    }
}