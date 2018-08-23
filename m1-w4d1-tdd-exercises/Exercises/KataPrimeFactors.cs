using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    /* OPTIONAL */
    public class KataPrimeFactors
    {
        // WORKS IN TESTS 1-6
        public List<int> Factorize(int n)
        {
            List<int> resultList = new List<int>();
            List<int> factorList = new List<int>();
            // find all factors
            for (int i = 2; i <= n; ++i)
            {
                while (n % i == 0)
                {
                    resultList.Add(i);
                    n = n / i;
                }
            }
            return resultList;
        }
    
        
    }
}
