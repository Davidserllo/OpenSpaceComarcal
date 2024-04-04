namespace OpenSpaceComarcal
{
    partial class CrearAlumno
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
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.groupBoxAlumno = new System.Windows.Forms.GroupBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBoxAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(33, 76);
            this.labelDNI.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(45, 25);
            this.labelDNI.TabIndex = 0;
            this.labelDNI.Text = "DNI";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(33, 137);
            this.labelApellidos.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(92, 25);
            this.labelApellidos.TabIndex = 1;
            this.labelApellidos.Text = "Apellidos";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(33, 203);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(81, 25);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // groupBoxAlumno
            // 
            this.groupBoxAlumno.Controls.Add(this.textBoxTelefono);
            this.groupBoxAlumno.Controls.Add(this.textBoxNombre);
            this.groupBoxAlumno.Controls.Add(this.textBoxApellidos);
            this.groupBoxAlumno.Controls.Add(this.textBoxDNI);
            this.groupBoxAlumno.Controls.Add(this.labelTelefono);
            this.groupBoxAlumno.Controls.Add(this.labelDNI);
            this.groupBoxAlumno.Controls.Add(this.labelNombre);
            this.groupBoxAlumno.Controls.Add(this.labelApellidos);
            this.groupBoxAlumno.Location = new System.Drawing.Point(22, 22);
            this.groupBoxAlumno.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxAlumno.Name = "groupBoxAlumno";
            this.groupBoxAlumno.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxAlumno.Size = new System.Drawing.Size(517, 353);
            this.groupBoxAlumno.TabIndex = 3;
            this.groupBoxAlumno.TabStop = false;
            this.groupBoxAlumno.Text = "Información del alumno";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(161, 268);
            this.textBoxTelefono.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(316, 29);
            this.textBoxTelefono.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(161, 198);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(316, 29);
            this.textBoxNombre.TabIndex = 7;
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(161, 131);
            this.textBoxApellidos.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(316, 29);
            this.textBoxApellidos.TabIndex = 6;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(161, 70);
            this.textBoxDNI.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(316, 29);
            this.textBoxDNI.TabIndex = 5;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(33, 273);
            this.labelTelefono.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(89, 25);
            this.labelTelefono.TabIndex = 3;
            this.labelTelefono.Text = "Teléfono";
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(22, 386);
            this.buttonCrear.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(258, 89);
            this.buttonCrear.TabIndex = 4;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(292, 386);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(248, 89);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // CrearAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 497);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.groupBoxAlumno);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CrearAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NUEVO ALUMNO - OPEN SPACE COMARCAL";
            this.groupBoxAlumno.ResumeLayout(false);
            this.groupBoxAlumno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.GroupBox groupBoxAlumno;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonCancelar;
    }
}