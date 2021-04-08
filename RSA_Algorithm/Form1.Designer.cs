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
            this.button1 = new System.Windows.Forms.Button();
            this.tb_EncText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nValue = new System.Windows.Forms.TextBox();
            this.tb_eValue = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Decrypt
            // 
            this.bt_Decrypt.Location = new System.Drawing.Point(6, 139);
            this.bt_Decrypt.Name = "bt_Decrypt";
            this.bt_Decrypt.Size = new System.Drawing.Size(75, 23);
            this.bt_Decrypt.TabIndex = 15;
            this.bt_Decrypt.Text = "Dešifruoti";
            this.bt_Decrypt.UseVisualStyleBackColor = true;
            this.bt_Decrypt.Click += new System.EventHandler(this.bt_Decrypt_Click);
            // 
            // bt_Encrypt
            // 
            this.bt_Encrypt.Location = new System.Drawing.Point(6, 147);
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
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tekstas";
            // 
            // tb_Text
            // 
            this.tb_Text.Location = new System.Drawing.Point(6, 96);
            this.tb_Text.Multiline = true;
            this.tb_Text.Name = "tb_Text";
            this.tb_Text.Size = new System.Drawing.Size(323, 45);
            this.tb_Text.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Q reikšmė";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "P reikšmė";
            // 
            // tb_qValue
            // 
            this.tb_qValue.Location = new System.Drawing.Point(142, 45);
            this.tb_qValue.Name = "tb_qValue";
            this.tb_qValue.Size = new System.Drawing.Size(100, 20);
            this.tb_qValue.TabIndex = 9;
            this.tb_qValue.Text = "967";
            // 
            // tb_pValue
            // 
            this.tb_pValue.Location = new System.Drawing.Point(6, 45);
            this.tb_pValue.Name = "tb_pValue";
            this.tb_pValue.Size = new System.Drawing.Size(100, 20);
            this.tb_pValue.TabIndex = 8;
            this.tb_pValue.Text = "751";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 16;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_EncText
            // 
            this.tb_EncText.Location = new System.Drawing.Point(6, 88);
            this.tb_EncText.Multiline = true;
            this.tb_EncText.Name = "tb_EncText";
            this.tb_EncText.Size = new System.Drawing.Size(323, 45);
            this.tb_EncText.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "N reikšmė";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "E reikšmė";
            // 
            // tb_nValue
            // 
            this.tb_nValue.Location = new System.Drawing.Point(6, 44);
            this.tb_nValue.Name = "tb_nValue";
            this.tb_nValue.Size = new System.Drawing.Size(100, 20);
            this.tb_nValue.TabIndex = 20;
            // 
            // tb_eValue
            // 
            this.tb_eValue.Location = new System.Drawing.Point(139, 44);
            this.tb_eValue.Name = "tb_eValue";
            this.tb_eValue.Size = new System.Drawing.Size(100, 20);
            this.tb_eValue.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 22;
            this.button2.Text = "LoadDB";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tekstas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_pValue);
            this.panel1.Controls.Add(this.tb_qValue);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_Text);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bt_Encrypt);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 179);
            this.panel1.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Šifravimas";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tb_nValue);
            this.panel2.Controls.Add(this.bt_Decrypt);
            this.panel2.Controls.Add(this.tb_EncText);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tb_eValue);
            this.panel2.Location = new System.Drawing.Point(12, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 171);
            this.panel2.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Dešifravimas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_EncText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nValue;
        private System.Windows.Forms.TextBox tb_eValue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
    }
}

