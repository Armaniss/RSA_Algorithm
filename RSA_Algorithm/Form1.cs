using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA_Algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void bt_Encrypt_Click(object sender, EventArgs e)
        {
            RSA rsa = new RSA();
            int N = rsa.getN(Convert.ToInt32(tb_pValue.Text), Convert.ToInt32(tb_qValue.Text)); // part of public key
            int fi = rsa.GetFi(Convert.ToInt32(tb_pValue.Text), Convert.ToInt32(tb_qValue.Text));
            //int E = rsa.GetE(rsa.GetFi(Convert.ToInt32(tb_pValue.Text), Convert.ToInt32(tb_qValue.Text)));   // part of public key           
            int E = rsa.GetE(fi);
            //RSA.Cipher(tb_Text.ToString(), N, E);
            int d = rsa.computeD(E, fi);
            tb_Text.Text = RSA.Cipher(tb_Text.ToString(), N, E);


        }

        private void bt_Decrypt_Click(object sender, EventArgs e)
        {

        }
    }
}
