using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cifrul_Affine
{
    class Validator
    {
        public bool KeyValidate(string[] lines)
        {
            bool valid = true;  // variabila care decide daca cheia e valida sau nu
            string[] temp;  // string temporar care primeste cheia din fisier
            bool result;    // decide daca cheia e un intreg sau nu
            int x;  //valoare necesara pentru int32.TryParse

            if (lines.Count() > 1)
                valid = false;
            else
            {
                temp = lines[0].Split(' ');

                if (temp.Count() != 2)
                    valid = false;
                else
                {
                    result = Int32.TryParse(temp[0], out x);
                    if (result == true)
                    {
                        if (cmmdc(Int32.Parse(temp[0]),27) == 1)
                        {
                            result = Int32.TryParse(temp[1], out x);

                            if (result == true)
                            {
                                if (Int32.Parse(temp[1]) > 0 && Int32.Parse(temp[1]) <= 1000)
                                    valid = true;
                                else
                                    valid = false;
                            }
                            else
                                valid = false;
                        }
                        else
                            valid = false;
                    }
                    else
                        valid = false;
                }
            }

            if (valid)
                return true;
            else
                return false;
        }


        private int cmmdc(int a, int b)
        {
            int r = a % b;
            while (r!=0)
            {
                a = b;
                b = r;
                r = a % b;
            }
            return b;
        }
    }

 

}
