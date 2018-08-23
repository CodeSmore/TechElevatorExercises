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
         Given a string, return the count of the number of times that a substring length 2 appears in the string and 
         also as the last 2 chars of the string, so "hixxxhi" yields 1 (we won't count the end substring).
         last2("hixxhi") → 1
         last2("xaxxaxaxx") → 1
         last2("axxxaaxx") → 2
         */
        public int Last2(string str)
        {
            // return the number of times 'count' the substring of 2 chars at the end of the string
            // appears elsewhere in the string
            
            int count = 0;

            if (str.Length > 2)
            {

                string last2Str = str.Substring(str.Length - 2);
                string testStr = str.Substring(0, str.Length - 1);

                for (int i = 0; i < testStr.Length - 1; ++i)
                {
                    if (testStr.Substring(i, 2) == last2Str)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
