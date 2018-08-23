using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        private string letterGrade;

        public int TotalMarks
        {
            get;
            set;
        }

        public int PossibleMarks
        {
            get;
            
        }

        public string SubmitterName
        {
            get;
            
        }

        public string LetterGrade
        {
            get
            {
                string result;
                int percentage = (int)((double)TotalMarks / PossibleMarks * 100);

                if (percentage >= 90)
                {
                    result = "A";
                }
                else if (percentage >= 80)
                {
                    result = "B";
                }
                else if (percentage >= 70)
                {
                    result = "C";
                }
                else if (percentage >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }

                return result;
            }

            
        }

        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            PossibleMarks = possibleMarks;
            SubmitterName = submitterName;
        }


    }
}
