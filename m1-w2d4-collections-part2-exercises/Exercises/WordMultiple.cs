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
         * Given an array of strings, return a Dictionary<string, Boolean> where each different string is a key and value
         * is true only if that string appears 2 or more times in the array.
         * 
         * wordMultiple(["a", "b", "a", "c", "b"]) → {"b": true, "c": false, "a": true}
         * wordMultiple(["c", "b", "a"]) → {"b": false, "c": false, "a": false}
         * wordMultiple(["c", "c", "c", "c"]) → {"c": true}
         * 
         */
        public Dictionary<string, bool> WordMultiple(string[] words)
        {
            Dictionary<string, bool> resultDic = new Dictionary<string, bool>();

            Dictionary<string, int> countDic = WordCount(words); // was able to use method from other example!!

            foreach (KeyValuePair<string, int> kvp in countDic)
            {
                if (kvp.Value > 1)
                {
                    resultDic[kvp.Key] = true;
                }
                else
                {
                    resultDic[kvp.Key] = false;
                }
            }

            return resultDic;
        }

        //public Dictionary<string, int> WordCount(string[] words)
        //{
        //    Dictionary<string, int> resultDic = new Dictionary<string, int>();

        //    for (int i = 0; i < words.Length; ++i)
        //    {
        //        if (resultDic.ContainsKey(words[i]))
        //        {
        //            resultDic[words[i]]++;
        //        }
        //        else
        //        {
        //            resultDic[words[i]] = 1;
        //        }
        //    }


        //    return resultDic;
        //}
    }
}
