namespace Identifikasi_Aksara
{
    partial class FormTesting
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbChaincode = new System.Windows.Forms.TextBox();
            this.btnClassification = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.pbThinning = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbCrop = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbBiner = new System.Windows.Forms.PictureBox();
            this.pbGrayscale = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbAksara = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbClassification = new System.Windows.Forms.TextBox();
            this.cbNilaiK = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbThinning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBiner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrayscale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAksara)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(607, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 41;
            this.label7.Text = "Input K :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Chaincode :";
            // 
            // tbChaincode
            // 
            this.tbChaincode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChaincode.Location = new System.Drawing.Point(141, 192);
            this.tbChaincode.Multiline = true;
            this.tbChaincode.Name = "tbChaincode";
            this.tbChaincode.ReadOnly = true;
            this.tbChaincode.Size = new System.Drawing.Size(463, 50);
            this.tbChaincode.TabIndex = 38;
            // 
            // btnClassification
            // 
            this.btnClassification.Location = new System.Drawing.Point(12, 248);
            this.btnClassification.Name = "btnClassification";
            this.btnClassification.Size = new System.Drawing.Size(592, 23);
            this.btnClassification.TabIndex = 36;
            this.btnClassification.Text = "Classification";
            this.btnClassification.UseVisualStyleBackColor = true;
            this.btnClassification.Click += new System.EventHandler(this.btnClassification_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(15, 192);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(120, 23);
            this.btnProcess.TabIndex = 35;
            this.btnProcess.Text = "Process to Chaincode";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(141, 127);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(85, 23);
            this.btnPre.TabIndex = 34;
            this.btnPre.Text = "Pre-processing";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(141, 30);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(85, 23);
            this.btnInput.TabIndex = 33;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // pbThinning
            // 
            this.pbThinning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbThinning.Location = new System.Drawing.Point(610, 30);
            this.pbThinning.Name = "pbThinning";
            this.pbThinning.Size = new System.Drawing.Size(120, 120);
            this.pbThinning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbThinning.TabIndex = 31;
            this.pbThinning.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(607, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Thinning";
            // 
            // pbCrop
            // 
            this.pbCrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCrop.Location = new System.Drawing.Point(484, 30);
            this.pbCrop.Name = "pbCrop";
            this.pbCrop.Size = new System.Drawing.Size(120, 120);
            this.pbCrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCrop.TabIndex = 29;
            this.pbCrop.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Crop";
            // 
            // pbBiner
            // 
            this.pbBiner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBiner.Location = new System.Drawing.Point(358, 30);
            this.pbBiner.Name = "pbBiner";
            this.pbBiner.Size = new System.Drawing.Size(120, 120);
            this.pbBiner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBiner.TabIndex = 28;
            this.pbBiner.TabStop = false;
            // 
            // pbGrayscale
            // 
            this.pbGrayscale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGrayscale.Location = new System.Drawing.Point(232, 30);
            this.pbGrayscale.Name = "pbGrayscale";
            this.pbGrayscale.Size = new System.Drawing.Size(120, 120);
            this.pbGrayscale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGrayscale.TabIndex = 26;
            this.pbGrayscale.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Grayscale";
            // 
            // pbAksara
            // 
            this.pbAksara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAksara.Location = new System.Drawing.Point(15, 30);
            this.pbAksara.Name = "pbAksara";
            this.pbAksara.Size = new System.Drawing.Size(120, 120);
            this.pbAksara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAksara.TabIndex = 24;
            this.pbAksara.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Aksara";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 42;
            this.label5.Text = "Biner";
            // 
            // tbClassification
            // 
            this.tbClassification.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbClassification.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClassification.Location = new System.Drawing.Point(12, 277);
            this.tbClassification.Name = "tbClassification";
            this.tbClassification.ReadOnly = true;
            this.tbClassification.Size = new System.Drawing.Size(716, 30);
            this.tbClassification.TabIndex = 43;
            this.tbClassification.Text = "-";
            this.tbClassification.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbNilaiK
            // 
            this.cbNilaiK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNilaiK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNilaiK.FormattingEnabled = true;
            this.cbNilaiK.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbNilaiK.Location = new System.Drawing.Point(610, 192);
            this.cbNilaiK.Name = "cbNilaiK";
            this.cbNilaiK.Size = new System.Drawing.Size(120, 33);
            this.cbNilaiK.TabIndex = 44;
            // 
            // FormTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 317);
            this.Controls.Add(this.cbNilaiK);
            this.Controls.Add(this.tbClassification);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbChaincode);
            this.Controls.Add(this.btnClassification);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.pbThinning);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbCrop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbBiner);
            this.Controls.Add(this.pbGrayscale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbAksara);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormTesting";
            this.Text = "Form Testing";
            ((System.ComponentModel.ISupportInitialize)(this.pbThinning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBiner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrayscale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAksara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbChaincode;
        private System.Windows.Forms.Button btnClassification;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.PictureBox pbThinning;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbCrop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbBiner;
        private System.Windows.Forms.PictureBox pbGrayscale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbAksara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbClassification;
        private System.Windows.Forms.ComboBox cbNilaiK;
    }
}