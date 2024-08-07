﻿namespace OpenSpaceComarcal
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
            this.buttonGenerar.Location = new System.Drawing.Point(280, 263);
            this.buttonGenerar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGenerar.Name = "buttonGenerar";
            this.buttonGenerar.Size = new System.Drawing.Size(170, 65);
            this.buttonGenerar.TabIndex = 26;
            this.buttonGenerar.Text = "Generar";
            this.buttonGenerar.UseVisualStyleBackColor = true;
            this.buttonGenerar.Click += new System.EventHandler(this.buttonGenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 47);
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
            this.groupBox1.Location = new System.Drawing.Point(18, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(693, 166);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // labelNumeroDiplomas
            // 
            this.labelNumeroDiplomas.AutoSize = true;
            this.labelNumeroDiplomas.Location = new System.Drawing.Point(256, 106);
            this.labelNumeroDiplomas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumeroDiplomas.Name = "labelNumeroDiplomas";
            this.labelNumeroDiplomas.Size = new System.Drawing.Size(18, 20);
            this.labelNumeroDiplomas.TabIndex = 32;
            this.labelNumeroDiplomas.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Número de diplomas a generar:";
            // 
            // checkBoxPDF
            // 
            this.checkBoxPDF.AutoSize = true;
            this.checkBoxPDF.Location = new System.Drawing.Point(484, 105);
            this.checkBoxPDF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxPDF.Name = "checkBoxPDF";
            this.checkBoxPDF.Size = new System.Drawing.Size(130, 24);
            this.checkBoxPDF.TabIndex = 30;
            this.checkBoxPDF.Text = "Generar PDF";
            this.checkBoxPDF.UseVisualStyleBackColor = true;
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
            // skinEngineDiploma
            // 
            this.skinEngineDiploma.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngineDiploma.SkinFile = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-4, -6);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(735, 15);
            this.progressBar1.TabIndex = 29;
            // 
            // FormRutaDiploma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 318);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGenerar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(742, 374);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(742, 374);
            this.Name = "FormRutaDiploma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DIPLOMA - OPEN SPACE COMARCAL";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormRutaDiploma_Load);
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