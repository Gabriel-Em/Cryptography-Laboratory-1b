using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Cifrul_Affine
{
    class Criptograf
    {
        private int n = 27;
        private int a;
        private int b;
        private Validator valid = new Validator();
        private char[] alfabetU = { ' ', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        private char[] alfabetL = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        
        public int KeyLoad()
        {
            if (File.Exists(@".\Key.txt"))
            {
                string[] lines = System.IO.File.ReadAllLines(@".\Key.txt"); //incarc toate liniile din fisier

                bool validate = valid.KeyValidate(lines);    //verific daca cheia e corecta

                if (validate == true)
                {
                    string[] temp;  // string temporar care primeste cheia din fisier

                    temp = lines[0].Split(' ');

                    a = Int32.Parse(temp[0]);
                    b = Int32.Parse(temp[1]);

                    return 1;
                }
                else
                    return -1;
            }
            else
                return 0;
        }

        public int getA()
        {
            return a;
        }

        public int getB()
        {
            return b;
        }

        private int getIndice(char litera)  // returneaza indicele unui simbol
        {
            for (int i = 0; i < n; i++)
            {
                if (alfabetL[i] == litera || alfabetU[i] == litera)
                    return i;
            }
            return 0;
        }

        private char getSimbol(int indice, bool upper)  // returneaza simbolul care are un anumit indice
        {
            if (upper == true)
                return alfabetU[indice];
            else
                return alfabetL[indice];
        }

        public string Encrypt(string text)
        {
            string encrypted = "";
            bool upper;

            for (int i = 0; i < text.Length; i++)
            {
                if(char.IsUpper(text[i]) == true)
                    upper = true;
                else
                    upper = false;

                encrypted = encrypted + getSimbol((a * getIndice(text[i]) + b) % n, upper);
            }
            
            return encrypted;
        }

        public string Decrypt(string text)
        {
            string decrypted = "";
            bool upper;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]) == true)
                    upper = true;
                else
                    upper = false;

                int a = getADecrypt();
                int b = getBDecrypt();

                decrypted = decrypted + getSimbol((a * getIndice(text[i]) + b) % n, upper);
            }

            return decrypted;
        }

        private int getADecrypt()
        {
            int x = 1;

            while ((x * a) % n != 1)
            {
                x++;
            }

            return x;
        }

        private int getBDecrypt()
        {
            int x = getADecrypt() * -b;

            while (x < 0)
                x += n;

            return x;
        }

    }
}
