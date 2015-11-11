namespace abdEncyptPrac
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
            this.txtOriginalMsg = new System.Windows.Forms.TextBox();
            this.txtDecryptedMsg = new System.Windows.Forms.TextBox();
            this.txtEncryptedMsg = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblPrimeA = new System.Windows.Forms.Label();
            this.lblPrimeB = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblPhiN = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.txtPrimeA = new System.Windows.Forms.TextBox();
            this.txtPrimeB = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtPhiN = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.btnGenPrimes = new System.Windows.Forms.Button();
            this.lblEnterMsg = new System.Windows.Forms.Label();
            this.lblEncryptMsg = new System.Windows.Forms.Label();
            this.lblDecryptMsg = new System.Windows.Forms.Label();
            this.lblEnterOwnPrime = new System.Windows.Forms.Label();
            this.chckExtraInfo = new System.Windows.Forms.CheckBox();
            this.grpExtraInfo = new System.Windows.Forms.GroupBox();
            this.grpExtraInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOriginalMsg
            // 
            this.txtOriginalMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginalMsg.Location = new System.Drawing.Point(17, 24);
            this.txtOriginalMsg.Multiline = true;
            this.txtOriginalMsg.Name = "txtOriginalMsg";
            this.txtOriginalMsg.Size = new System.Drawing.Size(374, 67);
            this.txtOriginalMsg.TabIndex = 0;
            // 
            // txtDecryptedMsg
            // 
            this.txtDecryptedMsg.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDecryptedMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecryptedMsg.Location = new System.Drawing.Point(17, 222);
            this.txtDecryptedMsg.Multiline = true;
            this.txtDecryptedMsg.Name = "txtDecryptedMsg";
            this.txtDecryptedMsg.ReadOnly = true;
            this.txtDecryptedMsg.Size = new System.Drawing.Size(374, 70);
            this.txtDecryptedMsg.TabIndex = 1;
            // 
            // txtEncryptedMsg
            // 
            this.txtEncryptedMsg.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEncryptedMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptedMsg.Location = new System.Drawing.Point(17, 119);
            this.txtEncryptedMsg.Multiline = true;
            this.txtEncryptedMsg.Name = "txtEncryptedMsg";
            this.txtEncryptedMsg.ReadOnly = true;
            this.txtEncryptedMsg.Size = new System.Drawing.Size(374, 70);
            this.txtEncryptedMsg.TabIndex = 2;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(397, 24);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(88, 67);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(397, 119);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(88, 70);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblPrimeA
            // 
            this.lblPrimeA.AutoSize = true;
            this.lblPrimeA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeA.Location = new System.Drawing.Point(534, 23);
            this.lblPrimeA.Name = "lblPrimeA";
            this.lblPrimeA.Size = new System.Drawing.Size(67, 19);
            this.lblPrimeA.TabIndex = 5;
            this.lblPrimeA.Text = "Prime A:";
            // 
            // lblPrimeB
            // 
            this.lblPrimeB.AutoSize = true;
            this.lblPrimeB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeB.Location = new System.Drawing.Point(533, 49);
            this.lblPrimeB.Name = "lblPrimeB";
            this.lblPrimeB.Size = new System.Drawing.Size(68, 19);
            this.lblPrimeB.TabIndex = 6;
            this.lblPrimeB.Text = "Prime B:";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.Location = new System.Drawing.Point(33, 16);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(146, 19);
            this.lblN.TabIndex = 7;
            this.lblN.Text = "primeA*primeB (N):";
            this.lblN.Visible = false;
            // 
            // lblPhiN
            // 
            this.lblPhiN.AutoEllipsis = true;
            this.lblPhiN.AutoSize = true;
            this.lblPhiN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhiN.Location = new System.Drawing.Point(19, 47);
            this.lblPhiN.Name = "lblPhiN";
            this.lblPhiN.Size = new System.Drawing.Size(160, 19);
            this.lblPhiN.TabIndex = 8;
            this.lblPhiN.Text = "(pA-1)*(pB-1)  (Φ(N)):";
            this.lblPhiN.Visible = false;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.Location = new System.Drawing.Point(155, 92);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(24, 19);
            this.lblE.TabIndex = 9;
            this.lblE.Text = "E:";
            this.lblE.Visible = false;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.Location = new System.Drawing.Point(153, 120);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(26, 19);
            this.lblD.TabIndex = 10;
            this.lblD.Text = "D:";
            this.lblD.Visible = false;
            // 
            // txtPrimeA
            // 
            this.txtPrimeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimeA.Location = new System.Drawing.Point(607, 24);
            this.txtPrimeA.Name = "txtPrimeA";
            this.txtPrimeA.Size = new System.Drawing.Size(150, 22);
            this.txtPrimeA.TabIndex = 11;
            // 
            // txtPrimeB
            // 
            this.txtPrimeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimeB.Location = new System.Drawing.Point(607, 50);
            this.txtPrimeB.Name = "txtPrimeB";
            this.txtPrimeB.Size = new System.Drawing.Size(150, 22);
            this.txtPrimeB.TabIndex = 12;
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(185, 19);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(174, 22);
            this.txtN.TabIndex = 13;
            this.txtN.Visible = false;
            // 
            // txtPhiN
            // 
            this.txtPhiN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhiN.Location = new System.Drawing.Point(185, 48);
            this.txtPhiN.Name = "txtPhiN";
            this.txtPhiN.Size = new System.Drawing.Size(174, 22);
            this.txtPhiN.TabIndex = 14;
            this.txtPhiN.Visible = false;
            // 
            // txtE
            // 
            this.txtE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE.Location = new System.Drawing.Point(185, 92);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(174, 22);
            this.txtE.TabIndex = 15;
            this.txtE.Visible = false;
            // 
            // txtD
            // 
            this.txtD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD.Location = new System.Drawing.Point(185, 120);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(174, 22);
            this.txtD.TabIndex = 16;
            this.txtD.Visible = false;
            // 
            // btnGenPrimes
            // 
            this.btnGenPrimes.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenPrimes.Location = new System.Drawing.Point(763, 28);
            this.btnGenPrimes.Name = "btnGenPrimes";
            this.btnGenPrimes.Size = new System.Drawing.Size(141, 42);
            this.btnGenPrimes.TabIndex = 17;
            this.btnGenPrimes.Text = "Generate Primes";
            this.btnGenPrimes.UseVisualStyleBackColor = true;
            this.btnGenPrimes.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEnterMsg
            // 
            this.lblEnterMsg.AutoSize = true;
            this.lblEnterMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterMsg.Location = new System.Drawing.Point(14, 3);
            this.lblEnterMsg.Name = "lblEnterMsg";
            this.lblEnterMsg.Size = new System.Drawing.Size(148, 18);
            this.lblEnterMsg.TabIndex = 18;
            this.lblEnterMsg.Text = "Enter Message Here:";
            // 
            // lblEncryptMsg
            // 
            this.lblEncryptMsg.AutoSize = true;
            this.lblEncryptMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncryptMsg.Location = new System.Drawing.Point(14, 98);
            this.lblEncryptMsg.Name = "lblEncryptMsg";
            this.lblEncryptMsg.Size = new System.Drawing.Size(143, 18);
            this.lblEncryptMsg.TabIndex = 19;
            this.lblEncryptMsg.Text = "Encrypted Message:";
            // 
            // lblDecryptMsg
            // 
            this.lblDecryptMsg.AutoSize = true;
            this.lblDecryptMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecryptMsg.Location = new System.Drawing.Point(14, 201);
            this.lblDecryptMsg.Name = "lblDecryptMsg";
            this.lblDecryptMsg.Size = new System.Drawing.Size(144, 18);
            this.lblDecryptMsg.TabIndex = 20;
            this.lblDecryptMsg.Text = "Decrypted Message:";
            // 
            // lblEnterOwnPrime
            // 
            this.lblEnterOwnPrime.AutoSize = true;
            this.lblEnterOwnPrime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterOwnPrime.Location = new System.Drawing.Point(775, 73);
            this.lblEnterOwnPrime.Name = "lblEnterOwnPrime";
            this.lblEnterOwnPrime.Size = new System.Drawing.Size(117, 16);
            this.lblEnterOwnPrime.TabIndex = 21;
            this.lblEnterOwnPrime.Text = "(or enter your own)";
            // 
            // chckExtraInfo
            // 
            this.chckExtraInfo.AutoSize = true;
            this.chckExtraInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckExtraInfo.Location = new System.Drawing.Point(538, 125);
            this.chckExtraInfo.Name = "chckExtraInfo";
            this.chckExtraInfo.Size = new System.Drawing.Size(91, 20);
            this.chckExtraInfo.TabIndex = 22;
            this.chckExtraInfo.Text = "Extra Info";
            this.chckExtraInfo.UseVisualStyleBackColor = true;
            this.chckExtraInfo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // grpExtraInfo
            // 
            this.grpExtraInfo.Controls.Add(this.txtD);
            this.grpExtraInfo.Controls.Add(this.txtE);
            this.grpExtraInfo.Controls.Add(this.txtPhiN);
            this.grpExtraInfo.Controls.Add(this.txtN);
            this.grpExtraInfo.Controls.Add(this.lblD);
            this.grpExtraInfo.Controls.Add(this.lblE);
            this.grpExtraInfo.Controls.Add(this.lblPhiN);
            this.grpExtraInfo.Controls.Add(this.lblN);
            this.grpExtraInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpExtraInfo.Location = new System.Drawing.Point(537, 151);
            this.grpExtraInfo.Name = "grpExtraInfo";
            this.grpExtraInfo.Size = new System.Drawing.Size(376, 152);
            this.grpExtraInfo.TabIndex = 23;
            this.grpExtraInfo.TabStop = false;
            this.grpExtraInfo.Enter += new System.EventHandler(this.grpExtraInfo_Enter);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(988, 315);
            this.Controls.Add(this.grpExtraInfo);
            this.Controls.Add(this.chckExtraInfo);
            this.Controls.Add(this.lblEnterOwnPrime);
            this.Controls.Add(this.lblDecryptMsg);
            this.Controls.Add(this.lblEncryptMsg);
            this.Controls.Add(this.lblEnterMsg);
            this.Controls.Add(this.btnGenPrimes);
            this.Controls.Add(this.txtPrimeB);
            this.Controls.Add(this.txtPrimeA);
            this.Controls.Add(this.lblPrimeB);
            this.Controls.Add(this.lblPrimeA);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtEncryptedMsg);
            this.Controls.Add(this.txtDecryptedMsg);
            this.Controls.Add(this.txtOriginalMsg);
            this.Name = "Form1";
            this.Text = "RSA Encryption Demo";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.grpExtraInfo.ResumeLayout(false);
            this.grpExtraInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.TextBox txtInput;
        //private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtOriginalMsg;
        private System.Windows.Forms.TextBox txtDecryptedMsg;
        private System.Windows.Forms.TextBox txtEncryptedMsg;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblPrimeA;
        private System.Windows.Forms.Label lblPrimeB;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblPhiN;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.TextBox txtPrimeA;
        private System.Windows.Forms.TextBox txtPrimeB;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtPhiN;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Button btnGenPrimes;
        private System.Windows.Forms.Label lblEnterMsg;
        private System.Windows.Forms.Label lblEncryptMsg;
        private System.Windows.Forms.Label lblDecryptMsg;
        private System.Windows.Forms.Label lblEnterOwnPrime;
        private System.Windows.Forms.CheckBox chckExtraInfo;
        private System.Windows.Forms.GroupBox grpExtraInfo;
    }
}

