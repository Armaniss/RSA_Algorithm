using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Numerics;
namespace RSA_Algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        RSA rsa = new RSA();
        
        
        
        private void bt_Encrypt_Click(object sender, EventArgs e)
        {
            
            int N = rsa.getN(Convert.ToInt32(tb_pValue.Text), Convert.ToInt32(tb_qValue.Text)); // part of public key
            int fi = rsa.GetFi(Convert.ToInt32(tb_pValue.Text), Convert.ToInt32(tb_qValue.Text));
                    
            int E = rsa.GetE(fi);                                                               // part of public key   
            int d = rsa.computeD(E, fi);
            
            tb_Text.Text = (rsa.Cipher(tb_Text.Text, Convert.ToInt32(tb_pValue.Text), Convert.ToInt32(tb_qValue.Text)));



        }
        
        private void bt_Decrypt_Click(object sender, EventArgs e)
        {
            int N = rsa.getN(Convert.ToInt32(tb_pValue.Text), Convert.ToInt32(tb_qValue.Text)); // part of public key
            int fi = rsa.GetFi(Convert.ToInt32(tb_pValue.Text), Convert.ToInt32(tb_qValue.Text));                 
            int E = rsa.GetE(fi);         // part of public key   
            int d = rsa.computeD(E, fi);

            tb_Text.Text = (rsa.DeCipher(tb_Text.Text, N, d));
            tb_Text.Text = (rsa.Cipher(tb_Text.Text, Convert.ToInt32(tb_pValue.Text), Convert.ToInt32(tb_qValue.Text)));
            tb_Text.Text = (rsa.DeCipher(tb_Text.Text, N, d));
        }
    }
}
