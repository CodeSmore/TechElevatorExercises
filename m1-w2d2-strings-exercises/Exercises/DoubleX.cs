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
         Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
         doubleX("axxbb") → true
         doubleX("axaxax") → false
         doubleX("xxxxx") → true
         */
        public bool DoubleX(string str)
        {
            int xIndex;

            xIndex = str.IndexOf('x');

            if (xIndex + 1 < str.Length)
            {
                if (str[xIndex + 1] == 'x')
                {
                    return true;
                }
            }

            return false;
        }
    }
}
