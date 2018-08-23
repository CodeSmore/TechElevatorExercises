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
         Given two lists of Integers, interleave them beginning with the first element in the first list followed
         by the first element of the second. Continue interleaving the elements until all elements have been interwoven.
         Return the new list. If the lists are of unequal lengths, simply attach the remaining elements of the longer
         list to the new list before returning it.
		 DIFFICULTY: HARD
         interleaveLists( [1, 2, 3], [4, 5, 6] )  ->  [1, 4, 2, 5, 3, 6]
         */
        public List<int> InterleaveLists(List<int> listOne, List<int> listTwo)
        {
            List<int> resultList = new List<int>();
            int loopLimit = 0, biggerListInt = 0;

            if (listOne.Count > listTwo.Count)
            {
                loopLimit = listTwo.Count;
                biggerListInt = 1;
            }
            else if (listOne.Count < listTwo.Count)
            {
                loopLimit = listOne.Count;
                biggerListInt = 2;
            }
            else
            {
                loopLimit = listOne.Count;
            }


            for (int i = 0; i < loopLimit; ++i)
            {
                resultList.Add(listOne[i]);
                resultList.Add(listTwo[i]);
            }

            if (biggerListInt == 2)
            {
                listTwo.RemoveRange(0, listOne.Count);
                resultList.AddRange(listTwo);
            }
            else if (biggerListInt == 1)
            {
                listOne.RemoveRange(0, listTwo.Count);
                resultList.AddRange(listOne);
            }

            return resultList;
        }
    }
}
