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
using System.Data.SqlClient;

namespace RSA_Algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bt_Encrypt.Enabled = false;
        }

        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Arme6\source\repos\RSA_Algorithm\RSA_Algorithm\RSAdatabase.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con = new SqlConnection(ConnectionString);
        RSA rsa = new RSA();
        
        
        
        private void bt_Encrypt_Click(object sender, EventArgs e)
        {          
            tb_Text.Text = (rsa.Cipher(tb_Text.Text, BigInteger.Parse(tb_pValue.Text), BigInteger.Parse(tb_qValue.Text)));
            BigInteger N = rsa.getN(BigInteger.Parse(tb_pValue.Text), BigInteger.Parse(tb_qValue.Text)); // part of public key
            

            BigInteger fi = rsa.GetFi(BigInteger.Parse(tb_pValue.Text), BigInteger.Parse(tb_qValue.Text));
            BigInteger E = rsa.GetE(fi);
            Insert(tb_Text.Text, N, E);
        }
        
        private void bt_Decrypt_Click(object sender, EventArgs e)
        {          
            BigInteger N = BigInteger.Parse(tb_nValue.Text);
            BigInteger E = BigInteger.Parse(tb_eValue.Text);
            BigInteger p = 2;
            while(N%p > 0)
            {
                p++;
            }
            BigInteger q = (N / p);
            RSA.TryModInverse(E, rsa.GetFi(p, q), out BigInteger result);
            BigInteger d = result;
            
            tb_EncText.Text = (rsa.DeCipher(tb_Text.Text, N, d));
            
        }

        private void button1_Click(object sender, EventArgs e)   //Check button
        {
            string error = "";
            if (!rsa.isPrime(Convert.ToInt32(tb_pValue.Text))) { error += " P "; }
            if (!rsa.isPrime(Convert.ToInt32(tb_qValue.Text))) { error += " Q "; }
            if (error == "") { bt_Encrypt.Enabled = true; MessageBox.Show("OK"); }
            else MessageBox.Show(error += "Value(s) are incorrect");
        }

        public void Insert(string encryptedText, BigInteger N, BigInteger E)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " insert into DataForEncryption values('" + encryptedText + "','" + N + "','" + E + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("OK");           
        }
        
        public void TakeFromDB()
        {
            SqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select * from DataForEncryption where EncryptedResult = '" + tb_Text.Text + "'";
            cmd3.ExecuteNonQuery();
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            da3.Fill(dt3);
        }

        private void button2_Click(object sender, EventArgs e)   //Load From DB button
        {
            try { 
            con.Open();
            SqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select * from DataForEncryption where EncryptedResult = '" + tb_EncText.Text + "'";
            cmd3.ExecuteNonQuery();
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            da3.Fill(dt3);
            
            foreach (DataRow dr in dt3.Rows)
            {
                tb_nValue.Text = dr["NValue"].ToString();
                tb_eValue.Text = dr["EValue"].ToString();
            }
            con.Close();
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
