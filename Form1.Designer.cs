namespace RSA1710900
{
    partial class RSACryptosystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSACryptosystem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLengKey = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.btnOpenFileKeys = new System.Windows.Forms.Button();
            this.tbPathKeys = new System.Windows.Forms.TextBox();
            this.label1f = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.selectOutput = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnOpenFolderIn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnOutOpen = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenFileIn = new System.Windows.Forms.Button();
            this.tbN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbE = new System.Windows.Forms.TextBox();
            this.tbD = new System.Windows.Forms.TextBox();
            this.Module = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_sha1 = new System.Windows.Forms.TextBox();
            this.lbl_sha256 = new System.Windows.Forms.TextBox();
            this.lbl_md5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lable12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_checksum = new System.Windows.Forms.Button();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_chonfile = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxLengKey);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnGenerateKey);
            this.panel1.Controls.Add(this.btnOpenFileKeys);
            this.panel1.Controls.Add(this.tbPathKeys);
            this.panel1.Location = new System.Drawing.Point(10, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 136);
            this.panel1.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(180, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 22);
            this.label13.TabIndex = 10;
            this.label13.Text = "Tạo Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "File Key (Xml):";
            // 
            // comboBoxLengKey
            // 
            this.comboBoxLengKey.FormattingEnabled = true;
            this.comboBoxLengKey.Location = new System.Drawing.Point(106, 47);
            this.comboBoxLengKey.Name = "comboBoxLengKey";
            this.comboBoxLengKey.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLengKey.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Độ dài Key:";
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Location = new System.Drawing.Point(233, 47);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(106, 23);
            this.btnGenerateKey.TabIndex = 3;
            this.btnGenerateKey.Text = "Tạo Key Tự Động";
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // btnOpenFileKeys
            // 
            this.btnOpenFileKeys.Location = new System.Drawing.Point(383, 79);
            this.btnOpenFileKeys.Name = "btnOpenFileKeys";
            this.btnOpenFileKeys.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFileKeys.TabIndex = 2;
            this.btnOpenFileKeys.Text = "Open";
            this.btnOpenFileKeys.UseVisualStyleBackColor = true;
            this.btnOpenFileKeys.Click += new System.EventHandler(this.btnOpenFileKeys_Click);
            // 
            // tbPathKeys
            // 
            this.tbPathKeys.Location = new System.Drawing.Point(106, 81);
            this.tbPathKeys.Name = "tbPathKeys";
            this.tbPathKeys.Size = new System.Drawing.Size(271, 20);
            this.tbPathKeys.TabIndex = 1;
            // 
            // label1f
            // 
            this.label1f.AutoSize = true;
            this.label1f.Location = new System.Drawing.Point(27, 185);
            this.label1f.Name = "label1f";
            this.label1f.Size = new System.Drawing.Size(0, 13);
            this.label1f.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.selectOutput);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.btnOpenFolderIn);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.label1f);
            this.panel2.Controls.Add(this.btnOutOpen);
            this.panel2.Controls.Add(this.btnDecrypt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnEncrypt);
            this.panel2.Controls.Add(this.tbOutput);
            this.panel2.Controls.Add(this.tbInput);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnOpenFileIn);
            this.panel2.Location = new System.Drawing.Point(10, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 209);
            this.panel2.TabIndex = 1;
            // 
            // selectOutput
            // 
            this.selectOutput.Location = new System.Drawing.Point(383, 83);
            this.selectOutput.Name = "selectOutput";
            this.selectOutput.Size = new System.Drawing.Size(83, 23);
            this.selectOutput.TabIndex = 15;
            this.selectOutput.Text = "Select Folder";
            this.selectOutput.UseVisualStyleBackColor = true;
            this.selectOutput.Click += new System.EventHandler(this.selectOutput_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(148, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(177, 22);
            this.label14.TabIndex = 14;
            this.label14.Text = "Mã Hoá Và Giải Mã";
            // 
            // btnOpenFolderIn
            // 
            this.btnOpenFolderIn.Location = new System.Drawing.Point(383, 53);
            this.btnOpenFolderIn.Name = "btnOpenFolderIn";
            this.btnOpenFolderIn.Size = new System.Drawing.Size(83, 23);
            this.btnOpenFolderIn.TabIndex = 12;
            this.btnOpenFolderIn.Text = "Select Folder";
            this.btnOpenFolderIn.UseVisualStyleBackColor = true;
            this.btnOpenFolderIn.Click += new System.EventHandler(this.btnOpenFolderIn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 159);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(396, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // btnOutOpen
            // 
            this.btnOutOpen.Location = new System.Drawing.Point(383, 108);
            this.btnOutOpen.Name = "btnOutOpen";
            this.btnOutOpen.Size = new System.Drawing.Size(83, 23);
            this.btnOutOpen.TabIndex = 9;
            this.btnOutOpen.Text = "Open Folder";
            this.btnOutOpen.UseVisualStyleBackColor = true;
            this.btnOutOpen.Click += new System.EventHandler(this.btnOutOpen_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(264, 130);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 11;
            this.btnDecrypt.Text = "Giải Mã";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Output: ";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(123, 130);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 10;
            this.btnEncrypt.Text = "Mã Hoá";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(106, 100);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(271, 20);
            this.tbOutput.TabIndex = 7;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(106, 39);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(271, 20);
            this.tbInput.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Input: ";
            // 
            // btnOpenFileIn
            // 
            this.btnOpenFileIn.Location = new System.Drawing.Point(383, 29);
            this.btnOpenFileIn.Name = "btnOpenFileIn";
            this.btnOpenFileIn.Size = new System.Drawing.Size(83, 23);
            this.btnOpenFileIn.TabIndex = 0;
            this.btnOpenFileIn.Text = "Select File";
            this.btnOpenFileIn.UseVisualStyleBackColor = true;
            this.btnOpenFileIn.Click += new System.EventHandler(this.btnOpenFileIn_Click);
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(84, 43);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(250, 20);
            this.tbN.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thông tin Key";
            // 
            // tbE
            // 
            this.tbE.Location = new System.Drawing.Point(84, 75);
            this.tbE.Name = "tbE";
            this.tbE.Size = new System.Drawing.Size(250, 20);
            this.tbE.TabIndex = 4;
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(84, 111);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(250, 20);
            this.tbD.TabIndex = 5;
            // 
            // Module
            // 
            this.Module.AutoSize = true;
            this.Module.Location = new System.Drawing.Point(3, 45);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(62, 13);
            this.Module.TabIndex = 6;
            this.Module.Text = "Module (N):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mũ Mã Hoá (E):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mũ Giải Mã (D):";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(408, 425);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(141, 35);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "RESET FORM";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.Module);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.tbN);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tbE);
            this.panel3.Controls.Add(this.tbD);
            this.panel3.Location = new System.Drawing.Point(482, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 168);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lbl_sha1);
            this.panel4.Controls.Add(this.lbl_sha256);
            this.panel4.Controls.Add(this.lbl_md5);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.lable12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.btn_checksum);
            this.panel4.Controls.Add(this.txt_input);
            this.panel4.Controls.Add(this.btn_chonfile);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(482, 239);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(344, 170);
            this.panel4.TabIndex = 12;
            // 
            // lbl_sha1
            // 
            this.lbl_sha1.Location = new System.Drawing.Point(53, 115);
            this.lbl_sha1.Name = "lbl_sha1";
            this.lbl_sha1.Size = new System.Drawing.Size(281, 20);
            this.lbl_sha1.TabIndex = 11;
            // 
            // lbl_sha256
            // 
            this.lbl_sha256.Location = new System.Drawing.Point(54, 138);
            this.lbl_sha256.Name = "lbl_sha256";
            this.lbl_sha256.Size = new System.Drawing.Size(280, 20);
            this.lbl_sha256.TabIndex = 10;
            // 
            // lbl_md5
            // 
            this.lbl_md5.Location = new System.Drawing.Point(53, 89);
            this.lbl_md5.Name = "lbl_md5";
            this.lbl_md5.Size = new System.Drawing.Size(281, 20);
            this.lbl_md5.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(67, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 8;
            // 
            // lable12
            // 
            this.lable12.AutoSize = true;
            this.lable12.Location = new System.Drawing.Point(6, 145);
            this.lable12.Name = "lable12";
            this.lable12.Size = new System.Drawing.Size(50, 13);
            this.lable12.TabIndex = 7;
            this.lable12.Text = "SHA256:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "SHA1:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "MD5:";
            // 
            // btn_checksum
            // 
            this.btn_checksum.Location = new System.Drawing.Point(137, 61);
            this.btn_checksum.Name = "btn_checksum";
            this.btn_checksum.Size = new System.Drawing.Size(75, 23);
            this.btn_checksum.TabIndex = 4;
            this.btn_checksum.Text = "Kiểm Tra";
            this.btn_checksum.UseVisualStyleBackColor = true;
            this.btn_checksum.Click += new System.EventHandler(this.btn_checksum_Click);
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(53, 35);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(200, 20);
            this.txt_input.TabIndex = 3;
            // 
            // btn_chonfile
            // 
            this.btn_chonfile.Location = new System.Drawing.Point(259, 33);
            this.btn_chonfile.Name = "btn_chonfile";
            this.btn_chonfile.Size = new System.Drawing.Size(75, 23);
            this.btn_chonfile.TabIndex = 2;
            this.btn_chonfile.Text = "Open File";
            this.btn_chonfile.UseVisualStyleBackColor = true;
            this.btn_chonfile.Click += new System.EventHandler(this.btn_chonfile_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "File: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(129, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kiểm Tra File";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Location = new System.Drawing.Point(318, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(297, 50);
            this.panel5.TabIndex = 13;
            // 
            // RSACryptosystem
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(850, 472);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RSACryptosystem";
            this.Text = "RSA Cryptosystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbPathKeys;
        private System.Windows.Forms.Label label1f;
        private System.Windows.Forms.Button btnOpenFileKeys;
        private System.Windows.Forms.ComboBox comboBoxLengKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenFileIn;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btnOutOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbE;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.Label Module;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOpenFolderIn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_chonfile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_checksum;
        private System.Windows.Forms.Label lable12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox lbl_sha1;
        private System.Windows.Forms.TextBox lbl_sha256;
        private System.Windows.Forms.TextBox lbl_md5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button selectOutput;
        private System.Windows.Forms.Panel panel5;
    }
}

