using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given 3 int values, a b c, return their sum. However, if one of the values is the same as another 
         of the values, it does not count towards the sum.
         loneSum(1, 2, 3) → 6
         loneSum(3, 2, 3) → 2
         loneSum(3, 3, 3) → 0
         */
        public int LoneSum(int a, int b, int c)
        {
            int sum = 0;

            if (a == b && a == c)
            {
                a = 0;
                b = 0;
                c = 0;
            }

            if (a == b)
            {
                a = 0;
                b = 0;
            }

            if (a == c)
            {
                a = 0;
                c = 0;
            }

            if (b == c)
            {
                b = 0;
                c = 0;
            }

            sum = a + b + c;
            return sum;
        }

    }
}
