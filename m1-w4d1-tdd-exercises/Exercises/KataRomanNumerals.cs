using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataRomanNumerals
    {
        public string ConvertToRomanNumeral(int n)
        {
            string result = "";

            

            

            while (n >= 100)
            {
                result += "C";
                n -= 100;
            }
            while (n >= 50)
            {
                result += "L";
                n -= 50;
            }
            while (n >= 10)
            {
                result += "X";
                n -= 10;
            }
            while (n >= 5)
            {
                result += "V";
                n -= 5;
            }
            while (n >= 1)
            {
                result += "I";
                n -= 1;
            }

            if (result.Contains("IIII"))
            {
                result = result.Substring(0, result.Length - 4);
                result += "IV";
                // replace IIII w/ IV
            }
            if (result.Contains("VIV"))
            {
                result = result.Substring(0, result.Length - 3);
                result += "IX";
                // replace VIV w/ IX
            }
            if (result.Contains("XXXX"))
            {
                result = result.Substring(0, result.Length - 4);
                result += "XL";
            }
            if (result.Contains("LXL"))
            {
                result = result.Substring(0, result.Length - 3);
                result += "XC";
            }
            
            //else if (result.Contains(""))

            return result;
        }
    }
}
