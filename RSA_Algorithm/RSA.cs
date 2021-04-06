using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace RSA_Algorithm
{
    class RSA
    {
        

        private int p; //p prime skaičius
        private int q; //q prime skaičius
        private int n;  //q ir p sandauga
        

        private int fi; // funkcija fi(N)

        private int e; // eksponentės e reikšmė
        private int d; // 

        

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
                if (coprime(i, fi) == true)
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
       
        public static string Cipher(string text,int N, int e)
        {
            char[] encrypted = text.ToCharArray();
            for (int i = 0; i < encrypted.Length; i++)
            {
                char letter = encrypted[i];
                //int intLetter = Convert.ToInt32(letter);
                //intLetter = (intLetter ^ N) % e;

                letter = (char)((letter ^ N)%e);

                if (letter > '~')
                {
                    letter = (char)(letter - 94);             
                }
                else if (letter < '!')  
                {
                    letter = (char)(letter + 94);              
                }

                encrypted[i] = letter;
            }

            return new string(encrypted);
        }
    }
}
