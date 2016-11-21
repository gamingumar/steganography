namespace DIPAsg2
{
    partial class Form1
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
            this.picImg = new System.Windows.Forms.PictureBox();
            this.btnOpnImg = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.picEncrypt = new System.Windows.Forms.PictureBox();
            this.picDecrypt = new System.Windows.Forms.PictureBox();
            this.picImg2 = new System.Windows.Forms.PictureBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnSaveEnc = new System.Windows.Forms.Button();
            this.btnSaveDec = new System.Windows.Forms.Button();
            this.btnDecEnc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkColorAlgo = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnHideText = new System.Windows.Forms.Button();
            this.btnExtractText = new System.Windows.Forms.Button();
            this.btnExtractTextFromImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEncrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDecrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // picImg
            // 
            this.picImg.Location = new System.Drawing.Point(6, 20);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(287, 217);
            this.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImg.TabIndex = 1;
            this.picImg.TabStop = false;
            // 
            // btnOpnImg
            // 
            this.btnOpnImg.BackColor = System.Drawing.Color.Azure;
            this.btnOpnImg.Location = new System.Drawing.Point(6, 24);
            this.btnOpnImg.Name = "btnOpnImg";
            this.btnOpnImg.Size = new System.Drawing.Size(155, 49);
            this.btnOpnImg.TabIndex = 4;
            this.btnOpnImg.Text = "Choose Image";
            this.btnOpnImg.UseVisualStyleBackColor = false;
            this.btnOpnImg.Click += new System.EventHandler(this.btnOpnImg_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDecrypt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDecrypt.Location = new System.Drawing.Point(6, 176);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(155, 54);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.Text = "DECRYPT Image";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // picEncrypt
            // 
            this.picEncrypt.Location = new System.Drawing.Point(3, 24);
            this.picEncrypt.Name = "picEncrypt";
            this.picEncrypt.Size = new System.Drawing.Size(290, 227);
            this.picEncrypt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEncrypt.TabIndex = 6;
            this.picEncrypt.TabStop = false;
            // 
            // picDecrypt
            // 
            this.picDecrypt.Location = new System.Drawing.Point(6, 24);
            this.picDecrypt.Name = "picDecrypt";
            this.picDecrypt.Size = new System.Drawing.Size(279, 227);
            this.picDecrypt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDecrypt.TabIndex = 7;
            this.picDecrypt.TabStop = false;
            // 
            // picImg2
            // 
            this.picImg2.Location = new System.Drawing.Point(6, 20);
            this.picImg2.Name = "picImg2";
            this.picImg2.Size = new System.Drawing.Size(277, 217);
            this.picImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImg2.TabIndex = 8;
            this.picImg2.TabStop = false;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.Crimson;
            this.btnEncrypt.Location = new System.Drawing.Point(6, 100);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(155, 54);
            this.btnEncrypt.TabIndex = 9;
            this.btnEncrypt.Text = "ENCRYPT Image";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnSaveEnc
            // 
            this.btnSaveEnc.BackColor = System.Drawing.Color.Azure;
            this.btnSaveEnc.Location = new System.Drawing.Point(18, 265);
            this.btnSaveEnc.Name = "btnSaveEnc";
            this.btnSaveEnc.Size = new System.Drawing.Size(137, 37);
            this.btnSaveEnc.TabIndex = 10;
            this.btnSaveEnc.Text = "Save Encrypted Image";
            this.btnSaveEnc.UseVisualStyleBackColor = false;
            this.btnSaveEnc.Click += new System.EventHandler(this.btnSaveEnc_Click);
            // 
            // btnSaveDec
            // 
            this.btnSaveDec.BackColor = System.Drawing.Color.Azure;
            this.btnSaveDec.Location = new System.Drawing.Point(486, 271);
            this.btnSaveDec.Name = "btnSaveDec";
            this.btnSaveDec.Size = new System.Drawing.Size(134, 37);
            this.btnSaveDec.TabIndex = 11;
            this.btnSaveDec.Text = "Save Decrypted Image";
            this.btnSaveDec.UseVisualStyleBackColor = false;
            this.btnSaveDec.Click += new System.EventHandler(this.btnSaveDec_Click);
            // 
            // btnDecEnc
            // 
            this.btnDecEnc.BackColor = System.Drawing.Color.Red;
            this.btnDecEnc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecEnc.Location = new System.Drawing.Point(287, 266);
            this.btnDecEnc.Name = "btnDecEnc";
            this.btnDecEnc.Size = new System.Drawing.Size(122, 42);
            this.btnDecEnc.TabIndex = 14;
            this.btnDecEnc.Text = "Extract Image";
            this.btnDecEnc.UseVisualStyleBackColor = false;
            this.btnDecEnc.Click += new System.EventHandler(this.btnDecEnc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkColorAlgo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnOpnImg);
            this.groupBox1.Controls.Add(this.btnDecrypt);
            this.groupBox1.Controls.Add(this.btnEncrypt);
            this.groupBox1.Location = new System.Drawing.Point(634, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 553);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // chkColorAlgo
            // 
            this.chkColorAlgo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkColorAlgo.ForeColor = System.Drawing.Color.Red;
            this.chkColorAlgo.Location = new System.Drawing.Point(6, 388);
            this.chkColorAlgo.Name = "chkColorAlgo";
            this.chkColorAlgo.Size = new System.Drawing.Size(161, 101);
            this.chkColorAlgo.TabIndex = 20;
            this.chkColorAlgo.Text = "Encrypt / Decrypt Color Image (May Reduce Image Quality)";
            this.chkColorAlgo.UseVisualStyleBackColor = true;
            this.chkColorAlgo.CheckedChanged += new System.EventHandler(this.chkColorAlgo_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picImg);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 243);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picImg2);
            this.groupBox3.Location = new System.Drawing.Point(337, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 243);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image to Hide";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.picEncrypt);
            this.groupBox4.Location = new System.Drawing.Point(12, 308);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(299, 257);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Encrypted Image";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.picDecrypt);
            this.groupBox5.Location = new System.Drawing.Point(337, 308);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(291, 257);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hidden Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(8, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(595, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "* Decryption of a Saved Image may reduce Quality of Hidden Image because of Image" +
    " Compression of PNG Format";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(8, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "* Check the box to Encrypt and Decrypt Colored Image";
            // 
            // txtBox
            // 
            this.txtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox.Location = new System.Drawing.Point(6, 24);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(220, 206);
            this.txtBox.TabIndex = 23;
            this.txtBox.Text = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnExtractTextFromImage);
            this.groupBox6.Controls.Add(this.btnHideText);
            this.groupBox6.Controls.Add(this.txtBox);
            this.groupBox6.Location = new System.Drawing.Point(824, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(232, 553);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Text within Image";
            // 
            // btnHideText
            // 
            this.btnHideText.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHideText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideText.ForeColor = System.Drawing.Color.Crimson;
            this.btnHideText.Location = new System.Drawing.Point(34, 247);
            this.btnHideText.Name = "btnHideText";
            this.btnHideText.Size = new System.Drawing.Size(155, 54);
            this.btnHideText.TabIndex = 21;
            this.btnHideText.Text = "HIDE Text";
            this.btnHideText.UseVisualStyleBackColor = false;
            this.btnHideText.Click += new System.EventHandler(this.btnHideText_Click);
            // 
            // btnExtractText
            // 
            this.btnExtractText.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExtractText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnExtractText.Location = new System.Drawing.Point(161, 265);
            this.btnExtractText.Name = "btnExtractText";
            this.btnExtractText.Size = new System.Drawing.Size(120, 43);
            this.btnExtractText.TabIndex = 21;
            this.btnExtractText.Text = "EXTRACT Text";
            this.btnExtractText.UseVisualStyleBackColor = false;
            this.btnExtractText.Click += new System.EventHandler(this.btnExtractText_Click);
            // 
            // btnExtractTextFromImage
            // 
            this.btnExtractTextFromImage.BackColor = System.Drawing.Color.Red;
            this.btnExtractTextFromImage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtractTextFromImage.Location = new System.Drawing.Point(34, 320);
            this.btnExtractTextFromImage.Name = "btnExtractTextFromImage";
            this.btnExtractTextFromImage.Size = new System.Drawing.Size(155, 109);
            this.btnExtractTextFromImage.TabIndex = 24;
            this.btnExtractTextFromImage.Text = "Extract Text from Image";
            this.btnExtractTextFromImage.UseVisualStyleBackColor = false;
            this.btnExtractTextFromImage.Click += new System.EventHandler(this.btnExtractTextFromImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1114, 632);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnDecEnc);
            this.Controls.Add(this.btnExtractText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveDec);
            this.Controls.Add(this.btnSaveEnc);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[STEGANOGRAPHY] Muhammad Umar 110613 DIP Assignment 2";
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEncrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDecrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.Button btnOpnImg;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.PictureBox picEncrypt;
        private System.Windows.Forms.PictureBox picDecrypt;
        private System.Windows.Forms.PictureBox picImg2;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnSaveEnc;
        private System.Windows.Forms.Button btnSaveDec;
        private System.Windows.Forms.Button btnDecEnc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkColorAlgo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnExtractText;
        private System.Windows.Forms.Button btnHideText;
        private System.Windows.Forms.Button btnExtractTextFromImage;
    }
}

