namespace OpenSpaceComarcal
{
    partial class FormControlAsistencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSeleccionarRutaPlantilla = new System.Windows.Forms.Button();
            this.textBoxRutaPlantilla = new System.Windows.Forms.TextBox();
            this.comboBoxInstancia = new System.Windows.Forms.ComboBox();
            this.bindingSourceInstancia = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSeleccionarRuta = new System.Windows.Forms.Button();
            this.textBoxRutaDestino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGenerar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstancia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 47);
            this.label1.TabIndex = 28;
            this.label1.Text = "Control de Asistencia";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonSeleccionarRutaPlantilla);
            this.groupBox1.Controls.Add(this.textBoxRutaPlantilla);
            this.groupBox1.Controls.Add(this.comboBoxInstancia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonSeleccionarRuta);
            this.groupBox1.Controls.Add(this.textBoxRutaDestino);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(693, 220);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Ruta plantilla:";
            // 
            // buttonSeleccionarRutaPlantilla
            // 
            this.buttonSeleccionarRutaPlantilla.Location = new System.Drawing.Point(626, 102);
            this.buttonSeleccionarRutaPlantilla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSeleccionarRutaPlantilla.Name = "buttonSeleccionarRutaPlantilla";
            this.buttonSeleccionarRutaPlantilla.Size = new System.Drawing.Size(39, 31);
            this.buttonSeleccionarRutaPlantilla.TabIndex = 36;
            this.buttonSeleccionarRutaPlantilla.Text = "...";
            this.buttonSeleccionarRutaPlantilla.UseVisualStyleBackColor = true;
            this.buttonSeleccionarRutaPlantilla.Click += new System.EventHandler(this.buttonSeleccionarRutaPlantilla_Click);
            // 
            // textBoxRutaPlantilla
            // 
            this.textBoxRutaPlantilla.Location = new System.Drawing.Point(136, 102);
            this.textBoxRutaPlantilla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRutaPlantilla.Name = "textBoxRutaPlantilla";
            this.textBoxRutaPlantilla.ReadOnly = true;
            this.textBoxRutaPlantilla.Size = new System.Drawing.Size(478, 26);
            this.textBoxRutaPlantilla.TabIndex = 35;
            // 
            // comboBoxInstancia
            // 
            this.comboBoxInstancia.DataSource = this.bindingSourceInstancia;
            this.comboBoxInstancia.DisplayMember = "id";
            this.comboBoxInstancia.FormattingEnabled = true;
            this.comboBoxInstancia.Location = new System.Drawing.Point(411, 163);
            this.comboBoxInstancia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxInstancia.Name = "comboBoxInstancia";
            this.comboBoxInstancia.Size = new System.Drawing.Size(202, 28);
            this.comboBoxInstancia.TabIndex = 34;
            this.comboBoxInstancia.ValueMember = "id";
            this.comboBoxInstancia.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxInstancia_Format);
            // 
            // bindingSourceInstancia
            // 
            this.bindingSourceInstancia.DataSource = typeof(OpenSpaceComarcal.Models.instancia);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Curso Prg. :";
            // 
            // buttonSeleccionarRuta
            // 
            this.buttonSeleccionarRuta.Location = new System.Drawing.Point(626, 42);
            this.buttonSeleccionarRuta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSeleccionarRuta.Name = "buttonSeleccionarRuta";
            this.buttonSeleccionarRuta.Size = new System.Drawing.Size(39, 31);
            this.buttonSeleccionarRuta.TabIndex = 29;
            this.buttonSeleccionarRuta.Text = "...";
            this.buttonSeleccionarRuta.UseVisualStyleBackColor = true;
            this.buttonSeleccionarRuta.Click += new System.EventHandler(this.buttonSeleccionarRuta_Click);
            // 
            // textBoxRutaDestino
            // 
            this.textBoxRutaDestino.Location = new System.Drawing.Point(136, 42);
            this.textBoxRutaDestino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRutaDestino.Name = "textBoxRutaDestino";
            this.textBoxRutaDestino.ReadOnly = true;
            this.textBoxRutaDestino.Size = new System.Drawing.Size(478, 26);
            this.textBoxRutaDestino.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ruta destino:";
            // 
            // buttonGenerar
            // 
            this.buttonGenerar.Location = new System.Drawing.Point(279, 309);
            this.buttonGenerar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGenerar.Name = "buttonGenerar";
            this.buttonGenerar.Size = new System.Drawing.Size(170, 65);
            this.buttonGenerar.TabIndex = 30;
            this.buttonGenerar.Text = "Generar";
            this.buttonGenerar.UseVisualStyleBackColor = true;
            this.buttonGenerar.Click += new System.EventHandler(this.buttonGenerar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-4, -6);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(734, 15);
            this.progressBar1.TabIndex = 31;
            // 
            // FormControlAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 392);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonGenerar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormControlAsistencia";
            this.Text = "FormControlAsistencia";
            this.Load += new System.EventHandler(this.FormControlAsistencia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstancia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSeleccionarRuta;
        private System.Windows.Forms.TextBox textBoxRutaDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGenerar;
        private System.Windows.Forms.ComboBox comboBoxInstancia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bindingSourceInstancia;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSeleccionarRutaPlantilla;
        private System.Windows.Forms.TextBox textBoxRutaPlantilla;
    }
}