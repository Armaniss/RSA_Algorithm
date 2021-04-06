using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace RSA_Algorithm
{
    class File
    {
        private string text;

        public void WriteFile(string text, string path)
        {
            if (!System.IO.File.Exists(path))
            {
                System.IO.File.Create(path);
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine(text);
                tw.Close();
            }
            else if (System.IO.File.Exists(path))
            {
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine(text);
                tw.Close();
            }
        }

        public string ReadFile(string path)
        {
            if (System.IO.File.Exists(path))
            {
                string textas = "";
                using (StreamReader sr = System.IO.File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        textas += s;
                    }
                }
                this.text = textas;
            }

            return text;
        }
    }
}
