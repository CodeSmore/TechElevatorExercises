﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {


        /*
         Given 2 ints, a and b, return their sum. However, "teen" values in the range 13..19 inclusive, are 
         extra lucky. So if either value is a teen, just return 19.
         teenSum(3, 4) → 7
         teenSum(10, 13) → 19
         teenSum(13, 2) → 19
         */
        public int TeenSum(int a, int b)
        {
            int teenMin = 13, teenMax = 19;

            if ((a >= teenMin && a <= teenMax) || (b >= teenMin && b <= teenMax))
            {
                return 19;
            }

            return a + b;
        }
    }
}