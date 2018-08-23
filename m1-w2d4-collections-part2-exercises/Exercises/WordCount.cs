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
         * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the 
         * number of times that string appears in the array.
         * 
         * ** A CLASSIC **
         * 
         * wordCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
         * wordCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
         * wordCount([]) → {}
         * wordCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
         * 
         */
        public Dictionary<string, int> WordCount(string[] words)
        {
            Dictionary<string, int> resultDic = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; ++i)
            {
                if (resultDic.ContainsKey(words[i]))
                {
                    resultDic[words[i]]++;
                }
                else
                {
                    resultDic[words[i]] = 1;
                }
            }


            return resultDic;
        }
    }
}
