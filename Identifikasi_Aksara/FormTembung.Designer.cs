namespace Identifikasi_Aksara
{
    partial class FormTembung
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbBiner = new System.Windows.Forms.PictureBox();
            this.pbGrayscale = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbAksara = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbClassification = new System.Windows.Forms.TextBox();
            this.cbNilaiK = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.btnHasil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBiner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrayscale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAksara)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(141, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 18);
            this.label9.TabIndex = 55;
            this.label9.Text = "=>";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(141, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 18);
            this.label8.TabIndex = 54;
            this.label8.Text = "=>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 53;
            this.label5.Text = "Biner";
            // 
            // pbBiner
            // 
            this.pbBiner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBiner.Location = new System.Drawing.Point(299, 30);
            this.pbBiner.Name = "pbBiner";
            this.pbBiner.Size = new System.Drawing.Size(120, 120);
            this.pbBiner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBiner.TabIndex = 52;
            this.pbBiner.TabStop = false;
            // 
            // pbGrayscale
            // 
            this.pbGrayscale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGrayscale.Location = new System.Drawing.Point(173, 30);
            this.pbGrayscale.Name = "pbGrayscale";
            this.pbGrayscale.Size = new System.Drawing.Size(120, 120);
            this.pbGrayscale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGrayscale.TabIndex = 50;
            this.pbGrayscale.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "Grayscale";
            // 
            // pbAksara
            // 
            this.pbAksara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAksara.Location = new System.Drawing.Point(15, 30);
            this.pbAksara.Name = "pbAksara";
            this.pbAksara.Size = new System.Drawing.Size(120, 120);
            this.pbAksara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAksara.TabIndex = 48;
            this.pbAksara.TabStop = false;
            this.pbAksara.Click += new System.EventHandler(this.pbAksara_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "Aksara";
            // 
            // tbClassification
            // 
            this.tbClassification.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbClassification.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClassification.Location = new System.Drawing.Point(144, 156);
            this.tbClassification.Name = "tbClassification";
            this.tbClassification.ReadOnly = true;
            this.tbClassification.Size = new System.Drawing.Size(232, 30);
            this.tbClassification.TabIndex = 56;
            this.tbClassification.Text = "-";
            this.tbClassification.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbNilaiK
            // 
            this.cbNilaiK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNilaiK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNilaiK.FormattingEnabled = true;
            this.cbNilaiK.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbNilaiK.Location = new System.Drawing.Point(81, 156);
            this.cbNilaiK.Name = "cbNilaiK";
            this.cbNilaiK.Size = new System.Drawing.Size(54, 26);
            this.cbNilaiK.TabIndex = 58;
            this.cbNilaiK.SelectedIndexChanged += new System.EventHandler(this.cbNilaiK_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 18);
            this.label10.TabIndex = 57;
            this.label10.Text = "Input K :";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 199);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(430, 22);
            this.statusStrip1.TabIndex = 60;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(415, 16);
            // 
            // btnHasil
            // 
            this.btnHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHasil.Location = new System.Drawing.Point(382, 156);
            this.btnHasil.Name = "btnHasil";
            this.btnHasil.Size = new System.Drawing.Size(37, 30);
            this.btnHasil.TabIndex = 61;
            this.btnHasil.Text = "=>";
            this.btnHasil.UseVisualStyleBackColor = true;
            this.btnHasil.Click += new System.EventHandler(this.btnHasil_Click);
            // 
            // FormTembung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 221);
            this.Controls.Add(this.btnHasil);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cbNilaiK);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbClassification);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbBiner);
            this.Controls.Add(this.pbGrayscale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbAksara);
            this.Controls.Add(this.label1);
            this.Name = "FormTembung";
            this.Text = "Form Tembung";
            ((System.ComponentModel.ISupportInitialize)(this.pbBiner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrayscale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAksara)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbBiner;
        private System.Windows.Forms.PictureBox pbGrayscale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbAksara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbClassification;
        private System.Windows.Forms.ComboBox cbNilaiK;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button btnHasil;
    }
}