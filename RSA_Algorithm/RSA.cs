using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Numerics;

namespace RSA_Algorithm
{
    class RSA
    {
        

        private int p; //p prime skaičius
        private int q; //q prime skaičius
        private int n;  //q ir p sandauga
        

        private int fi; // funkcija fi(N)

        

        

        public int getN(int p, int q)
        {
            return n = p * q;
        }

        public int GetFi(int p, int q)
        {
            return fi = (p - 1) * (q - 1);
        }

        public int GetE(int fi)
        {
            for (int i = 2; i < fi; i++)
            {
                if (coprime(i, fi) == true && isPrime(i) == true && i != p && i != q && i != fi)
                {
                    return i;
                    
                }
            }
            return 0;
        }

        static int GCD(int a, int b)
        {
            int Remainder;

            while (b != 0)
            {
                Remainder = a % b;
                a = b;
                b = Remainder;
            }

            return a;
        }

        public bool isPrime(int num1)
        {
            if (num1 == 0 || num1 == 1)
            {
                return false;
            }
            else
            {
                for (int a = 2; a <= num1 / 2; a++)
                {
                    if (num1 % a == 0)
                    {
                        return false;
                    }

                }
                return true;
            }


        }

        static bool coprime(int a, int b)
        {

            if (GCD(a, b) == 1)
                return true;
            else
                return false;
        }

        public int computeD(int e, int fi)
        {
            for (int i = 1; i < 215458575; i++)
            {
                if ((i * e) % fi == 1) { return i; }
            }
            return 0;
        }
        
        public int findD(int e, int fi)
        {
            return (2 * fi + 1) / e;
        }       

        static int modInverse(int a, int m)
        {

            for (int x = 1; x < m; x++)
                if (((a % m) * (x % m)) % m == 1)
                    return x;
            return 1;
        }     

        public string Cipher(string text, int p,int q)
        {
            RSA rsa = new RSA();
            
            
                List <int> ascii = new List<int>();
                foreach (char letter in text)
                {
                    ascii.Add(Convert.ToInt32(letter));
                }
                int N = rsa.getN(Convert.ToInt32(p), Convert.ToInt32(q)); // part of public key
                int fi = rsa.GetFi(Convert.ToInt32(p), Convert.ToInt32(q));                         
                int E = rsa.GetE(fi);                                     // part if public key

                string encripted = ""; 
                foreach (int i in ascii)
                {
                    encripted += (i^E)%N + " ";
                }
                encripted = encripted.Substring(0, encripted.Length - 1);

            return encripted;
            
              
        }

        public string DeCipher(string text, int N, int d)
        {
            RSA rsa = new RSA();

            string[] decryptedText = text.Split(' ');
            int[] encryptedText = new int[decryptedText.Length];

            for (int i = 0; i < decryptedText.Length; i++)
            {
                encryptedText[i] = Convert.ToInt32(decryptedText[i]);
            }

            char[] c = new char[encryptedText.Length];
            string result = "";
            
            for (int i = 0; i < encryptedText.Length; i++)
            {
                c[i] = (char)((encryptedText[i] ^ d) % N);
                //c[i] = (char)(Math.Pow(encryptedText[i], d) % N);
            }
            

            return new string(c);
        }

    }
}
