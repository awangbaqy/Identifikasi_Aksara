namespace Identifikasi_Aksara
{
    partial class FormAksara
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
            this.pbAksara = new System.Windows.Forms.PictureBox();
            this.tbAksara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAksara)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAksara
            // 
            this.pbAksara.Location = new System.Drawing.Point(12, 12);
            this.pbAksara.Name = "pbAksara";
            this.pbAksara.Size = new System.Drawing.Size(210, 150);
            this.pbAksara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAksara.TabIndex = 0;
            this.pbAksara.TabStop = false;
            // 
            // tbAksara
            // 
            this.tbAksara.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbAksara.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAksara.Location = new System.Drawing.Point(12, 172);
            this.tbAksara.Name = "tbAksara";
            this.tbAksara.ReadOnly = true;
            this.tbAksara.Size = new System.Drawing.Size(210, 30);
            this.tbAksara.TabIndex = 1;
            this.tbAksara.Text = "-";
            this.tbAksara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormAksara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.tbAksara);
            this.Controls.Add(this.pbAksara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAksara";
            this.Text = "Aksara";
            ((System.ComponentModel.ISupportInitialize)(this.pbAksara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAksara;
        private System.Windows.Forms.TextBox tbAksara;
    }
}