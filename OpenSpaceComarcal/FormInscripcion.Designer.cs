namespace OpenSpaceComarcal
{
    partial class FormInscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInscripcion));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.buttonBuscarInscipcion = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.bindingSourceEmpresa = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBusquedaAvanzada = new System.Windows.Forms.Button();
            this.checkBoxAptoBusqueda = new System.Windows.Forms.CheckBox();
            this.comboBoxInstanciaBusqueda = new System.Windows.Forms.ComboBox();
            this.bindingSourceInstancia = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxAlumnoBusqueda = new System.Windows.Forms.ComboBox();
            this.bindingSourceAlumno = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceInscipcion = new System.Windows.Forms.BindingSource(this.components);
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCodFactura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerExpedicion = new System.Windows.Forms.DateTimePicker();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.checkBoxApto = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerInscripcion = new System.Windows.Forms.DateTimePicker();
            this.comboBoxInstancia = new System.Windows.Forms.ComboBox();
            this.comboBoxAlumno = new System.Windows.Forms.ComboBox();
            this.buttonModificarInscripcion = new System.Windows.Forms.Button();
            this.buttonEliminarInscripcion = new System.Windows.Forms.Button();
            this.buttonCrearInscripcion = new System.Windows.Forms.Button();
            this.labelDNINIA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewInscripcion = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idinstanciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechainscripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaexpedicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codfacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelInscripcion = new System.Windows.Forms.Label();
            this.buttonGenerarDiplomas = new System.Windows.Forms.Button();
            this.skinEngineinscripcion = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.toolStripInscripcion = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonArchivo = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuExportar = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuImportar = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBarArchivo = new System.Windows.Forms.ProgressBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInscipcion)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscripcion)).BeginInit();
            this.toolStripInscripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(831, 73);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxBuscador);
            this.tabPage1.Controls.Add(this.buttonBuscarInscipcion);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(823, 47);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Buscador";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cualquier campo";
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscador.Location = new System.Drawing.Point(150, 14);
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(519, 20);
            this.textBoxBuscador.TabIndex = 5;
            // 
            // buttonBuscarInscipcion
            // 
            this.buttonBuscarInscipcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscarInscipcion.Location = new System.Drawing.Point(692, 6);
            this.buttonBuscarInscipcion.Name = "buttonBuscarInscipcion";
            this.buttonBuscarInscipcion.Size = new System.Drawing.Size(113, 34);
            this.buttonBuscarInscipcion.TabIndex = 6;
            this.buttonBuscarInscipcion.Text = "Buscar Inscripción";
            this.buttonBuscarInscipcion.UseVisualStyleBackColor = true;
            this.buttonBuscarInscipcion.Click += new System.EventHandler(this.buttonBuscarInscipcion_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.comboBoxEmpresa);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.buttonBusquedaAvanzada);
            this.tabPage2.Controls.Add(this.checkBoxAptoBusqueda);
            this.tabPage2.Controls.Add(this.comboBoxInstanciaBusqueda);
            this.tabPage2.Controls.Add(this.comboBoxAlumnoBusqueda);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(823, 47);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Avanzado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(616, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Apto";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(389, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Empresa";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(248, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Curso Prg.";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(131, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Alumno";
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxEmpresa.DataSource = this.bindingSourceEmpresa;
            this.comboBoxEmpresa.DisplayMember = "siglas";
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Location = new System.Drawing.Point(366, 19);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(114, 21);
            this.comboBoxEmpresa.TabIndex = 22;
            this.comboBoxEmpresa.ValueMember = "id";
            this.comboBoxEmpresa.TextChanged += new System.EventHandler(this.comboBoxEmpresa_TextChanged);
            // 
            // bindingSourceEmpresa
            // 
            this.bindingSourceEmpresa.DataSource = typeof(OpenSpaceComarcal.Models.empresa);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Por campo";
            // 
            // buttonBusquedaAvanzada
            // 
            this.buttonBusquedaAvanzada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBusquedaAvanzada.Location = new System.Drawing.Point(692, 6);
            this.buttonBusquedaAvanzada.Name = "buttonBusquedaAvanzada";
            this.buttonBusquedaAvanzada.Size = new System.Drawing.Size(113, 34);
            this.buttonBusquedaAvanzada.TabIndex = 20;
            this.buttonBusquedaAvanzada.Text = "Buscar Inscripción";
            this.buttonBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.buttonBusquedaAvanzada.Click += new System.EventHandler(this.buttonBusquedaAvanzada_Click_1);
            // 
            // checkBoxAptoBusqueda
            // 
            this.checkBoxAptoBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBoxAptoBusqueda.AutoSize = true;
            this.checkBoxAptoBusqueda.Location = new System.Drawing.Point(619, 22);
            this.checkBoxAptoBusqueda.Name = "checkBoxAptoBusqueda";
            this.checkBoxAptoBusqueda.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAptoBusqueda.TabIndex = 19;
            this.checkBoxAptoBusqueda.UseVisualStyleBackColor = true;
            // 
            // comboBoxInstanciaBusqueda
            // 
            this.comboBoxInstanciaBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxInstanciaBusqueda.DataSource = this.bindingSourceInstancia;
            this.comboBoxInstanciaBusqueda.DisplayMember = "id_curso";
            this.comboBoxInstanciaBusqueda.FormattingEnabled = true;
            this.comboBoxInstanciaBusqueda.Location = new System.Drawing.Point(231, 19);
            this.comboBoxInstanciaBusqueda.Name = "comboBoxInstanciaBusqueda";
            this.comboBoxInstanciaBusqueda.Size = new System.Drawing.Size(120, 21);
            this.comboBoxInstanciaBusqueda.TabIndex = 15;
            this.comboBoxInstanciaBusqueda.ValueMember = "id";
            this.comboBoxInstanciaBusqueda.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxInscripBusqueda_Format);
            this.comboBoxInstanciaBusqueda.TextChanged += new System.EventHandler(this.comboBoxInstanciaBusqueda_TextChanged);
            // 
            // bindingSourceInstancia
            // 
            this.bindingSourceInstancia.DataSource = typeof(OpenSpaceComarcal.Models.instancia);
            // 
            // comboBoxAlumnoBusqueda
            // 
            this.comboBoxAlumnoBusqueda.DataSource = this.bindingSourceAlumno;
            this.comboBoxAlumnoBusqueda.DisplayMember = "nombre";
            this.comboBoxAlumnoBusqueda.FormattingEnabled = true;
            this.comboBoxAlumnoBusqueda.Location = new System.Drawing.Point(102, 19);
            this.comboBoxAlumnoBusqueda.Name = "comboBoxAlumnoBusqueda";
            this.comboBoxAlumnoBusqueda.Size = new System.Drawing.Size(116, 21);
            this.comboBoxAlumnoBusqueda.TabIndex = 11;
            this.comboBoxAlumnoBusqueda.ValueMember = "id";
            this.comboBoxAlumnoBusqueda.TextChanged += new System.EventHandler(this.comboBoxAlumnoBusqueda_TextChanged);
            // 
            // bindingSourceAlumno
            // 
            this.bindingSourceAlumno.DataSource = typeof(OpenSpaceComarcal.Models.alumno);
            // 
            // bindingSourceInscipcion
            // 
            this.bindingSourceInscipcion.DataSource = typeof(OpenSpaceComarcal.Models.inscripcion);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(12, 28);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(75, 31);
            this.buttonActualizar.TabIndex = 0;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBoxCodFactura);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePickerExpedicion);
            this.groupBox1.Controls.Add(this.buttonLimpiar);
            this.groupBox1.Controls.Add(this.checkBoxApto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePickerInscripcion);
            this.groupBox1.Controls.Add(this.comboBoxInstancia);
            this.groupBox1.Controls.Add(this.comboBoxAlumno);
            this.groupBox1.Controls.Add(this.buttonModificarInscripcion);
            this.groupBox1.Controls.Add(this.buttonEliminarInscripcion);
            this.groupBox1.Controls.Add(this.buttonCrearInscripcion);
            this.groupBox1.Controls.Add(this.labelDNINIA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(8, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 130);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de la Inscripción";
            // 
            // textBoxCodFactura
            // 
            this.textBoxCodFactura.Location = new System.Drawing.Point(387, 97);
            this.textBoxCodFactura.Name = "textBoxCodFactura";
            this.textBoxCodFactura.Size = new System.Drawing.Size(139, 20);
            this.textBoxCodFactura.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(273, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cód. Factura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(273, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "F. Expedición";
            // 
            // dateTimePickerExpedicion
            // 
            this.dateTimePickerExpedicion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerExpedicion.Location = new System.Drawing.Point(387, 65);
            this.dateTimePickerExpedicion.Name = "dateTimePickerExpedicion";
            this.dateTimePickerExpedicion.Size = new System.Drawing.Size(139, 20);
            this.dateTimePickerExpedicion.TabIndex = 16;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpiar.Location = new System.Drawing.Point(573, 79);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(103, 38);
            this.buttonLimpiar.TabIndex = 23;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // checkBoxApto
            // 
            this.checkBoxApto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxApto.AutoSize = true;
            this.checkBoxApto.Location = new System.Drawing.Point(100, 103);
            this.checkBoxApto.Name = "checkBoxApto";
            this.checkBoxApto.Size = new System.Drawing.Size(15, 14);
            this.checkBoxApto.TabIndex = 18;
            this.checkBoxApto.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Apto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "F. Inscripción";
            // 
            // dateTimePickerInscripcion
            // 
            this.dateTimePickerInscripcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInscripcion.Location = new System.Drawing.Point(387, 34);
            this.dateTimePickerInscripcion.Name = "dateTimePickerInscripcion";
            this.dateTimePickerInscripcion.Size = new System.Drawing.Size(139, 20);
            this.dateTimePickerInscripcion.TabIndex = 12;
            // 
            // comboBoxInstancia
            // 
            this.comboBoxInstancia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxInstancia.DataSource = this.bindingSourceInstancia;
            this.comboBoxInstancia.DisplayMember = "id_curso";
            this.comboBoxInstancia.FormattingEnabled = true;
            this.comboBoxInstancia.Location = new System.Drawing.Point(100, 65);
            this.comboBoxInstancia.Name = "comboBoxInstancia";
            this.comboBoxInstancia.Size = new System.Drawing.Size(143, 21);
            this.comboBoxInstancia.TabIndex = 14;
            this.comboBoxInstancia.ValueMember = "id";
            this.comboBoxInstancia.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxInstancia_Format);
            this.comboBoxInstancia.TextChanged += new System.EventHandler(this.comboBoxInstancia_TextChanged);
            // 
            // comboBoxAlumno
            // 
            this.comboBoxAlumno.DataSource = this.bindingSourceAlumno;
            this.comboBoxAlumno.DisplayMember = "nombre";
            this.comboBoxAlumno.FormattingEnabled = true;
            this.comboBoxAlumno.Location = new System.Drawing.Point(100, 33);
            this.comboBoxAlumno.Name = "comboBoxAlumno";
            this.comboBoxAlumno.Size = new System.Drawing.Size(143, 21);
            this.comboBoxAlumno.TabIndex = 10;
            this.comboBoxAlumno.ValueMember = "id";
            this.comboBoxAlumno.TextChanged += new System.EventHandler(this.comboBoxAlumno_TextChanged);
            // 
            // buttonModificarInscripcion
            // 
            this.buttonModificarInscripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModificarInscripcion.Location = new System.Drawing.Point(696, 36);
            this.buttonModificarInscripcion.Name = "buttonModificarInscripcion";
            this.buttonModificarInscripcion.Size = new System.Drawing.Size(116, 37);
            this.buttonModificarInscripcion.TabIndex = 22;
            this.buttonModificarInscripcion.Text = "Modificar Inscipción";
            this.buttonModificarInscripcion.UseVisualStyleBackColor = true;
            this.buttonModificarInscripcion.Click += new System.EventHandler(this.buttonModificarInscripcion_Click);
            // 
            // buttonEliminarInscripcion
            // 
            this.buttonEliminarInscripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminarInscripcion.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonEliminarInscripcion.Location = new System.Drawing.Point(696, 79);
            this.buttonEliminarInscripcion.Name = "buttonEliminarInscripcion";
            this.buttonEliminarInscripcion.Size = new System.Drawing.Size(116, 37);
            this.buttonEliminarInscripcion.TabIndex = 24;
            this.buttonEliminarInscripcion.Text = "Eliminar Inscripción";
            this.buttonEliminarInscripcion.UseVisualStyleBackColor = true;
            this.buttonEliminarInscripcion.Click += new System.EventHandler(this.buttonEliminarInscripcion_Click);
            // 
            // buttonCrearInscripcion
            // 
            this.buttonCrearInscripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrearInscripcion.Location = new System.Drawing.Point(573, 36);
            this.buttonCrearInscripcion.Name = "buttonCrearInscripcion";
            this.buttonCrearInscripcion.Size = new System.Drawing.Size(103, 37);
            this.buttonCrearInscripcion.TabIndex = 21;
            this.buttonCrearInscripcion.Text = "Nueva Inscripción";
            this.buttonCrearInscripcion.UseVisualStyleBackColor = true;
            this.buttonCrearInscripcion.Click += new System.EventHandler(this.buttonCrearInscripcion_Click);
            // 
            // labelDNINIA
            // 
            this.labelDNINIA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDNINIA.AutoSize = true;
            this.labelDNINIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDNINIA.Location = new System.Drawing.Point(14, 34);
            this.labelDNINIA.Name = "labelDNINIA";
            this.labelDNINIA.Size = new System.Drawing.Size(58, 16);
            this.labelDNINIA.TabIndex = 9;
            this.labelDNINIA.Text = "Alumno";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Curso Prg.";
            // 
            // dataGridViewInscripcion
            // 
            this.dataGridViewInscripcion.AllowUserToAddRows = false;
            this.dataGridViewInscripcion.AllowUserToDeleteRows = false;
            this.dataGridViewInscripcion.AllowUserToOrderColumns = true;
            this.dataGridViewInscripcion.AllowUserToResizeRows = false;
            this.dataGridViewInscripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInscripcion.AutoGenerateColumns = false;
            this.dataGridViewInscripcion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInscripcion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idalumnoDataGridViewTextBoxColumn,
            this.idinstanciaDataGridViewTextBoxColumn,
            this.id_empresa,
            this.fechainscripcionDataGridViewTextBoxColumn,
            this.fechaexpedicionDataGridViewTextBoxColumn,
            this.aptoDataGridViewTextBoxColumn,
            this.codfacturaDataGridViewTextBoxColumn});
            this.dataGridViewInscripcion.DataSource = this.bindingSourceInscipcion;
            this.dataGridViewInscripcion.Location = new System.Drawing.Point(8, 148);
            this.dataGridViewInscripcion.MultiSelect = false;
            this.dataGridViewInscripcion.Name = "dataGridViewInscripcion";
            this.dataGridViewInscripcion.ReadOnly = true;
            this.dataGridViewInscripcion.RowHeadersVisible = false;
            this.dataGridViewInscripcion.RowHeadersWidth = 72;
            this.dataGridViewInscripcion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInscripcion.Size = new System.Drawing.Size(831, 267);
            this.dataGridViewInscripcion.TabIndex = 7;
            this.dataGridViewInscripcion.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewInscripcion_CellFormatting);
            this.dataGridViewInscripcion.SelectionChanged += new System.EventHandler(this.dataGridViewInscripcion_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idalumnoDataGridViewTextBoxColumn
            // 
            this.idalumnoDataGridViewTextBoxColumn.DataPropertyName = "id_alumno";
            this.idalumnoDataGridViewTextBoxColumn.HeaderText = "Alumno";
            this.idalumnoDataGridViewTextBoxColumn.Name = "idalumnoDataGridViewTextBoxColumn";
            this.idalumnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idinstanciaDataGridViewTextBoxColumn
            // 
            this.idinstanciaDataGridViewTextBoxColumn.DataPropertyName = "id_instancia";
            this.idinstanciaDataGridViewTextBoxColumn.HeaderText = "Curso Prg.";
            this.idinstanciaDataGridViewTextBoxColumn.Name = "idinstanciaDataGridViewTextBoxColumn";
            this.idinstanciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // id_empresa
            // 
            this.id_empresa.DataPropertyName = "id_empresa";
            this.id_empresa.HeaderText = "Empresa";
            this.id_empresa.Name = "id_empresa";
            this.id_empresa.ReadOnly = true;
            // 
            // fechainscripcionDataGridViewTextBoxColumn
            // 
            this.fechainscripcionDataGridViewTextBoxColumn.DataPropertyName = "fecha_inscripcion";
            this.fechainscripcionDataGridViewTextBoxColumn.HeaderText = "F. Inscripción";
            this.fechainscripcionDataGridViewTextBoxColumn.Name = "fechainscripcionDataGridViewTextBoxColumn";
            this.fechainscripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaexpedicionDataGridViewTextBoxColumn
            // 
            this.fechaexpedicionDataGridViewTextBoxColumn.DataPropertyName = "fecha_expedicion";
            this.fechaexpedicionDataGridViewTextBoxColumn.HeaderText = "F. Expedición";
            this.fechaexpedicionDataGridViewTextBoxColumn.Name = "fechaexpedicionDataGridViewTextBoxColumn";
            this.fechaexpedicionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aptoDataGridViewTextBoxColumn
            // 
            this.aptoDataGridViewTextBoxColumn.DataPropertyName = "apto";
            this.aptoDataGridViewTextBoxColumn.HeaderText = "Apto";
            this.aptoDataGridViewTextBoxColumn.Name = "aptoDataGridViewTextBoxColumn";
            this.aptoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codfacturaDataGridViewTextBoxColumn
            // 
            this.codfacturaDataGridViewTextBoxColumn.DataPropertyName = "cod_factura";
            this.codfacturaDataGridViewTextBoxColumn.HeaderText = "Cód. Factura";
            this.codfacturaDataGridViewTextBoxColumn.Name = "codfacturaDataGridViewTextBoxColumn";
            this.codfacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // labelInscripcion
            // 
            this.labelInscripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelInscripcion.AutoSize = true;
            this.labelInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInscripcion.Location = new System.Drawing.Point(346, 28);
            this.labelInscripcion.Name = "labelInscripcion";
            this.labelInscripcion.Size = new System.Drawing.Size(156, 31);
            this.labelInscripcion.TabIndex = 20;
            this.labelInscripcion.Text = "Inscripción";
            // 
            // buttonGenerarDiplomas
            // 
            this.buttonGenerarDiplomas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerarDiplomas.Location = new System.Drawing.Point(704, 28);
            this.buttonGenerarDiplomas.Name = "buttonGenerarDiplomas";
            this.buttonGenerarDiplomas.Size = new System.Drawing.Size(113, 31);
            this.buttonGenerarDiplomas.TabIndex = 25;
            this.buttonGenerarDiplomas.Text = "Diplomas";
            this.buttonGenerarDiplomas.UseVisualStyleBackColor = true;
            this.buttonGenerarDiplomas.Click += new System.EventHandler(this.buttonGenerarDiplomas_Click);
            // 
            // skinEngineinscripcion
            // 
            this.skinEngineinscripcion.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngineinscripcion.SkinFile = "";
            // 
            // toolStripInscripcion
            // 
            this.toolStripInscripcion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStripInscripcion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonArchivo});
            this.toolStripInscripcion.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripInscripcion.Location = new System.Drawing.Point(0, 0);
            this.toolStripInscripcion.Name = "toolStripInscripcion";
            this.toolStripInscripcion.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripInscripcion.Size = new System.Drawing.Size(848, 25);
            this.toolStripInscripcion.TabIndex = 26;
            this.toolStripInscripcion.Text = "toolStripInscripcion";
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
            // progressBarArchivo
            // 
            this.progressBarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarArchivo.Location = new System.Drawing.Point(151, 65);
            this.progressBarArchivo.Name = "progressBarArchivo";
            this.progressBarArchivo.Size = new System.Drawing.Size(547, 10);
            this.progressBarArchivo.TabIndex = 33;
            // 
            // FormInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 567);
            this.Controls.Add(this.progressBarArchivo);
            this.Controls.Add(this.toolStripInscripcion);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonGenerarDiplomas);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewInscripcion);
            this.Controls.Add(this.labelInscripcion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INSCRIPCIÓNES - OPEN SPACE COMARCAL";
            this.Load += new System.EventHandler(this.Inscripcion_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInscipcion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscripcion)).EndInit();
            this.toolStripInscripcion.ResumeLayout(false);
            this.toolStripInscripcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBuscador;
        private System.Windows.Forms.Button buttonBuscarInscipcion;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonModificarInscripcion;
        private System.Windows.Forms.Button buttonEliminarInscripcion;
        private System.Windows.Forms.Button buttonCrearInscripcion;
        private System.Windows.Forms.Label labelDNINIA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewInscripcion;
        private System.Windows.Forms.Label labelInscripcion;
        private System.Windows.Forms.ComboBox comboBoxInstancia;
        private System.Windows.Forms.ComboBox comboBoxAlumno;
        private System.Windows.Forms.CheckBox checkBoxApto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerInscripcion;
        private System.Windows.Forms.Button buttonGenerarDiplomas;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpedicion;
        private System.Windows.Forms.BindingSource bindingSourceInscipcion;
        private System.Windows.Forms.TextBox textBoxCodFactura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource bindingSourceAlumno;
        private System.Windows.Forms.BindingSource bindingSourceInstancia;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBoxInstanciaBusqueda;
        private System.Windows.Forms.ComboBox comboBoxAlumnoBusqueda;
        private System.Windows.Forms.Button buttonBusquedaAvanzada;
        private System.Windows.Forms.CheckBox checkBoxAptoBusqueda;
        private System.Windows.Forms.Label label1;
        private Sunisoft.IrisSkin.SkinEngine skinEngineinscripcion;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private System.Windows.Forms.BindingSource bindingSourceEmpresa;
        private System.Windows.Forms.ToolStrip toolStripInscripcion;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonArchivo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExportar;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuImportar;
        private System.Windows.Forms.ProgressBar progressBarArchivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinstanciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechainscripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaexpedicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codfacturaDataGridViewTextBoxColumn;
    }
}