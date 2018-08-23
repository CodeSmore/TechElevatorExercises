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
         * Modify and return the given Dictionary as follows: if "Peter" has $50 or more, AND "Paul" has $100 or more,
         * then create a new "PeterPaulPartnership" worth a combined contribution of a quarter of each partner's
         * current worth.
         * 
         * peterPaulPartnership({"Peter": 50000, "Paul": 100000}) → {"Peter": 37500, "Paul": 75000, "PeterPaulPartnership": 37500}
         * peterPaulPartnership({"Peter": 3333, "Paul": 1234567890}) → {"Peter": 3333, "Paul": 1234567890}
         * 
         */
        public Dictionary<string, int> PeterPaulPartnership(Dictionary<string, int> peterPaul)
        {
            Dictionary<string, int> resultDic = new Dictionary<string, int>();

            if (peterPaul["Peter"] >= 50000 && peterPaul["Paul"] >= 100000)
            {
                resultDic["Peter"] = (int)(peterPaul["Peter"] * 0.75);
                resultDic["Paul"] = (int)(peterPaul["Paul"] * 0.75);
                resultDic["PeterPaulPartnership"] = (int)((peterPaul["Peter"] * 0.25) + (peterPaul["Paul"] * 0.25));
            }
            else
            {
                resultDic = peterPaul;
            }

            return resultDic;
        }
    }
}
