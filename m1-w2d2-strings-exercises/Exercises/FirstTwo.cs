using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return the string made of its first two chars, so the string "Hello" yields "He". If the 
         string is shorter than length 2, return whatever there is, so "X" yields "X", and the empty string "" 
         yields the empty string "". Note that str.length() returns the length of a string.
         firstTwo("Hello") → "He"
         firstTwo("abcdefg") → "ab"
         firstTwo("ab") → "ab"
         */
        public string FirstTwo(string str)
        {
            string resultStr;

            if (str.Length == 0)
            {
                resultStr = "";
            }
            else if (str.Length == 1)
            {
                resultStr = str.Substring(0, 1);
            }
            else
            {
                resultStr = str.Substring(0, 2);
            }

            return resultStr;
        }
    }
}
