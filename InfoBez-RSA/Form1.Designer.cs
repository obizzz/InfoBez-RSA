﻿namespace InfoBez_RSA_App
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_P = new System.Windows.Forms.Label();
            this.textBox_P = new System.Windows.Forms.TextBox();
            this.button_GenerateP = new System.Windows.Forms.Button();
            this.label_Q = new System.Windows.Forms.Label();
            this.textBox_Q = new System.Windows.Forms.TextBox();
            this.button_GenerateQ = new System.Windows.Forms.Button();
            this.label_E = new System.Windows.Forms.Label();
            this.textBox_E = new System.Windows.Forms.TextBox();
            this.button_GenerateE = new System.Windows.Forms.Button();
            this.label_E_From = new System.Windows.Forms.Label();
            this.textBox_E_From = new System.Windows.Forms.TextBox();
            this.label_D = new System.Windows.Forms.Label();
            this.textBox_D = new System.Windows.Forms.TextBox();
            this.label_D_From = new System.Windows.Forms.Label();
            this.textBox_D_From = new System.Windows.Forms.TextBox();
            this.button_D_SetN = new System.Windows.Forms.Button();
            this.label_InputText = new System.Windows.Forms.Label();
            this.richTextBox_InputText = new System.Windows.Forms.RichTextBox();
            this.button_Encrypt = new System.Windows.Forms.Button();
            this.label_EncryptedText = new System.Windows.Forms.Label();
            this.richTextBox_EncryptedText = new System.Windows.Forms.RichTextBox();
            this.button_Decrypt = new System.Windows.Forms.Button();
            this.label_DecryptedText = new System.Windows.Forms.Label();
            this.richTextBox_DecryptedText = new System.Windows.Forms.RichTextBox();
            this.label_GeneratePrimeNumbers = new System.Windows.Forms.Label();
            this.label_GeneratePrimeNumbers_From = new System.Windows.Forms.Label();
            this.textBox_PrimeNumbers_From = new System.Windows.Forms.TextBox();
            this.label_GeneratePrimeNumbers_To = new System.Windows.Forms.Label();
            this.textBox_PrimeNumbers_To = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label_P
            // 
            this.label_P.AutoSize = true;
            this.label_P.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_P.Location = new System.Drawing.Point(30, 20);
            this.label_P.Name = "label_P";
            this.label_P.Size = new System.Drawing.Size(19, 18);
            this.label_P.TabIndex = 0;
            this.label_P.Text = "P";
            // 
            // textBox_P
            // 
            this.textBox_P.Location = new System.Drawing.Point(60, 20);
            this.textBox_P.Name = "textBox_P";
            this.textBox_P.Size = new System.Drawing.Size(300, 20);
            this.textBox_P.TabIndex = 1;
            // 
            // button_GenerateP
            // 
            this.button_GenerateP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_GenerateP.Location = new System.Drawing.Point(370, 18);
            this.button_GenerateP.Name = "button_GenerateP";
            this.button_GenerateP.Size = new System.Drawing.Size(75, 24);
            this.button_GenerateP.TabIndex = 2;
            this.button_GenerateP.Text = "Generate P";
            this.button_GenerateP.UseVisualStyleBackColor = true;
            this.button_GenerateP.Click += new System.EventHandler(this.button_GenerateP_Click);
            // 
            // label_Q
            // 
            this.label_Q.AutoSize = true;
            this.label_Q.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Q.Location = new System.Drawing.Point(30, 60);
            this.label_Q.Name = "label_Q";
            this.label_Q.Size = new System.Drawing.Size(20, 18);
            this.label_Q.TabIndex = 3;
            this.label_Q.Text = "Q";
            // 
            // textBox_Q
            // 
            this.textBox_Q.Location = new System.Drawing.Point(60, 60);
            this.textBox_Q.Name = "textBox_Q";
            this.textBox_Q.Size = new System.Drawing.Size(300, 20);
            this.textBox_Q.TabIndex = 4;
            // 
            // button_GenerateQ
            // 
            this.button_GenerateQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_GenerateQ.Location = new System.Drawing.Point(370, 58);
            this.button_GenerateQ.Name = "button_GenerateQ";
            this.button_GenerateQ.Size = new System.Drawing.Size(75, 24);
            this.button_GenerateQ.TabIndex = 5;
            this.button_GenerateQ.Text = "Generate Q";
            this.button_GenerateQ.UseVisualStyleBackColor = true;
            this.button_GenerateQ.Click += new System.EventHandler(this.button_GenerateQ_Click);
            // 
            // label_E
            // 
            this.label_E.AutoSize = true;
            this.label_E.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_E.Location = new System.Drawing.Point(30, 100);
            this.label_E.Name = "label_E";
            this.label_E.Size = new System.Drawing.Size(19, 18);
            this.label_E.TabIndex = 6;
            this.label_E.Text = "E";
            // 
            // textBox_E
            // 
            this.textBox_E.Location = new System.Drawing.Point(60, 100);
            this.textBox_E.Name = "textBox_E";
            this.textBox_E.Size = new System.Drawing.Size(300, 20);
            this.textBox_E.TabIndex = 7;
            // 
            // button_GenerateE
            // 
            this.button_GenerateE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_GenerateE.Location = new System.Drawing.Point(370, 98);
            this.button_GenerateE.Name = "button_GenerateE";
            this.button_GenerateE.Size = new System.Drawing.Size(75, 63);
            this.button_GenerateE.TabIndex = 8;
            this.button_GenerateE.Text = "Generate E and D";
            this.button_GenerateE.UseVisualStyleBackColor = true;
            this.button_GenerateE.Click += new System.EventHandler(this.button_GenerateE_Click);
            // 
            // label_E_From
            // 
            this.label_E_From.AutoSize = true;
            this.label_E_From.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_E_From.Location = new System.Drawing.Point(465, 100);
            this.label_E_From.Name = "label_E_From";
            this.label_E_From.Size = new System.Drawing.Size(49, 18);
            this.label_E_From.TabIndex = 9;
            this.label_E_From.Text = "From:";
            // 
            // textBox_E_From
            // 
            this.textBox_E_From.Location = new System.Drawing.Point(520, 100);
            this.textBox_E_From.Name = "textBox_E_From";
            this.textBox_E_From.Size = new System.Drawing.Size(190, 20);
            this.textBox_E_From.TabIndex = 10;
            // 
            // label_D
            // 
            this.label_D.AutoSize = true;
            this.label_D.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_D.Location = new System.Drawing.Point(30, 140);
            this.label_D.Name = "label_D";
            this.label_D.Size = new System.Drawing.Size(20, 18);
            this.label_D.TabIndex = 11;
            this.label_D.Text = "D";
            // 
            // textBox_D
            // 
            this.textBox_D.Location = new System.Drawing.Point(60, 140);
            this.textBox_D.Name = "textBox_D";
            this.textBox_D.Size = new System.Drawing.Size(300, 20);
            this.textBox_D.TabIndex = 12;
            // 
            // label_D_From
            // 
            this.label_D_From.AutoSize = true;
            this.label_D_From.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_D_From.Location = new System.Drawing.Point(465, 140);
            this.label_D_From.Name = "label_D_From";
            this.label_D_From.Size = new System.Drawing.Size(49, 18);
            this.label_D_From.TabIndex = 14;
            this.label_D_From.Text = "From:";
            // 
            // textBox_D_From
            // 
            this.textBox_D_From.Location = new System.Drawing.Point(520, 140);
            this.textBox_D_From.Name = "textBox_D_From";
            this.textBox_D_From.Size = new System.Drawing.Size(130, 20);
            this.textBox_D_From.TabIndex = 15;
            // 
            // button_D_SetN
            // 
            this.button_D_SetN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_D_SetN.Location = new System.Drawing.Point(660, 138);
            this.button_D_SetN.Name = "button_D_SetN";
            this.button_D_SetN.Size = new System.Drawing.Size(50, 23);
            this.button_D_SetN.TabIndex = 16;
            this.button_D_SetN.Text = "Set N";
            this.button_D_SetN.UseVisualStyleBackColor = true;
            this.button_D_SetN.Click += new System.EventHandler(this.button_D_SetN_Click);
            // 
            // label_InputText
            // 
            this.label_InputText.AutoSize = true;
            this.label_InputText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_InputText.Location = new System.Drawing.Point(30, 195);
            this.label_InputText.Name = "label_InputText";
            this.label_InputText.Size = new System.Drawing.Size(76, 18);
            this.label_InputText.TabIndex = 17;
            this.label_InputText.Text = "Input text: ";
            // 
            // richTextBox_InputText
            // 
            this.richTextBox_InputText.Location = new System.Drawing.Point(30, 220);
            this.richTextBox_InputText.Name = "richTextBox_InputText";
            this.richTextBox_InputText.Size = new System.Drawing.Size(600, 100);
            this.richTextBox_InputText.TabIndex = 18;
            this.richTextBox_InputText.Text = "";
            // 
            // button_Encrypt
            // 
            this.button_Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Encrypt.Location = new System.Drawing.Point(635, 220);
            this.button_Encrypt.Name = "button_Encrypt";
            this.button_Encrypt.Size = new System.Drawing.Size(75, 100);
            this.button_Encrypt.TabIndex = 19;
            this.button_Encrypt.Text = "Encrypt";
            this.button_Encrypt.UseVisualStyleBackColor = true;
            this.button_Encrypt.Click += new System.EventHandler(this.button_Encrypt_Click);
            // 
            // label_EncryptedText
            // 
            this.label_EncryptedText.AutoSize = true;
            this.label_EncryptedText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_EncryptedText.Location = new System.Drawing.Point(30, 335);
            this.label_EncryptedText.Name = "label_EncryptedText";
            this.label_EncryptedText.Size = new System.Drawing.Size(110, 18);
            this.label_EncryptedText.TabIndex = 20;
            this.label_EncryptedText.Text = "Encrypted text:";
            // 
            // richTextBox_EncryptedText
            // 
            this.richTextBox_EncryptedText.Location = new System.Drawing.Point(30, 360);
            this.richTextBox_EncryptedText.Name = "richTextBox_EncryptedText";
            this.richTextBox_EncryptedText.Size = new System.Drawing.Size(600, 100);
            this.richTextBox_EncryptedText.TabIndex = 21;
            this.richTextBox_EncryptedText.Text = "";
            // 
            // button_Decrypt
            // 
            this.button_Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Decrypt.Location = new System.Drawing.Point(635, 360);
            this.button_Decrypt.Name = "button_Decrypt";
            this.button_Decrypt.Size = new System.Drawing.Size(75, 100);
            this.button_Decrypt.TabIndex = 22;
            this.button_Decrypt.Text = "Decrypt";
            this.button_Decrypt.UseVisualStyleBackColor = true;
            this.button_Decrypt.Click += new System.EventHandler(this.button_Decrypt_Click);
            // 
            // label_DecryptedText
            // 
            this.label_DecryptedText.AutoSize = true;
            this.label_DecryptedText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_DecryptedText.Location = new System.Drawing.Point(30, 485);
            this.label_DecryptedText.Name = "label_DecryptedText";
            this.label_DecryptedText.Size = new System.Drawing.Size(112, 18);
            this.label_DecryptedText.TabIndex = 23;
            this.label_DecryptedText.Text = "Decrypted text:";
            // 
            // richTextBox_DecryptedText
            // 
            this.richTextBox_DecryptedText.Enabled = false;
            this.richTextBox_DecryptedText.Location = new System.Drawing.Point(30, 510);
            this.richTextBox_DecryptedText.Name = "richTextBox_DecryptedText";
            this.richTextBox_DecryptedText.Size = new System.Drawing.Size(680, 100);
            this.richTextBox_DecryptedText.TabIndex = 24;
            this.richTextBox_DecryptedText.Text = "";
            // 
            // label_GeneratePrimeNumbers
            // 
            this.label_GeneratePrimeNumbers.AutoSize = true;
            this.label_GeneratePrimeNumbers.BackColor = System.Drawing.Color.White;
            this.label_GeneratePrimeNumbers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_GeneratePrimeNumbers.Location = new System.Drawing.Point(500, 20);
            this.label_GeneratePrimeNumbers.Name = "label_GeneratePrimeNumbers";
            this.label_GeneratePrimeNumbers.Size = new System.Drawing.Size(185, 18);
            this.label_GeneratePrimeNumbers.TabIndex = 26;
            this.label_GeneratePrimeNumbers.Text = "Generate prime numbers:";
            // 
            // label_GeneratePrimeNumbers_From
            // 
            this.label_GeneratePrimeNumbers_From.AutoSize = true;
            this.label_GeneratePrimeNumbers_From.BackColor = System.Drawing.Color.White;
            this.label_GeneratePrimeNumbers_From.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_GeneratePrimeNumbers_From.Location = new System.Drawing.Point(470, 60);
            this.label_GeneratePrimeNumbers_From.Name = "label_GeneratePrimeNumbers_From";
            this.label_GeneratePrimeNumbers_From.Size = new System.Drawing.Size(42, 16);
            this.label_GeneratePrimeNumbers_From.TabIndex = 27;
            this.label_GeneratePrimeNumbers_From.Text = "From:";
            // 
            // textBox_PrimeNumbers_From
            // 
            this.textBox_PrimeNumbers_From.Location = new System.Drawing.Point(510, 60);
            this.textBox_PrimeNumbers_From.Name = "textBox_PrimeNumbers_From";
            this.textBox_PrimeNumbers_From.Size = new System.Drawing.Size(80, 20);
            this.textBox_PrimeNumbers_From.TabIndex = 28;
            this.textBox_PrimeNumbers_From.TextChanged += new System.EventHandler(this.textBox_PrimeNumbers_From_TextChanged);
            // 
            // label_GeneratePrimeNumbers_To
            // 
            this.label_GeneratePrimeNumbers_To.AutoSize = true;
            this.label_GeneratePrimeNumbers_To.BackColor = System.Drawing.Color.White;
            this.label_GeneratePrimeNumbers_To.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_GeneratePrimeNumbers_To.Location = new System.Drawing.Point(607, 60);
            this.label_GeneratePrimeNumbers_To.Name = "label_GeneratePrimeNumbers_To";
            this.label_GeneratePrimeNumbers_To.Size = new System.Drawing.Size(25, 16);
            this.label_GeneratePrimeNumbers_To.TabIndex = 29;
            this.label_GeneratePrimeNumbers_To.Text = "To:";
            // 
            // textBox_PrimeNumbers_To
            // 
            this.textBox_PrimeNumbers_To.Location = new System.Drawing.Point(630, 60);
            this.textBox_PrimeNumbers_To.Name = "textBox_PrimeNumbers_To";
            this.textBox_PrimeNumbers_To.Size = new System.Drawing.Size(80, 20);
            this.textBox_PrimeNumbers_To.TabIndex = 30;
            this.textBox_PrimeNumbers_To.TextChanged += new System.EventHandler(this.textBox_PrimeNumbers_To_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(465, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 82);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(734, 641);
            this.Controls.Add(this.textBox_PrimeNumbers_To);
            this.Controls.Add(this.label_GeneratePrimeNumbers_To);
            this.Controls.Add(this.textBox_PrimeNumbers_From);
            this.Controls.Add(this.label_GeneratePrimeNumbers_From);
            this.Controls.Add(this.label_GeneratePrimeNumbers);
            this.Controls.Add(this.richTextBox_DecryptedText);
            this.Controls.Add(this.label_DecryptedText);
            this.Controls.Add(this.button_Decrypt);
            this.Controls.Add(this.richTextBox_EncryptedText);
            this.Controls.Add(this.label_EncryptedText);
            this.Controls.Add(this.button_Encrypt);
            this.Controls.Add(this.richTextBox_InputText);
            this.Controls.Add(this.label_InputText);
            this.Controls.Add(this.button_D_SetN);
            this.Controls.Add(this.textBox_D_From);
            this.Controls.Add(this.label_D_From);
            this.Controls.Add(this.textBox_D);
            this.Controls.Add(this.label_D);
            this.Controls.Add(this.textBox_E_From);
            this.Controls.Add(this.label_E_From);
            this.Controls.Add(this.button_GenerateE);
            this.Controls.Add(this.textBox_E);
            this.Controls.Add(this.label_E);
            this.Controls.Add(this.button_GenerateQ);
            this.Controls.Add(this.textBox_Q);
            this.Controls.Add(this.label_Q);
            this.Controls.Add(this.button_GenerateP);
            this.Controls.Add(this.textBox_P);
            this.Controls.Add(this.label_P);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_P;
        private System.Windows.Forms.TextBox textBox_P;
        private System.Windows.Forms.Button button_GenerateP;
        private System.Windows.Forms.Label label_Q;
        private System.Windows.Forms.TextBox textBox_Q;
        private System.Windows.Forms.Button button_GenerateQ;
        private System.Windows.Forms.Label label_E;
        private System.Windows.Forms.TextBox textBox_E;
        private System.Windows.Forms.Button button_GenerateE;
        private System.Windows.Forms.Label label_E_From;
        private System.Windows.Forms.TextBox textBox_E_From;
        private System.Windows.Forms.Label label_D;
        private System.Windows.Forms.TextBox textBox_D;
        private System.Windows.Forms.Label label_D_From;
        private System.Windows.Forms.TextBox textBox_D_From;
        private System.Windows.Forms.Button button_D_SetN;
        private System.Windows.Forms.Label label_InputText;
        private System.Windows.Forms.RichTextBox richTextBox_InputText;
        private System.Windows.Forms.Button button_Encrypt;
        private System.Windows.Forms.Label label_EncryptedText;
        private System.Windows.Forms.RichTextBox richTextBox_EncryptedText;
        private System.Windows.Forms.Button button_Decrypt;
        private System.Windows.Forms.Label label_DecryptedText;
        private System.Windows.Forms.RichTextBox richTextBox_DecryptedText;
        private System.Windows.Forms.Label label_GeneratePrimeNumbers;
        private System.Windows.Forms.Label label_GeneratePrimeNumbers_From;
        private System.Windows.Forms.TextBox textBox_PrimeNumbers_From;
        private System.Windows.Forms.Label label_GeneratePrimeNumbers_To;
        private System.Windows.Forms.TextBox textBox_PrimeNumbers_To;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

