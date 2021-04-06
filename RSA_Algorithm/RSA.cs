using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_algorithm
{
    class RSA
    {

        private int p; //p prime skaičius
        private int q; //q prime skaičius
        private int N;  //q ir p sandauga

        private int fi; // funkcija fi(N)

        private int e; // eksponentės e reikšmė

        public int getN(int p, int q)
        {
            return N = p * q;
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

        bool isPrime(int num1)
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

    }
}
