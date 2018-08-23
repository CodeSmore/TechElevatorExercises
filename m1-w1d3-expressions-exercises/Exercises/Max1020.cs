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
      Given 2 positive int values, return the larger value that is in the range 10..20 inclusive, 
      or return 0 if neither is in that range.
      max1020(11, 19) → 19
      max1020(19, 11) → 19
      max1020(11, 9) → 11
      */
        public int Max1020(int a, int b)
        {
            int largerNum = 0, rangeMin = 10, rangeMax = 20;

            if (!(a > rangeMin && a < rangeMax) && !(b > rangeMin && b < rangeMax))
            {
                largerNum = 0;
            }
            else if ((a > rangeMin && a < rangeMax))
            {
                if (b > rangeMin && b < rangeMax)
                {
                    if (a > b)
                    {
                        largerNum = a;
                    }
                    else
                    {
                        largerNum = b;
                    }
                }
                else
                {
                    largerNum = a;
                }

            }
            return largerNum;
        }

    }
}