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
            this.textBoxNotas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.bindingSourceEmpresa = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEMail = new System.Windows.Forms.Label();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.bindingSourceInstancia = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxBuscador = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.progressBarArchivo = new System.Windows.Forms.ProgressBar();
            this.skinEngineAlumnos = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.toolStripAlumnos = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonArchivo = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuExportar = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuImportar = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAlumno)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstancia)).BeginInit();
            this.groupBoxBuscador.SuspendLayout();
            this.toolStripAlumnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAlumnos
            // 
            this.labelAlumnos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAlumnos.AutoSize = true;
            this.labelAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlumnos.Location = new System.Drawing.Point(462, 28);
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
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.fecha_registro,
            this.notas});
            this.dataGridViewAlumno.DataSource = this.bindingSourceAlumno;
            this.dataGridViewAlumno.Location = new System.Drawing.Point(8, 126);
            this.dataGridViewAlumno.MultiSelect = false;
            this.dataGridViewAlumno.Name = "dataGridViewAlumno";
            this.dataGridViewAlumno.ReadOnly = true;
            this.dataGridViewAlumno.RowHeadersVisible = false;
            this.dataGridViewAlumno.RowHeadersWidth = 72;
            this.dataGridViewAlumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAlumno.Size = new System.Drawing.Size(1034, 309);
            this.dataGridViewAlumno.TabIndex = 6;
            this.dataGridViewAlumno.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewAlumno_CellFormatting);
            this.dataGridViewAlumno.SelectionChanged += new System.EventHandler(this.dataGridViewAlumno_SelectionChanged);
            // 
            // bindingSourceAlumno
            // 
            this.bindingSourceAlumno.DataSource = typeof(OpenSpaceComarcal.Models.alumno);
            // 
            // buttonCrearAlumno
            // 
            this.buttonCrearAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrearAlumno.Location = new System.Drawing.Point(793, 33);
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
            this.BuscarAlumno.Location = new System.Drawing.Point(910, 12);
            this.BuscarAlumno.Name = "BuscarAlumno";
            this.BuscarAlumno.Size = new System.Drawing.Size(106, 34);
            this.BuscarAlumno.TabIndex = 5;
            this.BuscarAlumno.Text = "Buscar Alumno";
            this.BuscarAlumno.UseVisualStyleBackColor = true;
            this.BuscarAlumno.Click += new System.EventHandler(this.BuscarAlumno_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(8, 28);
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
            this.buttonEliminarAlumno.Location = new System.Drawing.Point(910, 77);
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
            this.buttonModificarAlumno.Location = new System.Drawing.Point(910, 33);
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
            this.groupBox1.Controls.Add(this.textBoxNotas);
            this.groupBox1.Controls.Add(this.label1);
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
            this.groupBox1.Location = new System.Drawing.Point(8, 441);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 136);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del alumno";
            // 
            // textBoxNotas
            // 
            this.textBoxNotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNotas.Location = new System.Drawing.Point(535, 64);
            this.textBoxNotas.Multiline = true;
            this.textBoxNotas.Name = "textBoxNotas";
            this.textBoxNotas.Size = new System.Drawing.Size(239, 52);
            this.textBoxNotas.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Notas";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpiar.Location = new System.Drawing.Point(793, 77);
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
            // groupBoxBuscador
            // 
            this.groupBoxBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBuscador.Controls.Add(this.label3);
            this.groupBoxBuscador.Controls.Add(this.textBoxBuscador);
            this.groupBoxBuscador.Controls.Add(this.BuscarAlumno);
            this.groupBoxBuscador.Location = new System.Drawing.Point(8, 68);
            this.groupBoxBuscador.Name = "groupBoxBuscador";
            this.groupBoxBuscador.Size = new System.Drawing.Size(1034, 52);
            this.groupBoxBuscador.TabIndex = 2;
            this.groupBoxBuscador.TabStop = false;
            this.groupBoxBuscador.Text = "Buscador";
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
            this.textBoxBuscador.Size = new System.Drawing.Size(745, 20);
            this.textBoxBuscador.TabIndex = 4;
            // 
            // progressBarArchivo
            // 
            this.progressBarArchivo.Location = new System.Drawing.Point(91, 62);
            this.progressBarArchivo.Name = "progressBarArchivo";
            this.progressBarArchivo.Size = new System.Drawing.Size(869, 10);
            this.progressBarArchivo.TabIndex = 30;
            // 
            // skinEngineAlumnos
            // 
            this.skinEngineAlumnos.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngineAlumnos.SkinFile = "";
            // 
            // toolStripAlumnos
            // 
            this.toolStripAlumnos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStripAlumnos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonArchivo});
            this.toolStripAlumnos.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripAlumnos.Location = new System.Drawing.Point(0, 0);
            this.toolStripAlumnos.Name = "toolStripAlumnos";
            this.toolStripAlumnos.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripAlumnos.Size = new System.Drawing.Size(1050, 25);
            this.toolStripAlumnos.TabIndex = 20;
            this.toolStripAlumnos.Text = "toolStripAlumnos";
            // 
            // toolStripDropDownButtonArchivo
            // 
            this.toolStripDropDownButtonArchivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuExportar,
            this.ToolStripMenuImportar});
            this.toolStripDropDownButtonArchivo.Image = global::OpenSpaceComarcal.Properties.Resources.archivo_icono;
            this.toolStripDropDownButtonArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonArchivo.Name = "toolStripDropDownButtonArchivo";
            this.toolStripDropDownButtonArchivo.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButtonArchivo.Text = "Archivo";
            this.toolStripDropDownButtonArchivo.ToolTipText = "Ajustes";
            // 
            // toolStripMenuExportar
            // 
            this.toolStripMenuExportar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuExportar.Image")));
            this.toolStripMenuExportar.Name = "toolStripMenuExportar";
            this.toolStripMenuExportar.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuExportar.Text = "Exportar";
            this.toolStripMenuExportar.Click += new System.EventHandler(this.toolStripMenuExportar_Click);
            // 
            // ToolStripMenuImportar
            // 
            this.ToolStripMenuImportar.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuImportar.Image")));
            this.ToolStripMenuImportar.Name = "ToolStripMenuImportar";
            this.ToolStripMenuImportar.Size = new System.Drawing.Size(120, 22);
            this.ToolStripMenuImportar.Text = "Importar";
            this.ToolStripMenuImportar.Click += new System.EventHandler(this.ToolStripMenuImportar_Click);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dni_nie_pasp";
            this.dataGridViewTextBoxColumn5.HeaderText = "DNI/NIE/PASP";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "apellidos";
            this.dataGridViewTextBoxColumn6.HeaderText = "Apellidos";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn8.HeaderText = "Teléfono";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn9.HeaderText = "Email";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "id_empresa";
            this.dataGridViewTextBoxColumn10.HeaderText = "Empresa";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // fecha_registro
            // 
            this.fecha_registro.DataPropertyName = "fecha_registro";
            this.fecha_registro.HeaderText = "Fecha Registro";
            this.fecha_registro.Name = "fecha_registro";
            this.fecha_registro.ReadOnly = true;
            // 
            // notas
            // 
            this.notas.DataPropertyName = "notas";
            this.notas.HeaderText = "Notas";
            this.notas.Name = "notas";
            this.notas.ReadOnly = true;
            // 
            // FormAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 589);
            this.Controls.Add(this.progressBarArchivo);
            this.Controls.Add(this.toolStripAlumnos);
            this.Controls.Add(this.groupBoxBuscador);
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstancia)).EndInit();
            this.groupBoxBuscador.ResumeLayout(false);
            this.groupBoxBuscador.PerformLayout();
            this.toolStripAlumnos.ResumeLayout(false);
            this.toolStripAlumnos.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxBuscador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBuscador;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEMail;
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.BindingSource bindingSourceEmpresa;
        private System.Windows.Forms.Button buttonLimpiar;
        private Sunisoft.IrisSkin.SkinEngine skinEngineAlumnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSourceInstancia;
        private System.Windows.Forms.TextBox textBoxNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniniepaspDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip toolStripAlumnos;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonArchivo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExportar;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuImportar;
        private System.Windows.Forms.ProgressBar progressBarArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn notas;
    }
}