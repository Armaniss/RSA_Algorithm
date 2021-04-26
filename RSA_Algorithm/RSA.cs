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

        private BigInteger p; //p prime skaičius
        private BigInteger q; //q prime skaičius

        public BigInteger getN(BigInteger p, BigInteger q)
        {
            BigInteger n;
            n = p * q;
            return n;
        }

        public BigInteger GetFi(BigInteger p, BigInteger q)
        {
            BigInteger fi;
            fi = (p - 1) * (q - 1);
            return fi;
        }

        public BigInteger GetE(BigInteger fi)
        {
            BigInteger e = 0;

            for(BigInteger i=2; i< fi; i++)
            {
                if (coprime(i, fi) == true && isPrime(i) == true && i != p && i != q && i != fi)
                {
                    e = i;
                    break;
                }
            }
            return e;
            
        }

        static BigInteger GCD(BigInteger a, BigInteger b)
        {
            int Remainder;

            while (b != 0)
            {
                Remainder = (int)(a % b);
                a = b;
                b = Remainder;
            }

            return a;
        }

        public bool isPrime(BigInteger num1)
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

        static bool coprime(BigInteger a, BigInteger b)
        {

            if (GCD(a, b) == 1)
                return true;
            else
                return false;
        }
       
        public static bool ModInverse(BigInteger number, BigInteger modulo, out BigInteger result)
        {
            if (number < 1) throw new ArgumentOutOfRangeException(nameof(number));
            if (modulo < 2) throw new ArgumentOutOfRangeException(nameof(modulo));
            BigInteger n = number;
            BigInteger m = modulo, v = 0, d = 1;
            while (n > 0)
            {
                BigInteger t = m / n, x = n;
                n = m % x;
                m = x;
                x = d;
                d = checked(v - t * x); 
                v = x;
            }
            result = v % modulo;
            if (result < 0) result += modulo;
            if ((long)number * result % modulo == 1L) return true;
            result = default;
            return false;
        }

        
        public string Cipher(string text, BigInteger p,BigInteger q)
        {
            RSA rsa = new RSA();
           
                List <int> ascii = new List<int>();
                foreach (char letter in text)
                {
                    ascii.Add(Convert.ToInt32(letter));
                }
                BigInteger N = rsa.getN(p, q);                                   // part of public key
                BigInteger fi = rsa.GetFi(p, q);                         
                BigInteger E = rsa.GetE(fi);                                     // part if public key

                string encripted = string.Empty; 
                foreach (int i in ascii)
                {                   
                    encripted += BigInteger.Pow(i, (int)E) % N + " ";
            }
                encripted = encripted.Substring(0, encripted.Length - 1);

            return encripted;
            
              
        }
        
        public string DeCipher(string text, BigInteger N, BigInteger d)
        {            
            string[] decText = text.Split(' ');
            BigInteger[] encText = new BigInteger[decText.Length];

            for(int i=0; i< decText.Length; i++)
            {
                BigInteger temp = 0;
                if(BigInteger.TryParse(decText[i], out temp))
                {
                    if (temp != 0)
                    {
                        encText[i] = BigInteger.Parse(decText[i]);
                    }
                }
            }
            
            char[] decrypted = new char[encText.Length];
            for(int i=0; i<encText.Length; i++)
            {
                decrypted[i] = (char)(BigInteger.Pow(encText[i],(int)d) % N);
                
            }
            return new string(decrypted);
        }

    }
}
