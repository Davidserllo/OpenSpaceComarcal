namespace OpenSpaceComarcal
{
    partial class FormRutaDiploma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRutaDiploma));
            this.buttonGenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNumeroDiplomas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxPDF = new System.Windows.Forms.CheckBox();
            this.buttonSeleccionarRuta = new System.Windows.Forms.Button();
            this.textBoxRutaDestino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.skinEngineDiploma = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGenerar
            // 
            this.buttonGenerar.Location = new System.Drawing.Point(187, 171);
            this.buttonGenerar.Name = "buttonGenerar";
            this.buttonGenerar.Size = new System.Drawing.Size(113, 42);
            this.buttonGenerar.TabIndex = 26;
            this.buttonGenerar.Text = "Generar";
            this.buttonGenerar.UseVisualStyleBackColor = true;
            this.buttonGenerar.Click += new System.EventHandler(this.buttonGenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "Generador de Diplomas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNumeroDiplomas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBoxPDF);
            this.groupBox1.Controls.Add(this.buttonSeleccionarRuta);
            this.groupBox1.Controls.Add(this.textBoxRutaDestino);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 108);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // labelNumeroDiplomas
            // 
            this.labelNumeroDiplomas.AutoSize = true;
            this.labelNumeroDiplomas.Location = new System.Drawing.Point(171, 69);
            this.labelNumeroDiplomas.Name = "labelNumeroDiplomas";
            this.labelNumeroDiplomas.Size = new System.Drawing.Size(13, 13);
            this.labelNumeroDiplomas.TabIndex = 32;
            this.labelNumeroDiplomas.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Número de diplomas a generar:";
            // 
            // checkBoxPDF
            // 
            this.checkBoxPDF.AutoSize = true;
            this.checkBoxPDF.Location = new System.Drawing.Point(323, 68);
            this.checkBoxPDF.Name = "checkBoxPDF";
            this.checkBoxPDF.Size = new System.Drawing.Size(88, 17);
            this.checkBoxPDF.TabIndex = 30;
            this.checkBoxPDF.Text = "Generar PDF";
            this.checkBoxPDF.UseVisualStyleBackColor = true;
            // 
            // buttonSeleccionarRuta
            // 
            this.buttonSeleccionarRuta.Location = new System.Drawing.Point(422, 27);
            this.buttonSeleccionarRuta.Name = "buttonSeleccionarRuta";
            this.buttonSeleccionarRuta.Size = new System.Drawing.Size(26, 20);
            this.buttonSeleccionarRuta.TabIndex = 29;
            this.buttonSeleccionarRuta.Text = "...";
            this.buttonSeleccionarRuta.UseVisualStyleBackColor = true;
            this.buttonSeleccionarRuta.Click += new System.EventHandler(this.buttonSeleccionarRuta_Click);
            // 
            // textBoxRutaDestino
            // 
            this.textBoxRutaDestino.Location = new System.Drawing.Point(91, 27);
            this.textBoxRutaDestino.Name = "textBoxRutaDestino";
            this.textBoxRutaDestino.ReadOnly = true;
            this.textBoxRutaDestino.Size = new System.Drawing.Size(320, 20);
            this.textBoxRutaDestino.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ruta destino:";
            // 
            // skinEngineDiploma
            // 
            this.skinEngineDiploma.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngineDiploma.SkinFile = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-3, -4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(490, 10);
            this.progressBar1.TabIndex = 29;
            // 
            // FormRutaDiploma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 224);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGenerar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRutaDiploma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DIPLOMA - OPEN SPACE COMARCAL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxRutaDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSeleccionarRuta;
        private System.Windows.Forms.CheckBox checkBoxPDF;
        private System.Windows.Forms.Label labelNumeroDiplomas;
        private System.Windows.Forms.Label label3;
        private Sunisoft.IrisSkin.SkinEngine skinEngineDiploma;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}