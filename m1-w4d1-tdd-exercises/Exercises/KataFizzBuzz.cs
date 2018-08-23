using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataFizzBuzz
    {
        public string FizzBuzz(int n)
        {
            string result = "";
            bool hasThree = false;
            bool hasFive = false;
            int extraN = n;

            
            if (n > 10)
            {
                if (n / 10 == 3)
                {
                    hasThree = true;
                }
                if (n / 10 == 5)
                {
                    hasFive = true;
                }
            }

            if (n % 10 == 3)
            {
                hasThree = true;
            }
            if (n % 10 == 5)
            {
                hasFive = true;
            }

            

            if (n <= 0 || n > 100)
            {
                result = "Invalid";
            }
            else if ((n % 3 == 0 || hasThree) && (n % 5 == 0 || hasFive))
            {
                result = "FizzBuzz";
            }
            else if (n % 3 == 0 || hasThree)
            {
                result = "Fizz";
            }
            else if (n % 5 == 0 || hasFive)
            {
                result = "Buzz";
            }
            else
            {
                result = n.ToString();
            }

            return result;
        }
    }
}
