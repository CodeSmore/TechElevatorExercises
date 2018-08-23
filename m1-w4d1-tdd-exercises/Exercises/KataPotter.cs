using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataPotter
    {
        public decimal GetCost(int[] books)
        {
            decimal result = 0;
            bool cartIsEmpty = false;

            int[] tempCart = new int[5];
            int[] purchaseGroups = new int[5] { 0,0,0,0,0 };

            for (int i = 0; i < books.Length; ++i)
            {
                tempCart[i] = books[i];
            }

            while (!cartIsEmpty)
            {
                int numInSet = 0;


                for (int i = 0; i < tempCart.Length; ++i)
                {
                    if (tempCart[i] > 0)
                    {
                        tempCart[i]--;
                        numInSet++;
                    }
                }

                if (numInSet == 0)
                {
                    cartIsEmpty = true;
                }
                else
                {
                    purchaseGroups[numInSet - 1]++;
                }
            }

            // 2 sets of 4 is cheaper than one 3 and one 5 sets
            while (purchaseGroups[4] > 0 && purchaseGroups[2] > 0)
            {
                purchaseGroups[3] += 2;
                purchaseGroups[2]--;
                purchaseGroups[4]--;
            }

            result = purchaseGroups[0] * 8 + purchaseGroups[1] * 8 * 2 * .95M
                + purchaseGroups[2] * 8 * 3 * 0.90M 
                + purchaseGroups[3] * 8 * 4 * 0.80M
                + purchaseGroups[4] * 8 * 5 * 0.75M;

            return result;
        }
    }
}
