namespace Identifikasi_Aksara
{
    partial class FormTraining
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
            this.label1 = new System.Windows.Forms.Label();
            this.pbGrayscale = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbBiner = new System.Windows.Forms.PictureBox();
            this.pbCrop = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbThinning = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.tbChaincode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbIterasi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAksara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrayscale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBiner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThinning)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAksara
            // 
            this.pbAksara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAksara.Location = new System.Drawing.Point(15, 30);
            this.pbAksara.Name = "pbAksara";
            this.pbAksara.Size = new System.Drawing.Size(120, 120);
            this.pbAksara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAksara.TabIndex = 0;
            this.pbAksara.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aksara";
            // 
            // pbGrayscale
            // 
            this.pbGrayscale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGrayscale.Location = new System.Drawing.Point(232, 30);
            this.pbGrayscale.Name = "pbGrayscale";
            this.pbGrayscale.Size = new System.Drawing.Size(120, 120);
            this.pbGrayscale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGrayscale.TabIndex = 6;
            this.pbGrayscale.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Grayscale";
            // 
            // pbBiner
            // 
            this.pbBiner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBiner.Location = new System.Drawing.Point(358, 30);
            this.pbBiner.Name = "pbBiner";
            this.pbBiner.Size = new System.Drawing.Size(120, 120);
            this.pbBiner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBiner.TabIndex = 8;
            this.pbBiner.TabStop = false;
            // 
            // pbCrop
            // 
            this.pbCrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCrop.Location = new System.Drawing.Point(484, 30);
            this.pbCrop.Name = "pbCrop";
            this.pbCrop.Size = new System.Drawing.Size(120, 120);
            this.pbCrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCrop.TabIndex = 9;
            this.pbCrop.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Crop";
            // 
            // pbThinning
            // 
            this.pbThinning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbThinning.Location = new System.Drawing.Point(610, 30);
            this.pbThinning.Name = "pbThinning";
            this.pbThinning.Size = new System.Drawing.Size(120, 120);
            this.pbThinning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbThinning.TabIndex = 11;
            this.pbThinning.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(607, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Thinning";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(141, 30);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(85, 23);
            this.btnInput.TabIndex = 13;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(141, 127);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(85, 23);
            this.btnPre.TabIndex = 14;
            this.btnPre.Text = "Pre-processing";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(15, 192);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(120, 23);
            this.btnProcess.TabIndex = 15;
            this.btnProcess.Text = "Process to Chaincode";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(15, 284);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(120, 23);
            this.btnTrain.TabIndex = 16;
            this.btnTrain.Text = "Train Data";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(15, 340);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(120, 23);
            this.btnSimpan.TabIndex = 17;
            this.btnSimpan.Text = "Simpan Thinning";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // tbChaincode
            // 
            this.tbChaincode.Location = new System.Drawing.Point(141, 192);
            this.tbChaincode.Multiline = true;
            this.tbChaincode.Name = "tbChaincode";
            this.tbChaincode.ReadOnly = true;
            this.tbChaincode.Size = new System.Drawing.Size(589, 50);
            this.tbChaincode.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Chaincode :";
            // 
            // tbIterasi
            // 
            this.tbIterasi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbIterasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIterasi.Location = new System.Drawing.Point(141, 284);
            this.tbIterasi.Multiline = true;
            this.tbIterasi.Name = "tbIterasi";
            this.tbIterasi.Size = new System.Drawing.Size(150, 50);
            this.tbIterasi.TabIndex = 21;
            this.tbIterasi.Leave += new System.EventHandler(this.tbIterasi_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(138, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Iterasi Aksara :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Biner";
            // 
            // FormTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 374);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbIterasi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbChaincode);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnTrain);
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
            this.Name = "FormTraining";
            this.Text = "Form Training";
            ((System.ComponentModel.ISupportInitialize)(this.pbAksara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrayscale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBiner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThinning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAksara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbGrayscale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbBiner;
        private System.Windows.Forms.PictureBox pbCrop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbThinning;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox tbChaincode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbIterasi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}