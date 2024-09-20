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
            this.labelNumeroDiplomas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxPDF = new System.Windows.Forms.CheckBox();
            this.buttonSeleccionarRuta = new System.Windows.Forms.Button();
            this.textBoxRutaDestino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.skinEngineDiploma = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGenerar = new System.Windows.Forms.TabPage();
            this.tabPageCombinar = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCombinar = new System.Windows.Forms.TextBox();
            this.buttonRutaCombinar = new System.Windows.Forms.Button();
            this.buttonCombinar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageGenerar.SuspendLayout();
            this.tabPageCombinar.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGenerar
            // 
            this.buttonGenerar.Location = new System.Drawing.Point(165, 119);
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
            // labelNumeroDiplomas
            // 
            this.labelNumeroDiplomas.AutoSize = true;
            this.labelNumeroDiplomas.Location = new System.Drawing.Point(162, 76);
            this.labelNumeroDiplomas.Name = "labelNumeroDiplomas";
            this.labelNumeroDiplomas.Size = new System.Drawing.Size(13, 13);
            this.labelNumeroDiplomas.TabIndex = 32;
            this.labelNumeroDiplomas.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Número de diplomas a generar:";
            // 
            // checkBoxPDF
            // 
            this.checkBoxPDF.AutoSize = true;
            this.checkBoxPDF.Location = new System.Drawing.Point(314, 75);
            this.checkBoxPDF.Name = "checkBoxPDF";
            this.checkBoxPDF.Size = new System.Drawing.Size(88, 17);
            this.checkBoxPDF.TabIndex = 30;
            this.checkBoxPDF.Text = "Generar PDF";
            this.checkBoxPDF.UseVisualStyleBackColor = true;
            // 
            // buttonSeleccionarRuta
            // 
            this.buttonSeleccionarRuta.Location = new System.Drawing.Point(408, 34);
            this.buttonSeleccionarRuta.Name = "buttonSeleccionarRuta";
            this.buttonSeleccionarRuta.Size = new System.Drawing.Size(26, 20);
            this.buttonSeleccionarRuta.TabIndex = 29;
            this.buttonSeleccionarRuta.Text = "...";
            this.buttonSeleccionarRuta.UseVisualStyleBackColor = true;
            this.buttonSeleccionarRuta.Click += new System.EventHandler(this.buttonSeleccionarRuta_Click);
            // 
            // textBoxRutaDestino
            // 
            this.textBoxRutaDestino.Location = new System.Drawing.Point(82, 34);
            this.textBoxRutaDestino.Name = "textBoxRutaDestino";
            this.textBoxRutaDestino.ReadOnly = true;
            this.textBoxRutaDestino.Size = new System.Drawing.Size(320, 20);
            this.textBoxRutaDestino.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGenerar);
            this.tabControl1.Controls.Add(this.tabPageCombinar);
            this.tabControl1.Location = new System.Drawing.Point(12, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(460, 208);
            this.tabControl1.TabIndex = 30;
            // 
            // tabPageGenerar
            // 
            this.tabPageGenerar.Controls.Add(this.labelNumeroDiplomas);
            this.tabPageGenerar.Controls.Add(this.label2);
            this.tabPageGenerar.Controls.Add(this.label3);
            this.tabPageGenerar.Controls.Add(this.buttonGenerar);
            this.tabPageGenerar.Controls.Add(this.textBoxRutaDestino);
            this.tabPageGenerar.Controls.Add(this.checkBoxPDF);
            this.tabPageGenerar.Controls.Add(this.buttonSeleccionarRuta);
            this.tabPageGenerar.Location = new System.Drawing.Point(4, 22);
            this.tabPageGenerar.Name = "tabPageGenerar";
            this.tabPageGenerar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGenerar.Size = new System.Drawing.Size(452, 182);
            this.tabPageGenerar.TabIndex = 0;
            this.tabPageGenerar.Text = "Generar";
            this.tabPageGenerar.UseVisualStyleBackColor = true;
            // 
            // tabPageCombinar
            // 
            this.tabPageCombinar.Controls.Add(this.buttonCombinar);
            this.tabPageCombinar.Controls.Add(this.label4);
            this.tabPageCombinar.Controls.Add(this.textBoxCombinar);
            this.tabPageCombinar.Controls.Add(this.buttonRutaCombinar);
            this.tabPageCombinar.Location = new System.Drawing.Point(4, 22);
            this.tabPageCombinar.Name = "tabPageCombinar";
            this.tabPageCombinar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCombinar.Size = new System.Drawing.Size(452, 182);
            this.tabPageCombinar.TabIndex = 1;
            this.tabPageCombinar.Text = "Combinar";
            this.tabPageCombinar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ruta destino:";
            // 
            // textBoxCombinar
            // 
            this.textBoxCombinar.Location = new System.Drawing.Point(82, 31);
            this.textBoxCombinar.Name = "textBoxCombinar";
            this.textBoxCombinar.ReadOnly = true;
            this.textBoxCombinar.Size = new System.Drawing.Size(320, 20);
            this.textBoxCombinar.TabIndex = 31;
            // 
            // buttonRutaCombinar
            // 
            this.buttonRutaCombinar.Location = new System.Drawing.Point(408, 31);
            this.buttonRutaCombinar.Name = "buttonRutaCombinar";
            this.buttonRutaCombinar.Size = new System.Drawing.Size(26, 20);
            this.buttonRutaCombinar.TabIndex = 32;
            this.buttonRutaCombinar.Text = "...";
            this.buttonRutaCombinar.UseVisualStyleBackColor = true;
            this.buttonRutaCombinar.Click += new System.EventHandler(this.buttonRutaCombinar_Click);
            // 
            // buttonCombinar
            // 
            this.buttonCombinar.Location = new System.Drawing.Point(167, 113);
            this.buttonCombinar.Name = "buttonCombinar";
            this.buttonCombinar.Size = new System.Drawing.Size(113, 42);
            this.buttonCombinar.TabIndex = 33;
            this.buttonCombinar.Text = "Combinar";
            this.buttonCombinar.UseVisualStyleBackColor = true;
            this.buttonCombinar.Click += new System.EventHandler(this.buttonCombinar_Click);
            // 
            // FormRutaDiploma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 269);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRutaDiploma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DIPLOMA - OPEN SPACE COMARCAL";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormRutaDiploma_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageGenerar.ResumeLayout(false);
            this.tabPageGenerar.PerformLayout();
            this.tabPageCombinar.ResumeLayout(false);
            this.tabPageCombinar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRutaDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSeleccionarRuta;
        private System.Windows.Forms.CheckBox checkBoxPDF;
        private System.Windows.Forms.Label labelNumeroDiplomas;
        private System.Windows.Forms.Label label3;
        private Sunisoft.IrisSkin.SkinEngine skinEngineDiploma;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGenerar;
        private System.Windows.Forms.TabPage tabPageCombinar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCombinar;
        private System.Windows.Forms.Button buttonRutaCombinar;
        private System.Windows.Forms.Button buttonCombinar;
    }
}