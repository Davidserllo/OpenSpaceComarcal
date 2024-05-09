namespace OpenSpaceComarcal
{
    partial class FormInstancia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstancia));
            this.bindingSourceInstancia = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelCualquierCampo = new System.Windows.Forms.Label();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.buttonBuscarCurso = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.groupBoxInfoCurso = new System.Windows.Forms.GroupBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.dateTimePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.buttonSeleccionarDiploma = new System.Windows.Forms.Button();
            this.comboBoxCursosSiglas = new System.Windows.Forms.ComboBox();
            this.bindingSourceCursos = new System.Windows.Forms.BindingSource(this.components);
            this.buttonModificarPrograma = new System.Windows.Forms.Button();
            this.buttonEliminarPrograma = new System.Windows.Forms.Button();
            this.buttonCrearPrograma = new System.Windows.Forms.Button();
            this.labelSiglasCurso = new System.Windows.Forms.Label();
            this.labelDiploma = new System.Windows.Forms.Label();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.dataGridViewCurso = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechafinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diplomaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCursosProgramados = new System.Windows.Forms.Label();
            this.skinEngineCursosProgramados = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstancia)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBoxInfoCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceInstancia
            // 
            this.bindingSourceInstancia.DataSource = typeof(OpenSpaceComarcal.Models.instancia);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.labelCualquierCampo);
            this.groupBox2.Controls.Add(this.textBoxBuscador);
            this.groupBox2.Controls.Add(this.buttonBuscarCurso);
            this.groupBox2.Location = new System.Drawing.Point(9, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 52);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscador";
            // 
            // labelCualquierCampo
            // 
            this.labelCualquierCampo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCualquierCampo.AutoSize = true;
            this.labelCualquierCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCualquierCampo.Location = new System.Drawing.Point(14, 21);
            this.labelCualquierCampo.Name = "labelCualquierCampo";
            this.labelCualquierCampo.Size = new System.Drawing.Size(124, 16);
            this.labelCualquierCampo.TabIndex = 3;
            this.labelCualquierCampo.Text = "Cualquier campo";
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscador.Location = new System.Drawing.Point(155, 19);
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(472, 20);
            this.textBoxBuscador.TabIndex = 4;
            // 
            // buttonBuscarCurso
            // 
            this.buttonBuscarCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscarCurso.Location = new System.Drawing.Point(650, 12);
            this.buttonBuscarCurso.Name = "buttonBuscarCurso";
            this.buttonBuscarCurso.Size = new System.Drawing.Size(103, 34);
            this.buttonBuscarCurso.TabIndex = 5;
            this.buttonBuscarCurso.Text = "Buscar Curso";
            this.buttonBuscarCurso.UseVisualStyleBackColor = true;
            this.buttonBuscarCurso.Click += new System.EventHandler(this.buttonBuscarCurso_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(9, 7);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(75, 31);
            this.buttonActualizar.TabIndex = 0;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // groupBoxInfoCurso
            // 
            this.groupBoxInfoCurso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInfoCurso.Controls.Add(this.buttonLimpiar);
            this.groupBoxInfoCurso.Controls.Add(this.dateTimePickerFechaFin);
            this.groupBoxInfoCurso.Controls.Add(this.dateTimePickerFechaInicio);
            this.groupBoxInfoCurso.Controls.Add(this.labelFechaInicio);
            this.groupBoxInfoCurso.Controls.Add(this.buttonSeleccionarDiploma);
            this.groupBoxInfoCurso.Controls.Add(this.comboBoxCursosSiglas);
            this.groupBoxInfoCurso.Controls.Add(this.buttonModificarPrograma);
            this.groupBoxInfoCurso.Controls.Add(this.buttonEliminarPrograma);
            this.groupBoxInfoCurso.Controls.Add(this.buttonCrearPrograma);
            this.groupBoxInfoCurso.Controls.Add(this.labelSiglasCurso);
            this.groupBoxInfoCurso.Controls.Add(this.labelDiploma);
            this.groupBoxInfoCurso.Controls.Add(this.labelFechaFin);
            this.groupBoxInfoCurso.Location = new System.Drawing.Point(9, 366);
            this.groupBoxInfoCurso.Name = "groupBoxInfoCurso";
            this.groupBoxInfoCurso.Size = new System.Drawing.Size(784, 108);
            this.groupBoxInfoCurso.TabIndex = 7;
            this.groupBoxInfoCurso.TabStop = false;
            this.groupBoxInfoCurso.Text = "Informacion del Curso";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpiar.Location = new System.Drawing.Point(524, 60);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(103, 34);
            this.buttonLimpiar.TabIndex = 18;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // dateTimePickerFechaFin
            // 
            this.dateTimePickerFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaFin.Location = new System.Drawing.Point(397, 69);
            this.dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            this.dateTimePickerFechaFin.Size = new System.Drawing.Size(112, 20);
            this.dateTimePickerFechaFin.TabIndex = 15;
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(397, 26);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(112, 20);
            this.dateTimePickerFechaInicio.TabIndex = 11;
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaInicio.Location = new System.Drawing.Point(288, 30);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(91, 16);
            this.labelFechaInicio.TabIndex = 10;
            this.labelFechaInicio.Text = "Fecha Inicio";
            // 
            // buttonSeleccionarDiploma
            // 
            this.buttonSeleccionarDiploma.Location = new System.Drawing.Point(125, 67);
            this.buttonSeleccionarDiploma.Name = "buttonSeleccionarDiploma";
            this.buttonSeleccionarDiploma.Size = new System.Drawing.Size(139, 27);
            this.buttonSeleccionarDiploma.TabIndex = 13;
            this.buttonSeleccionarDiploma.Text = "Seleccionar Diploma";
            this.buttonSeleccionarDiploma.UseVisualStyleBackColor = true;
            this.buttonSeleccionarDiploma.Click += new System.EventHandler(this.buttonSeleccionarDiploma_Click);
            // 
            // comboBoxCursosSiglas
            // 
            this.comboBoxCursosSiglas.DataSource = this.bindingSourceCursos;
            this.comboBoxCursosSiglas.DisplayMember = "siglas";
            this.comboBoxCursosSiglas.FormattingEnabled = true;
            this.comboBoxCursosSiglas.Location = new System.Drawing.Point(125, 29);
            this.comboBoxCursosSiglas.Name = "comboBoxCursosSiglas";
            this.comboBoxCursosSiglas.Size = new System.Drawing.Size(139, 21);
            this.comboBoxCursosSiglas.TabIndex = 9;
            this.comboBoxCursosSiglas.ValueMember = "id";
            // 
            // bindingSourceCursos
            // 
            this.bindingSourceCursos.DataSource = typeof(OpenSpaceComarcal.Models.curso);
            // 
            // buttonModificarPrograma
            // 
            this.buttonModificarPrograma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModificarPrograma.Location = new System.Drawing.Point(647, 21);
            this.buttonModificarPrograma.Name = "buttonModificarPrograma";
            this.buttonModificarPrograma.Size = new System.Drawing.Size(106, 34);
            this.buttonModificarPrograma.TabIndex = 17;
            this.buttonModificarPrograma.Text = "Modificar Programa";
            this.buttonModificarPrograma.UseVisualStyleBackColor = true;
            this.buttonModificarPrograma.Click += new System.EventHandler(this.buttonModificarPrograma_Click);
            // 
            // buttonEliminarPrograma
            // 
            this.buttonEliminarPrograma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminarPrograma.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonEliminarPrograma.Location = new System.Drawing.Point(647, 60);
            this.buttonEliminarPrograma.Name = "buttonEliminarPrograma";
            this.buttonEliminarPrograma.Size = new System.Drawing.Size(106, 34);
            this.buttonEliminarPrograma.TabIndex = 19;
            this.buttonEliminarPrograma.Text = "Eliminar Programa";
            this.buttonEliminarPrograma.UseVisualStyleBackColor = true;
            this.buttonEliminarPrograma.Click += new System.EventHandler(this.buttonEliminarPrograma_Click);
            // 
            // buttonCrearPrograma
            // 
            this.buttonCrearPrograma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrearPrograma.Location = new System.Drawing.Point(524, 21);
            this.buttonCrearPrograma.Name = "buttonCrearPrograma";
            this.buttonCrearPrograma.Size = new System.Drawing.Size(103, 34);
            this.buttonCrearPrograma.TabIndex = 16;
            this.buttonCrearPrograma.Text = "Nuevo Programa";
            this.buttonCrearPrograma.UseVisualStyleBackColor = true;
            this.buttonCrearPrograma.Click += new System.EventHandler(this.buttonCrearPrograma_Click);
            // 
            // labelSiglasCurso
            // 
            this.labelSiglasCurso.AutoSize = true;
            this.labelSiglasCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSiglasCurso.Location = new System.Drawing.Point(14, 30);
            this.labelSiglasCurso.Name = "labelSiglasCurso";
            this.labelSiglasCurso.Size = new System.Drawing.Size(105, 16);
            this.labelSiglasCurso.TabIndex = 8;
            this.labelSiglasCurso.Text = "Curso (Siglas)";
            // 
            // labelDiploma
            // 
            this.labelDiploma.AutoSize = true;
            this.labelDiploma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiploma.Location = new System.Drawing.Point(14, 72);
            this.labelDiploma.Name = "labelDiploma";
            this.labelDiploma.Size = new System.Drawing.Size(65, 16);
            this.labelDiploma.TabIndex = 12;
            this.labelDiploma.Text = "Diploma";
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaFin.Location = new System.Drawing.Point(288, 72);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(75, 16);
            this.labelFechaFin.TabIndex = 14;
            this.labelFechaFin.Text = "Fecha Fin";
            // 
            // dataGridViewCurso
            // 
            this.dataGridViewCurso.AllowUserToAddRows = false;
            this.dataGridViewCurso.AllowUserToDeleteRows = false;
            this.dataGridViewCurso.AllowUserToOrderColumns = true;
            this.dataGridViewCurso.AllowUserToResizeRows = false;
            this.dataGridViewCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCurso.AutoGenerateColumns = false;
            this.dataGridViewCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idcursoDataGridViewTextBoxColumn,
            this.fechainicioDataGridViewTextBoxColumn,
            this.fechafinDataGridViewTextBoxColumn,
            this.diplomaDataGridViewTextBoxColumn,
            this.cursoDataGridViewTextBoxColumn,
            this.inscripcionDataGridViewTextBoxColumn});
            this.dataGridViewCurso.DataSource = this.bindingSourceInstancia;
            this.dataGridViewCurso.Location = new System.Drawing.Point(9, 102);
            this.dataGridViewCurso.MultiSelect = false;
            this.dataGridViewCurso.Name = "dataGridViewCurso";
            this.dataGridViewCurso.ReadOnly = true;
            this.dataGridViewCurso.RowHeadersVisible = false;
            this.dataGridViewCurso.RowHeadersWidth = 72;
            this.dataGridViewCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCurso.Size = new System.Drawing.Size(784, 258);
            this.dataGridViewCurso.TabIndex = 6;
            this.dataGridViewCurso.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewCurso_CellFormatting);
            this.dataGridViewCurso.SelectionChanged += new System.EventHandler(this.dataGridViewCurso_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcursoDataGridViewTextBoxColumn
            // 
            this.idcursoDataGridViewTextBoxColumn.DataPropertyName = "id_curso";
            this.idcursoDataGridViewTextBoxColumn.HeaderText = "Curso";
            this.idcursoDataGridViewTextBoxColumn.Name = "idcursoDataGridViewTextBoxColumn";
            this.idcursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechainicioDataGridViewTextBoxColumn
            // 
            this.fechainicioDataGridViewTextBoxColumn.DataPropertyName = "fecha_inicio";
            this.fechainicioDataGridViewTextBoxColumn.HeaderText = "Fecha Inicio";
            this.fechainicioDataGridViewTextBoxColumn.Name = "fechainicioDataGridViewTextBoxColumn";
            this.fechainicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechafinDataGridViewTextBoxColumn
            // 
            this.fechafinDataGridViewTextBoxColumn.DataPropertyName = "fecha_fin";
            this.fechafinDataGridViewTextBoxColumn.HeaderText = "Fecha Fin";
            this.fechafinDataGridViewTextBoxColumn.Name = "fechafinDataGridViewTextBoxColumn";
            this.fechafinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diplomaDataGridViewTextBoxColumn
            // 
            this.diplomaDataGridViewTextBoxColumn.DataPropertyName = "diploma";
            this.diplomaDataGridViewTextBoxColumn.HeaderText = "Diploma";
            this.diplomaDataGridViewTextBoxColumn.Name = "diplomaDataGridViewTextBoxColumn";
            this.diplomaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cursoDataGridViewTextBoxColumn
            // 
            this.cursoDataGridViewTextBoxColumn.DataPropertyName = "curso";
            this.cursoDataGridViewTextBoxColumn.HeaderText = "curso";
            this.cursoDataGridViewTextBoxColumn.Name = "cursoDataGridViewTextBoxColumn";
            this.cursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cursoDataGridViewTextBoxColumn.Visible = false;
            // 
            // inscripcionDataGridViewTextBoxColumn
            // 
            this.inscripcionDataGridViewTextBoxColumn.DataPropertyName = "inscripcion";
            this.inscripcionDataGridViewTextBoxColumn.HeaderText = "inscripcion";
            this.inscripcionDataGridViewTextBoxColumn.Name = "inscripcionDataGridViewTextBoxColumn";
            this.inscripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.inscripcionDataGridViewTextBoxColumn.Visible = false;
            // 
            // labelCursosProgramados
            // 
            this.labelCursosProgramados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCursosProgramados.AutoSize = true;
            this.labelCursosProgramados.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCursosProgramados.Location = new System.Drawing.Point(257, 7);
            this.labelCursosProgramados.Name = "labelCursosProgramados";
            this.labelCursosProgramados.Size = new System.Drawing.Size(288, 31);
            this.labelCursosProgramados.TabIndex = 1;
            this.labelCursosProgramados.Text = "Cursos Programados";
            // 
            // skinEngineCursosProgramados
            // 
            this.skinEngineCursosProgramados.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngineCursosProgramados.SkinFile = "";
            // 
            // FormInstancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 486);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.groupBoxInfoCurso);
            this.Controls.Add(this.dataGridViewCurso);
            this.Controls.Add(this.labelCursosProgramados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormInstancia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CURSOS PROGRAMADOS - OPEN SPACE COMARCAL";
            this.Load += new System.EventHandler(this.Instancia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstancia)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxInfoCurso.ResumeLayout(false);
            this.groupBoxInfoCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSourceInstancia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelCualquierCampo;
        private System.Windows.Forms.TextBox textBoxBuscador;
        private System.Windows.Forms.Button buttonBuscarCurso;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.GroupBox groupBoxInfoCurso;
        private System.Windows.Forms.Button buttonModificarPrograma;
        private System.Windows.Forms.Button buttonEliminarPrograma;
        private System.Windows.Forms.Button buttonCrearPrograma;
        private System.Windows.Forms.Label labelSiglasCurso;
        private System.Windows.Forms.Label labelFechaFin;
        private System.Windows.Forms.DataGridView dataGridViewCurso;
        private System.Windows.Forms.Label labelCursosProgramados;
        private System.Windows.Forms.ComboBox comboBoxCursosSiglas;
        private System.Windows.Forms.Button buttonSeleccionarDiploma;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelDiploma;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diplomaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inscripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceCursos;
        private System.Windows.Forms.Button buttonLimpiar;
        private Sunisoft.IrisSkin.SkinEngine skinEngineCursosProgramados;
    }
}