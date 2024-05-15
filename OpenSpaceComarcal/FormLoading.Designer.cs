namespace OpenSpaceComarcal
{
    partial class FormLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoading));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxLoadingBar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxLogo.Image = global::OpenSpaceComarcal.Properties.Resources.logo_oscomarcal;
            this.pictureBoxLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxLogo.Location = new System.Drawing.Point(275, 253);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(267, 119);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 18;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxLoadingBar
            // 
            this.pictureBoxLoadingBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLoadingBar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLoadingBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxLoadingBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxLoadingBar.Image = global::OpenSpaceComarcal.Properties.Resources.cargando_icono;
            this.pictureBoxLoadingBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxLoadingBar.Location = new System.Drawing.Point(239, 167);
            this.pictureBoxLoadingBar.Name = "pictureBoxLoadingBar";
            this.pictureBoxLoadingBar.Size = new System.Drawing.Size(339, 80);
            this.pictureBoxLoadingBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoadingBar.TabIndex = 19;
            this.pictureBoxLoadingBar.TabStop = false;
            this.pictureBoxLoadingBar.WaitOnLoad = true;
            // 
            // FormLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::OpenSpaceComarcal.Properties.Resources.fondo_home;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.pictureBoxLoadingBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLoading";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPEN SPACE COMARCAL - Loading";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxLoadingBar;
    }
}