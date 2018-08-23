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
         Given a list of Strings, return an array containing the same Strings in the same order 
         list2Array( ["Apple", "Orange", "Banana"] )  ->  {"Apple", "Orange", "Banana"}
         list2Array( ["Red", "Orange", "Yellow"] )  ->  {"Red", "Orange", "Yellow"}
         list2Array( ["Left", "Right", "Forward", "Back"] )  ->  {"Left", "Right", "Forward", "Back"}
         */
        public string[] List2Array(List<string> stringList)
        {
            string[] resultArray = new string[stringList.Count];

            for (int i = 0; i < resultArray.Length; ++i)
            {
                resultArray[i] = stringList[i];
            }

            return resultArray;
        }
    }
}
