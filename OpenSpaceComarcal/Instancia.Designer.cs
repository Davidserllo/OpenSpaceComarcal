namespace OpenSpaceComarcal
{
    partial class Instancia
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
            this.bindingSourceInstancia = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.buttonBuscarCurso = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.dateTimePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSeleccionarDiploma = new System.Windows.Forms.Button();
            this.comboBoxCursosSiglas = new System.Windows.Forms.ComboBox();
            this.bindingSourceCursos = new System.Windows.Forms.BindingSource(this.components);
            this.buttonModificarPrograma = new System.Windows.Forms.Button();
            this.buttonEliminarPrograma = new System.Windows.Forms.Button();
            this.buttonCrearPrograma = new System.Windows.Forms.Button();
            this.labelDNINIA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewCurso = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechafinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diplomaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstancia)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxBuscador);
            this.groupBox2.Controls.Add(this.buttonBuscarCurso);
            this.groupBox2.Location = new System.Drawing.Point(9, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 52);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cualquier campo";
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.Location = new System.Drawing.Point(155, 19);
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(472, 20);
            this.textBoxBuscador.TabIndex = 16;
            // 
            // buttonBuscarCurso
            // 
            this.buttonBuscarCurso.Location = new System.Drawing.Point(650, 12);
            this.buttonBuscarCurso.Name = "buttonBuscarCurso";
            this.buttonBuscarCurso.Size = new System.Drawing.Size(103, 34);
            this.buttonBuscarCurso.TabIndex = 0;
            this.buttonBuscarCurso.Text = "Buscar Curso";
            this.buttonBuscarCurso.UseVisualStyleBackColor = true;
            this.buttonBuscarCurso.Click += new System.EventHandler(this.buttonBuscarCurso_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(9, 7);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(75, 31);
            this.buttonActualizar.TabIndex = 23;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLimpiar);
            this.groupBox1.Controls.Add(this.dateTimePickerFechaFin);
            this.groupBox1.Controls.Add(this.dateTimePickerFechaInicio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonSeleccionarDiploma);
            this.groupBox1.Controls.Add(this.comboBoxCursosSiglas);
            this.groupBox1.Controls.Add(this.buttonModificarPrograma);
            this.groupBox1.Controls.Add(this.buttonEliminarPrograma);
            this.groupBox1.Controls.Add(this.buttonCrearPrograma);
            this.groupBox1.Controls.Add(this.labelDNINIA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 108);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del Curso";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(524, 60);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(103, 34);
            this.buttonLimpiar.TabIndex = 21;
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
            this.dateTimePickerFechaFin.TabIndex = 20;
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(397, 26);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(112, 20);
            this.dateTimePickerFechaInicio.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Fecha Inicio";
            // 
            // buttonSeleccionarDiploma
            // 
            this.buttonSeleccionarDiploma.Location = new System.Drawing.Point(125, 67);
            this.buttonSeleccionarDiploma.Name = "buttonSeleccionarDiploma";
            this.buttonSeleccionarDiploma.Size = new System.Drawing.Size(139, 27);
            this.buttonSeleccionarDiploma.TabIndex = 17;
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
            this.comboBoxCursosSiglas.TabIndex = 16;
            this.comboBoxCursosSiglas.ValueMember = "codigo";
            // 
            // bindingSourceCursos
            // 
            this.bindingSourceCursos.DataSource = typeof(OpenSpaceComarcal.Models.curso);
            // 
            // buttonModificarPrograma
            // 
            this.buttonModificarPrograma.Location = new System.Drawing.Point(647, 21);
            this.buttonModificarPrograma.Name = "buttonModificarPrograma";
            this.buttonModificarPrograma.Size = new System.Drawing.Size(106, 34);
            this.buttonModificarPrograma.TabIndex = 0;
            this.buttonModificarPrograma.Text = "Modificar Programa";
            this.buttonModificarPrograma.UseVisualStyleBackColor = true;
            this.buttonModificarPrograma.Click += new System.EventHandler(this.buttonModificarPrograma_Click);
            // 
            // buttonEliminarPrograma
            // 
            this.buttonEliminarPrograma.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonEliminarPrograma.Location = new System.Drawing.Point(647, 60);
            this.buttonEliminarPrograma.Name = "buttonEliminarPrograma";
            this.buttonEliminarPrograma.Size = new System.Drawing.Size(106, 34);
            this.buttonEliminarPrograma.TabIndex = 4;
            this.buttonEliminarPrograma.Text = "Eliminar Programa";
            this.buttonEliminarPrograma.UseVisualStyleBackColor = true;
            this.buttonEliminarPrograma.Click += new System.EventHandler(this.buttonEliminarPrograma_Click);
            // 
            // buttonCrearPrograma
            // 
            this.buttonCrearPrograma.Location = new System.Drawing.Point(524, 21);
            this.buttonCrearPrograma.Name = "buttonCrearPrograma";
            this.buttonCrearPrograma.Size = new System.Drawing.Size(103, 34);
            this.buttonCrearPrograma.TabIndex = 15;
            this.buttonCrearPrograma.Text = "Nuevo Programa";
            this.buttonCrearPrograma.UseVisualStyleBackColor = true;
            this.buttonCrearPrograma.Click += new System.EventHandler(this.buttonCrearPrograma_Click);
            // 
            // labelDNINIA
            // 
            this.labelDNINIA.AutoSize = true;
            this.labelDNINIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDNINIA.Location = new System.Drawing.Point(14, 30);
            this.labelDNINIA.Name = "labelDNINIA";
            this.labelDNINIA.Size = new System.Drawing.Size(105, 16);
            this.labelDNINIA.TabIndex = 5;
            this.labelDNINIA.Text = "Curso (Siglas)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Diploma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha Fin";
            // 
            // dataGridViewCurso
            // 
            this.dataGridViewCurso.AllowUserToAddRows = false;
            this.dataGridViewCurso.AllowUserToDeleteRows = false;
            this.dataGridViewCurso.AllowUserToOrderColumns = true;
            this.dataGridViewCurso.AllowUserToResizeRows = false;
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
            this.dataGridViewCurso.TabIndex = 21;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cursos Programados";
            // 
            // Instancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 486);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewCurso);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Instancia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CURSOS PROGRAMADOS - OPEN SPACE COMARCAL";
            this.Load += new System.EventHandler(this.Instancia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstancia)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSourceInstancia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBuscador;
        private System.Windows.Forms.Button buttonBuscarCurso;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonModificarPrograma;
        private System.Windows.Forms.Button buttonEliminarPrograma;
        private System.Windows.Forms.Button buttonCrearPrograma;
        private System.Windows.Forms.Label labelDNINIA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCursosSiglas;
        private System.Windows.Forms.Button buttonSeleccionarDiploma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
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
    }
}