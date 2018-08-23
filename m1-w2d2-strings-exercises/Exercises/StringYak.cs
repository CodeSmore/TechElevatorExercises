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
         Suppose the string "yak" is unlucky. Given a string, return a version where all the "yak" are removed, but 
         the "a" can be any char. The "yak" strings will not overlap.
         stringYak("yakpak") → "pak"
         stringYak("pakyak") → "pak"
         stringYak("yak123ya") → "123ya"
         */
        public string StringYak(string str)
        {
            string result = str;

            for (int i = 0; i < result.Length - 2; ++i)
            {
                if (result.Substring(i, 3) == "yak")
                {
                    result = result.Remove(i, 3);
                    --i;
                }
            }

            return result;
        }
    }
}
