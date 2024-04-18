namespace OpenSpaceComarcal
{
    partial class FormAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlumnos));
            this.labelAlumnos = new System.Windows.Forms.Label();
            this.dataGridViewAlumno = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniniepaspDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idempresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceAlumno = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCrearAlumno = new System.Windows.Forms.Button();
            this.BuscarAlumno = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxDniNie = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelDNINIA = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.buttonEliminarAlumno = new System.Windows.Forms.Button();
            this.buttonModificarAlumno = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.bindingSourceEmpresa = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEMail = new System.Windows.Forms.Label();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.skinEngineAlumnos = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAlumno)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmpresa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAlumnos
            // 
            this.labelAlumnos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAlumnos.AutoSize = true;
            this.labelAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlumnos.Location = new System.Drawing.Point(337, 12);
            this.labelAlumnos.Name = "labelAlumnos";
            this.labelAlumnos.Size = new System.Drawing.Size(126, 31);
            this.labelAlumnos.TabIndex = 1;
            this.labelAlumnos.Text = "Alumnos";
            // 
            // dataGridViewAlumno
            // 
            this.dataGridViewAlumno.AllowUserToAddRows = false;
            this.dataGridViewAlumno.AllowUserToDeleteRows = false;
            this.dataGridViewAlumno.AllowUserToOrderColumns = true;
            this.dataGridViewAlumno.AllowUserToResizeRows = false;
            this.dataGridViewAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAlumno.AutoGenerateColumns = false;
            this.dataGridViewAlumno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dniniepaspDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.emailDataGridViewTextBoxColumn,
            this.idempresaDataGridViewTextBoxColumn});
            this.dataGridViewAlumno.DataSource = this.bindingSourceAlumno;
            this.dataGridViewAlumno.Location = new System.Drawing.Point(8, 107);
            this.dataGridViewAlumno.MultiSelect = false;
            this.dataGridViewAlumno.Name = "dataGridViewAlumno";
            this.dataGridViewAlumno.ReadOnly = true;
            this.dataGridViewAlumno.RowHeadersVisible = false;
            this.dataGridViewAlumno.RowHeadersWidth = 72;
            this.dataGridViewAlumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAlumno.Size = new System.Drawing.Size(784, 266);
            this.dataGridViewAlumno.TabIndex = 6;
            this.dataGridViewAlumno.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewAlumno_CellFormatting);
            this.dataGridViewAlumno.SelectionChanged += new System.EventHandler(this.dataGridViewAlumno_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dniniepaspDataGridViewTextBoxColumn
            // 
            this.dniniepaspDataGridViewTextBoxColumn.DataPropertyName = "dni_nie_pasp";
            this.dniniepaspDataGridViewTextBoxColumn.HeaderText = "DNI/NIE/PASP";
            this.dniniepaspDataGridViewTextBoxColumn.Name = "dniniepaspDataGridViewTextBoxColumn";
            this.dniniepaspDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "apellidos";
            this.dataGridViewTextBoxColumn1.HeaderText = "Apellidos";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn3.HeaderText = "Teléfono";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idempresaDataGridViewTextBoxColumn
            // 
            this.idempresaDataGridViewTextBoxColumn.DataPropertyName = "id_empresa";
            this.idempresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.idempresaDataGridViewTextBoxColumn.Name = "idempresaDataGridViewTextBoxColumn";
            this.idempresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceAlumno
            // 
            this.bindingSourceAlumno.DataSource = typeof(OpenSpaceComarcal.Models.alumno);
            // 
            // buttonCrearAlumno
            // 
            this.buttonCrearAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrearAlumno.Location = new System.Drawing.Point(537, 33);
            this.buttonCrearAlumno.Name = "buttonCrearAlumno";
            this.buttonCrearAlumno.Size = new System.Drawing.Size(103, 41);
            this.buttonCrearAlumno.TabIndex = 20;
            this.buttonCrearAlumno.Text = "Nuevo Alumno";
            this.buttonCrearAlumno.UseVisualStyleBackColor = true;
            this.buttonCrearAlumno.Click += new System.EventHandler(this.buttonCrearAlumno_Click);
            // 
            // BuscarAlumno
            // 
            this.BuscarAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarAlumno.Location = new System.Drawing.Point(660, 12);
            this.BuscarAlumno.Name = "BuscarAlumno";
            this.BuscarAlumno.Size = new System.Drawing.Size(106, 34);
            this.BuscarAlumno.TabIndex = 5;
            this.BuscarAlumno.Text = "Buscar Alumno";
            this.BuscarAlumno.UseVisualStyleBackColor = true;
            this.BuscarAlumno.Click += new System.EventHandler(this.BuscarAlumno_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(8, 12);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(75, 31);
            this.buttonActualizar.TabIndex = 0;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(364, 63);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(153, 20);
            this.textBoxTelefono.TabIndex = 15;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.Location = new System.Drawing.Point(276, 65);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(69, 16);
            this.labelTelefono.TabIndex = 14;
            this.labelTelefono.Text = "Teléfono";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(20, 66);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(68, 16);
            this.labelNombre.TabIndex = 12;
            this.labelNombre.Text = "Nombre*";
            // 
            // textBoxDniNie
            // 
            this.textBoxDniNie.Location = new System.Drawing.Point(107, 33);
            this.textBoxDniNie.Name = "textBoxDniNie";
            this.textBoxDniNie.Size = new System.Drawing.Size(152, 20);
            this.textBoxDniNie.TabIndex = 9;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(107, 64);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(152, 20);
            this.textBoxNombre.TabIndex = 13;
            // 
            // labelDNINIA
            // 
            this.labelDNINIA.AutoSize = true;
            this.labelDNINIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDNINIA.Location = new System.Drawing.Point(19, 34);
            this.labelDNINIA.Name = "labelDNINIA";
            this.labelDNINIA.Size = new System.Drawing.Size(84, 16);
            this.labelDNINIA.TabIndex = 8;
            this.labelDNINIA.Text = "DNI/NIE/P*";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidos.Location = new System.Drawing.Point(276, 35);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(79, 16);
            this.labelApellidos.TabIndex = 10;
            this.labelApellidos.Text = "Apellidos*";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(364, 33);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(153, 20);
            this.textBoxApellidos.TabIndex = 11;
            // 
            // buttonEliminarAlumno
            // 
            this.buttonEliminarAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminarAlumno.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonEliminarAlumno.Location = new System.Drawing.Point(660, 77);
            this.buttonEliminarAlumno.Name = "buttonEliminarAlumno";
            this.buttonEliminarAlumno.Size = new System.Drawing.Size(106, 41);
            this.buttonEliminarAlumno.TabIndex = 23;
            this.buttonEliminarAlumno.Text = "Eliminar Alumno";
            this.buttonEliminarAlumno.UseVisualStyleBackColor = true;
            this.buttonEliminarAlumno.Click += new System.EventHandler(this.buttonEliminarAlumno_Click);
            // 
            // buttonModificarAlumno
            // 
            this.buttonModificarAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModificarAlumno.Location = new System.Drawing.Point(660, 33);
            this.buttonModificarAlumno.Name = "buttonModificarAlumno";
            this.buttonModificarAlumno.Size = new System.Drawing.Size(106, 41);
            this.buttonModificarAlumno.TabIndex = 21;
            this.buttonModificarAlumno.Text = "Modificar Alumno";
            this.buttonModificarAlumno.UseVisualStyleBackColor = true;
            this.buttonModificarAlumno.Click += new System.EventHandler(this.buttonModificarAlumno_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonLimpiar);
            this.groupBox1.Controls.Add(this.comboBoxEmpresa);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.labelEMail);
            this.groupBox1.Controls.Add(this.labelEmpresa);
            this.groupBox1.Controls.Add(this.buttonModificarAlumno);
            this.groupBox1.Controls.Add(this.buttonEliminarAlumno);
            this.groupBox1.Controls.Add(this.textBoxApellidos);
            this.groupBox1.Controls.Add(this.buttonCrearAlumno);
            this.groupBox1.Controls.Add(this.labelApellidos);
            this.groupBox1.Controls.Add(this.labelDNINIA);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.textBoxDniNie);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Controls.Add(this.labelTelefono);
            this.groupBox1.Controls.Add(this.textBoxTelefono);
            this.groupBox1.Location = new System.Drawing.Point(8, 379);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 136);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del alumno";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpiar.Location = new System.Drawing.Point(537, 77);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(103, 41);
            this.buttonLimpiar.TabIndex = 22;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.DataSource = this.bindingSourceEmpresa;
            this.comboBoxEmpresa.DisplayMember = "siglas";
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Location = new System.Drawing.Point(364, 94);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(153, 21);
            this.comboBoxEmpresa.TabIndex = 19;
            this.comboBoxEmpresa.ValueMember = "id";
            // 
            // bindingSourceEmpresa
            // 
            this.bindingSourceEmpresa.DataSource = typeof(OpenSpaceComarcal.Models.empresa);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(107, 96);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(152, 20);
            this.textBoxEmail.TabIndex = 17;
            // 
            // labelEMail
            // 
            this.labelEMail.AutoSize = true;
            this.labelEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEMail.Location = new System.Drawing.Point(20, 98);
            this.labelEMail.Name = "labelEMail";
            this.labelEMail.Size = new System.Drawing.Size(51, 16);
            this.labelEMail.TabIndex = 16;
            this.labelEMail.Text = "E-mail";
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpresa.Location = new System.Drawing.Point(276, 97);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(69, 16);
            this.labelEmpresa.TabIndex = 18;
            this.labelEmpresa.Text = "Empresa";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxBuscador);
            this.groupBox2.Controls.Add(this.BuscarAlumno);
            this.groupBox2.Location = new System.Drawing.Point(8, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 52);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscador";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cualquier campo";
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscador.Location = new System.Drawing.Point(145, 19);
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(495, 20);
            this.textBoxBuscador.TabIndex = 4;
            // 
            // skinEngineAlumnos
            // 
            this.skinEngineAlumnos.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngineAlumnos.SkinFile = "";
            // 
            // FormAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewAlumno);
            this.Controls.Add(this.labelAlumnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALUMNOS - OPEN SPACE COMARCAL";
            this.Load += new System.EventHandler(this.Alumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAlumno)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmpresa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAlumnos;
        private System.Windows.Forms.DataGridView dataGridViewAlumno;
        private System.Windows.Forms.Button buttonCrearAlumno;
        private System.Windows.Forms.Button BuscarAlumno;
        private System.Windows.Forms.BindingSource bindingSourceAlumno;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxDniNie;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelDNINIA;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.Button buttonEliminarAlumno;
        private System.Windows.Forms.Button buttonModificarAlumno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBuscador;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniniepaspDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEMail;
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.BindingSource bindingSourceEmpresa;
        private System.Windows.Forms.Button buttonLimpiar;
        private Sunisoft.IrisSkin.SkinEngine skinEngineAlumnos;
    }
}