namespace Identifikasi_Aksara
{
    partial class FormCompact
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
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIterasi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbChaincode = new System.Windows.Forms.TextBox();
            this.btnTrain = new System.Windows.Forms.Button();
            this.pbThinning = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbCrop = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbBiner = new System.Windows.Forms.PictureBox();
            this.pbGrayscale = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbAksara = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbNilaiK = new System.Windows.Forms.ComboBox();
            this.tbClassification = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClassification = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbThinning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBiner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrayscale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAksara)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 43;
            this.label5.Text = "Biner";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 18);
            this.label7.TabIndex = 42;
            this.label7.Text = "Iterasi Aksara :";
            // 
            // tbIterasi
            // 
            this.tbIterasi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbIterasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIterasi.Location = new System.Drawing.Point(6, 59);
            this.tbIterasi.Multiline = true;
            this.tbIterasi.Name = "tbIterasi";
            this.tbIterasi.Size = new System.Drawing.Size(175, 50);
            this.tbIterasi.TabIndex = 41;
            this.tbIterasi.Text = "TARUNG";
            this.tbIterasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbIterasi.Enter += new System.EventHandler(this.tbIterasi_Enter);
            this.tbIterasi.Leave += new System.EventHandler(this.tbIterasi_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 40;
            this.label6.Text = "Chaincode :";
            // 
            // tbChaincode
            // 
            this.tbChaincode.Location = new System.Drawing.Point(15, 174);
            this.tbChaincode.Multiline = true;
            this.tbChaincode.Name = "tbChaincode";
            this.tbChaincode.ReadOnly = true;
            this.tbChaincode.Size = new System.Drawing.Size(656, 50);
            this.tbChaincode.TabIndex = 39;
            // 
            // btnTrain
            // 
            this.btnTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrain.Location = new System.Drawing.Point(187, 59);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(105, 50);
            this.btnTrain.TabIndex = 37;
            this.btnTrain.Text = "Train Data";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // pbThinning
            // 
            this.pbThinning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbThinning.Location = new System.Drawing.Point(551, 30);
            this.pbThinning.Name = "pbThinning";
            this.pbThinning.Size = new System.Drawing.Size(120, 120);
            this.pbThinning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbThinning.TabIndex = 32;
            this.pbThinning.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(548, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Thinning";
            // 
            // pbCrop
            // 
            this.pbCrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCrop.Location = new System.Drawing.Point(425, 30);
            this.pbCrop.Name = "pbCrop";
            this.pbCrop.Size = new System.Drawing.Size(120, 120);
            this.pbCrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCrop.TabIndex = 30;
            this.pbCrop.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "Crop";
            // 
            // pbBiner
            // 
            this.pbBiner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBiner.Location = new System.Drawing.Point(299, 30);
            this.pbBiner.Name = "pbBiner";
            this.pbBiner.Size = new System.Drawing.Size(120, 120);
            this.pbBiner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBiner.TabIndex = 29;
            this.pbBiner.TabStop = false;
            // 
            // pbGrayscale
            // 
            this.pbGrayscale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGrayscale.Location = new System.Drawing.Point(173, 30);
            this.pbGrayscale.Name = "pbGrayscale";
            this.pbGrayscale.Size = new System.Drawing.Size(120, 120);
            this.pbGrayscale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGrayscale.TabIndex = 27;
            this.pbGrayscale.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Grayscale";
            // 
            // pbAksara
            // 
            this.pbAksara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAksara.Location = new System.Drawing.Point(15, 30);
            this.pbAksara.Name = "pbAksara";
            this.pbAksara.Size = new System.Drawing.Size(120, 120);
            this.pbAksara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAksara.TabIndex = 25;
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
            this.label1.TabIndex = 26;
            this.label1.Text = "Aksara";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbIterasi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnTrain);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 115);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbNilaiK);
            this.groupBox2.Controls.Add(this.tbClassification);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnClassification);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(371, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 115);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Testing";
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
            this.cbNilaiK.Location = new System.Drawing.Point(73, 20);
            this.cbNilaiK.Name = "cbNilaiK";
            this.cbNilaiK.Size = new System.Drawing.Size(221, 26);
            this.cbNilaiK.TabIndex = 48;
            // 
            // tbClassification
            // 
            this.tbClassification.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbClassification.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClassification.Location = new System.Drawing.Point(120, 59);
            this.tbClassification.Multiline = true;
            this.tbClassification.Name = "tbClassification";
            this.tbClassification.ReadOnly = true;
            this.tbClassification.Size = new System.Drawing.Size(175, 50);
            this.tbClassification.TabIndex = 47;
            this.tbClassification.Text = "TARUNG";
            this.tbClassification.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 18);
            this.label10.TabIndex = 46;
            this.label10.Text = "Input K :";
            // 
            // btnClassification
            // 
            this.btnClassification.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassification.Location = new System.Drawing.Point(9, 59);
            this.btnClassification.Name = "btnClassification";
            this.btnClassification.Size = new System.Drawing.Size(105, 50);
            this.btnClassification.TabIndex = 45;
            this.btnClassification.Text = "Classification";
            this.btnClassification.UseVisualStyleBackColor = true;
            this.btnClassification.Click += new System.EventHandler(this.btnClassification_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(141, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 18);
            this.label8.TabIndex = 46;
            this.label8.Text = "=>";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(141, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 18);
            this.label9.TabIndex = 47;
            this.label9.Text = "=>";
            // 
            // FormCompact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 353);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbChaincode);
            this.Controls.Add(this.pbThinning);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbCrop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbBiner);
            this.Controls.Add(this.pbGrayscale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbAksara);
            this.Controls.Add(this.label1);
            this.Name = "FormCompact";
            this.Text = "Identifikasi Aksara Jawa";
            ((System.ComponentModel.ISupportInitialize)(this.pbThinning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBiner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrayscale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAksara)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIterasi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbChaincode;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.PictureBox pbThinning;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbCrop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbBiner;
        private System.Windows.Forms.PictureBox pbGrayscale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbAksara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbNilaiK;
        private System.Windows.Forms.TextBox tbClassification;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClassification;
    }
}