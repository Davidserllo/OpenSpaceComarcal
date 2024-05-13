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
            this.labelCursos = new System.Windows.Forms.Label();
            this.skinEngineEmpresas = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.textBoxContacto = new System.Windows.Forms.TextBox();
            this.labelContacto = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNotas = new System.Windows.Forms.TextBox();
            this.bindingSourceEmpresa = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siglasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persona_contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notas = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBoxBuscador.Size = new System.Drawing.Size(939, 52);
            this.groupBoxBuscador.TabIndex = 2;
            this.groupBoxBuscador.TabStop = false;
            this.groupBoxBuscador.Text = "Buscador";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscar.Location = new System.Drawing.Point(828, 13);
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
            this.textBoxBusqueda.Size = new System.Drawing.Size(664, 20);
            this.textBoxBusqueda.TabIndex = 4;
            // 
            // groupBoxInformacionEmpresa
            // 
            this.groupBoxInformacionEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInformacionEmpresa.Controls.Add(this.textBoxNotas);
            this.groupBoxInformacionEmpresa.Controls.Add(this.label1);
            this.groupBoxInformacionEmpresa.Controls.Add(this.textBoxContacto);
            this.groupBoxInformacionEmpresa.Controls.Add(this.labelContacto);
            this.groupBoxInformacionEmpresa.Controls.Add(this.labelTelefono);
            this.groupBoxInformacionEmpresa.Controls.Add(this.textBoxMail);
            this.groupBoxInformacionEmpresa.Controls.Add(this.textBoxTelefono);
            this.groupBoxInformacionEmpresa.Controls.Add(this.labelEmail);
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
            this.groupBoxInformacionEmpresa.Location = new System.Drawing.Point(11, 450);
            this.groupBoxInformacionEmpresa.Name = "groupBoxInformacionEmpresa";
            this.groupBoxInformacionEmpresa.Size = new System.Drawing.Size(939, 126);
            this.groupBoxInformacionEmpresa.TabIndex = 7;
            this.groupBoxInformacionEmpresa.TabStop = false;
            this.groupBoxInformacionEmpresa.Text = "Informacion de la Empresa";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpiar.Location = new System.Drawing.Point(708, 69);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(103, 40);
            this.buttonLimpiar.TabIndex = 16;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonModificarEmpresa
            // 
            this.buttonModificarEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModificarEmpresa.Location = new System.Drawing.Point(817, 26);
            this.buttonModificarEmpresa.Name = "buttonModificarEmpresa";
            this.buttonModificarEmpresa.Size = new System.Drawing.Size(106, 38);
            this.buttonModificarEmpresa.TabIndex = 15;
            this.buttonModificarEmpresa.Text = "Modificar Empresa";
            this.buttonModificarEmpresa.UseVisualStyleBackColor = true;
            this.buttonModificarEmpresa.Click += new System.EventHandler(this.buttonModificarEmpresa_Click);
            // 
            // buttonEliminarEmpresa
            // 
            this.buttonEliminarEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminarEmpresa.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonEliminarEmpresa.Location = new System.Drawing.Point(817, 69);
            this.buttonEliminarEmpresa.Name = "buttonEliminarEmpresa";
            this.buttonEliminarEmpresa.Size = new System.Drawing.Size(106, 40);
            this.buttonEliminarEmpresa.TabIndex = 17;
            this.buttonEliminarEmpresa.Text = "Eliminar Empresa";
            this.buttonEliminarEmpresa.UseVisualStyleBackColor = true;
            this.buttonEliminarEmpresa.Click += new System.EventHandler(this.buttonEliminarEmpresa_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNombre.Location = new System.Drawing.Point(94, 88);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(155, 20);
            this.textBoxNombre.TabIndex = 13;
            // 
            // buttonCrearEmpresa
            // 
            this.buttonCrearEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrearEmpresa.Location = new System.Drawing.Point(708, 25);
            this.buttonCrearEmpresa.Name = "buttonCrearEmpresa";
            this.buttonCrearEmpresa.Size = new System.Drawing.Size(103, 38);
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
            this.labelNombre.Size = new System.Drawing.Size(68, 16);
            this.labelNombre.TabIndex = 12;
            this.labelNombre.Text = "Nombre*";
            // 
            // labelDNINIA
            // 
            this.labelDNINIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDNINIA.Location = new System.Drawing.Point(19, 26);
            this.labelDNINIA.Name = "labelDNINIA";
            this.labelDNINIA.Size = new System.Drawing.Size(57, 16);
            this.labelDNINIA.TabIndex = 8;
            this.labelDNINIA.Text = "CIF*";
            // 
            // textBoxSiglas
            // 
            this.textBoxSiglas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSiglas.Location = new System.Drawing.Point(94, 55);
            this.textBoxSiglas.Name = "textBoxSiglas";
            this.textBoxSiglas.Size = new System.Drawing.Size(155, 20);
            this.textBoxSiglas.TabIndex = 11;
            // 
            // textBoxCif
            // 
            this.textBoxCif.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCif.Location = new System.Drawing.Point(94, 25);
            this.textBoxCif.Name = "textBoxCif";
            this.textBoxCif.Size = new System.Drawing.Size(155, 20);
            this.textBoxCif.TabIndex = 9;
            // 
            // labelSiglas
            // 
            this.labelSiglas.AutoSize = true;
            this.labelSiglas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSiglas.Location = new System.Drawing.Point(20, 58);
            this.labelSiglas.Name = "labelSiglas";
            this.labelSiglas.Size = new System.Drawing.Size(57, 16);
            this.labelSiglas.TabIndex = 10;
            this.labelSiglas.Text = "Siglas*";
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
            this.telefono,
            this.email,
            this.persona_contacto,
            this.notas});
            this.dataGridViewEmpresas.DataSource = this.bindingSourceEmpresa;
            this.dataGridViewEmpresas.Location = new System.Drawing.Point(12, 113);
            this.dataGridViewEmpresas.MultiSelect = false;
            this.dataGridViewEmpresas.Name = "dataGridViewEmpresas";
            this.dataGridViewEmpresas.ReadOnly = true;
            this.dataGridViewEmpresas.RowHeadersVisible = false;
            this.dataGridViewEmpresas.RowHeadersWidth = 72;
            this.dataGridViewEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmpresas.Size = new System.Drawing.Size(939, 331);
            this.dataGridViewEmpresas.TabIndex = 6;
            this.dataGridViewEmpresas.SelectionChanged += new System.EventHandler(this.dataGridViewEmpresas_SelectionChanged);
            // 
            // labelCursos
            // 
            this.labelCursos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCursos.AutoSize = true;
            this.labelCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCursos.Location = new System.Drawing.Point(409, 13);
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
            // textBoxContacto
            // 
            this.textBoxContacto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContacto.Location = new System.Drawing.Point(344, 89);
            this.textBoxContacto.Name = "textBoxContacto";
            this.textBoxContacto.Size = new System.Drawing.Size(155, 20);
            this.textBoxContacto.TabIndex = 23;
            // 
            // labelContacto
            // 
            this.labelContacto.AutoSize = true;
            this.labelContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContacto.Location = new System.Drawing.Point(264, 90);
            this.labelContacto.Name = "labelContacto";
            this.labelContacto.Size = new System.Drawing.Size(68, 16);
            this.labelContacto.TabIndex = 22;
            this.labelContacto.Text = "Contacto";
            // 
            // labelTelefono
            // 
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.Location = new System.Drawing.Point(263, 27);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(75, 16);
            this.labelTelefono.TabIndex = 18;
            this.labelTelefono.Text = "Teléfono";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMail.Location = new System.Drawing.Point(344, 56);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(155, 20);
            this.textBoxMail.TabIndex = 21;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTelefono.Location = new System.Drawing.Point(344, 27);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(155, 20);
            this.textBoxTelefono.TabIndex = 19;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(264, 59);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(51, 16);
            this.labelEmail.TabIndex = 20;
            this.labelEmail.Text = "E-mail";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Notas";
            // 
            // textBoxNotas
            // 
            this.textBoxNotas.Location = new System.Drawing.Point(517, 54);
            this.textBoxNotas.Multiline = true;
            this.textBoxNotas.Name = "textBoxNotas";
            this.textBoxNotas.Size = new System.Drawing.Size(180, 55);
            this.textBoxNotas.TabIndex = 25;
            // 
            // bindingSourceEmpresa
            // 
            this.bindingSourceEmpresa.DataSource = typeof(OpenSpaceComarcal.Models.empresa);
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
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // persona_contacto
            // 
            this.persona_contacto.DataPropertyName = "persona_contacto";
            this.persona_contacto.HeaderText = "Nombre Contacto";
            this.persona_contacto.Name = "persona_contacto";
            this.persona_contacto.ReadOnly = true;
            // 
            // notas
            // 
            this.notas.DataPropertyName = "notas";
            this.notas.HeaderText = "Notas";
            this.notas.Name = "notas";
            this.notas.ReadOnly = true;
            // 
            // FormEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 587);
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
        private Sunisoft.IrisSkin.SkinEngine skinEngineEmpresas;
        private System.Windows.Forms.TextBox textBoxContacto;
        private System.Windows.Forms.Label labelContacto;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxNotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siglasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn persona_contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn notas;
    }
}