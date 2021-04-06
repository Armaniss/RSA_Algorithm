namespace RSA_Algorithm
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
            this.bt_Decrypt = new System.Windows.Forms.Button();
            this.bt_Encrypt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_qValue = new System.Windows.Forms.TextBox();
            this.tb_pValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_Decrypt
            // 
            this.bt_Decrypt.Location = new System.Drawing.Point(263, 143);
            this.bt_Decrypt.Name = "bt_Decrypt";
            this.bt_Decrypt.Size = new System.Drawing.Size(75, 23);
            this.bt_Decrypt.TabIndex = 15;
            this.bt_Decrypt.Text = "Dešifruoti";
            this.bt_Decrypt.UseVisualStyleBackColor = true;
            this.bt_Decrypt.Click += new System.EventHandler(this.bt_Decrypt_Click);
            // 
            // bt_Encrypt
            // 
            this.bt_Encrypt.Location = new System.Drawing.Point(15, 143);
            this.bt_Encrypt.Name = "bt_Encrypt";
            this.bt_Encrypt.Size = new System.Drawing.Size(75, 23);
            this.bt_Encrypt.TabIndex = 14;
            this.bt_Encrypt.Text = "Užšifruoti";
            this.bt_Encrypt.UseVisualStyleBackColor = true;
            this.bt_Encrypt.Click += new System.EventHandler(this.bt_Encrypt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tekstas";
            // 
            // tb_Text
            // 
            this.tb_Text.Location = new System.Drawing.Point(15, 79);
            this.tb_Text.Multiline = true;
            this.tb_Text.Name = "tb_Text";
            this.tb_Text.Size = new System.Drawing.Size(323, 45);
            this.tb_Text.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Q reikšmė";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "P reikšmė";
            // 
            // tb_qValue
            // 
            this.tb_qValue.Location = new System.Drawing.Point(151, 28);
            this.tb_qValue.Name = "tb_qValue";
            this.tb_qValue.Size = new System.Drawing.Size(100, 20);
            this.tb_qValue.TabIndex = 9;
            // 
            // tb_pValue
            // 
            this.tb_pValue.Location = new System.Drawing.Point(15, 28);
            this.tb_pValue.Name = "tb_pValue";
            this.tb_pValue.Size = new System.Drawing.Size(100, 20);
            this.tb_pValue.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Decrypt);
            this.Controls.Add(this.bt_Encrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_qValue);
            this.Controls.Add(this.tb_pValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Decrypt;
        private System.Windows.Forms.Button bt_Encrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_qValue;
        private System.Windows.Forms.TextBox tb_pValue;
    }
}

