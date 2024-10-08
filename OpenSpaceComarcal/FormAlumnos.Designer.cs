﻿namespace OpenSpaceComarcal
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
            this.buttonBuscarEmpresa1 = new System.Windows.Forms.Button();
            this.textBoxNotas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.bindingSourceEmpresa = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEMail = new System.Windows.Forms.Label();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.progressBarArchivo = new System.Windows.Forms.ProgressBar();
            this.toolStripAlumnos = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonArchivo = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuExportar = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuImportar = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonInscribir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaFinBuscador = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaInicioBuscador = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonBuscarEmpresa2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonBuscarPorCampo = new System.Windows.Forms.Button();
            this.comboBoxEmpresaBusqueda = new System.Windows.Forms.ComboBox();
            this.bindingSourceBusquedaEmpresa = new System.Windows.Forms.BindingSource(this.components);
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
            this.toolStripAlumnos.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBusquedaEmpresa)).BeginInit();
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
            this.dataGridViewAlumno.Location = new System.Drawing.Point(4, 157);
            this.dataGridViewAlumno.MultiSelect = false;
            this.dataGridViewAlumno.Name = "dataGridViewAlumno";
            this.dataGridViewAlumno.ReadOnly = true;
            this.dataGridViewAlumno.RowHeadersVisible = false;
            this.dataGridViewAlumno.RowHeadersWidth = 72;
            this.dataGridViewAlumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAlumno.Size = new System.Drawing.Size(1034, 306);
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
            this.buttonCrearAlumno.Location = new System.Drawing.Point(793, 24);
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
            this.BuscarAlumno.Location = new System.Drawing.Point(908, 10);
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
            this.textBoxTelefono.Size = new System.Drawing.Size(167, 20);
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
            this.textBoxApellidos.Size = new System.Drawing.Size(167, 20);
            this.textBoxApellidos.TabIndex = 11;
            // 
            // buttonEliminarAlumno
            // 
            this.buttonEliminarAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminarAlumno.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonEliminarAlumno.Location = new System.Drawing.Point(910, 74);
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
            this.buttonModificarAlumno.Location = new System.Drawing.Point(910, 24);
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
            this.groupBox1.Controls.Add(this.buttonBuscarEmpresa1);
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
            this.groupBox1.Location = new System.Drawing.Point(8, 469);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 127);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del alumno";
            // 
            // buttonBuscarEmpresa1
            // 
            this.buttonBuscarEmpresa1.Location = new System.Drawing.Point(506, 93);
            this.buttonBuscarEmpresa1.Name = "buttonBuscarEmpresa1";
            this.buttonBuscarEmpresa1.Size = new System.Drawing.Size(24, 23);
            this.buttonBuscarEmpresa1.TabIndex = 36;
            this.buttonBuscarEmpresa1.UseVisualStyleBackColor = true;
            this.buttonBuscarEmpresa1.Click += new System.EventHandler(this.buttonBuscarEmpresa1_Click);
            // 
            // textBoxNotas
            // 
            this.textBoxNotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNotas.Location = new System.Drawing.Point(552, 54);
            this.textBoxNotas.Multiline = true;
            this.textBoxNotas.Name = "textBoxNotas";
            this.textBoxNotas.Size = new System.Drawing.Size(222, 60);
            this.textBoxNotas.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(549, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Notas";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpiar.Location = new System.Drawing.Point(793, 75);
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
            this.comboBoxEmpresa.Size = new System.Drawing.Size(136, 21);
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
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cualquier campo";
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscador.Location = new System.Drawing.Point(137, 18);
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(584, 20);
            this.textBoxBuscador.TabIndex = 4;
            // 
            // progressBarArchivo
            // 
            this.progressBarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarArchivo.Location = new System.Drawing.Point(0, 602);
            this.progressBarArchivo.Name = "progressBarArchivo";
            this.progressBarArchivo.Size = new System.Drawing.Size(1042, 10);
            this.progressBarArchivo.TabIndex = 30;
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
            this.toolStripMenuExportar.Image = global::OpenSpaceComarcal.Properties.Resources.exportar_icono;
            this.toolStripMenuExportar.Name = "toolStripMenuExportar";
            this.toolStripMenuExportar.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuExportar.Text = "Exportar";
            this.toolStripMenuExportar.Click += new System.EventHandler(this.toolStripMenuExportar_Click);
            // 
            // ToolStripMenuImportar
            // 
            this.ToolStripMenuImportar.Image = global::OpenSpaceComarcal.Properties.Resources.importar_icono;
            this.ToolStripMenuImportar.Name = "ToolStripMenuImportar";
            this.ToolStripMenuImportar.Size = new System.Drawing.Size(120, 22);
            this.ToolStripMenuImportar.Text = "Importar";
            this.ToolStripMenuImportar.Click += new System.EventHandler(this.ToolStripMenuImportar_Click);
            // 
            // buttonInscribir
            // 
            this.buttonInscribir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInscribir.Location = new System.Drawing.Point(916, 32);
            this.buttonInscribir.Name = "buttonInscribir";
            this.buttonInscribir.Size = new System.Drawing.Size(106, 34);
            this.buttonInscribir.TabIndex = 6;
            this.buttonInscribir.Text = "Inscripción rápida";
            this.buttonInscribir.UseVisualStyleBackColor = true;
            this.buttonInscribir.Click += new System.EventHandler(this.buttonInscribir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1030, 83);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dateTimePickerFechaFinBuscador);
            this.tabPage1.Controls.Add(this.dateTimePickerFechaInicioBuscador);
            this.tabPage1.Controls.Add(this.BuscarAlumno);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxBuscador);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1022, 57);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Buscador";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(741, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "F. Fin";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(741, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "F. Inicio";
            // 
            // dateTimePickerFechaFinBuscador
            // 
            this.dateTimePickerFechaFinBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFechaFinBuscador.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaFinBuscador.Location = new System.Drawing.Point(801, 31);
            this.dateTimePickerFechaFinBuscador.Name = "dateTimePickerFechaFinBuscador";
            this.dateTimePickerFechaFinBuscador.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerFechaFinBuscador.TabIndex = 40;
            // 
            // dateTimePickerFechaInicioBuscador
            // 
            this.dateTimePickerFechaInicioBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFechaInicioBuscador.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaInicioBuscador.Location = new System.Drawing.Point(801, 5);
            this.dateTimePickerFechaInicioBuscador.Name = "dateTimePickerFechaInicioBuscador";
            this.dateTimePickerFechaInicioBuscador.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerFechaInicioBuscador.TabIndex = 39;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonBuscarEmpresa2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.buttonBuscarPorCampo);
            this.tabPage2.Controls.Add(this.comboBoxEmpresaBusqueda);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1022, 57);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Avanzado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarEmpresa2
            // 
            this.buttonBuscarEmpresa2.Location = new System.Drawing.Point(240, 23);
            this.buttonBuscarEmpresa2.Name = "buttonBuscarEmpresa2";
            this.buttonBuscarEmpresa2.Size = new System.Drawing.Size(24, 23);
            this.buttonBuscarEmpresa2.TabIndex = 35;
            this.buttonBuscarEmpresa2.UseVisualStyleBackColor = true;
            this.buttonBuscarEmpresa2.Click += new System.EventHandler(this.buttonBuscarEmpresa2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Por campo";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(142, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Empresa";
            // 
            // buttonBuscarPorCampo
            // 
            this.buttonBuscarPorCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscarPorCampo.Location = new System.Drawing.Point(902, 11);
            this.buttonBuscarPorCampo.Name = "buttonBuscarPorCampo";
            this.buttonBuscarPorCampo.Size = new System.Drawing.Size(106, 34);
            this.buttonBuscarPorCampo.TabIndex = 32;
            this.buttonBuscarPorCampo.Text = "Buscar por campo";
            this.buttonBuscarPorCampo.UseVisualStyleBackColor = true;
            this.buttonBuscarPorCampo.Click += new System.EventHandler(this.buttonBuscarPorCampo_Click);
            // 
            // comboBoxEmpresaBusqueda
            // 
            this.comboBoxEmpresaBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxEmpresaBusqueda.DataSource = this.bindingSourceBusquedaEmpresa;
            this.comboBoxEmpresaBusqueda.DisplayMember = "siglas";
            this.comboBoxEmpresaBusqueda.FormattingEnabled = true;
            this.comboBoxEmpresaBusqueda.Location = new System.Drawing.Point(107, 24);
            this.comboBoxEmpresaBusqueda.Name = "comboBoxEmpresaBusqueda";
            this.comboBoxEmpresaBusqueda.Size = new System.Drawing.Size(125, 21);
            this.comboBoxEmpresaBusqueda.TabIndex = 0;
            this.comboBoxEmpresaBusqueda.ValueMember = "id";
            // 
            // bindingSourceBusquedaEmpresa
            // 
            this.bindingSourceBusquedaEmpresa.DataSource = typeof(OpenSpaceComarcal.Models.empresa);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn4.DividerWidth = 2;
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
            this.fecha_registro.HeaderText = "F. Registro";
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
            this.ClientSize = new System.Drawing.Size(1050, 608);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonInscribir);
            this.Controls.Add(this.progressBarArchivo);
            this.Controls.Add(this.toolStripAlumnos);
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
            this.toolStripAlumnos.ResumeLayout(false);
            this.toolStripAlumnos.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBusquedaEmpresa)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBuscador;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEMail;
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.BindingSource bindingSourceEmpresa;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button buttonInscribir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonBuscarPorCampo;
        private System.Windows.Forms.ComboBox comboBoxEmpresaBusqueda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFinBuscador;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicioBuscador;
        private System.Windows.Forms.BindingSource bindingSourceBusquedaEmpresa;
        private System.Windows.Forms.Button buttonBuscarEmpresa1;
        private System.Windows.Forms.Button buttonBuscarEmpresa2;
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