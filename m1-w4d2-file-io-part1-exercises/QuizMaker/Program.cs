using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<QuizQuestion> questionList = new List<QuizQuestion>();
            int correctAnswers = 0;
            QuizQuestion.PopulateQuiz(questionList);

            for (int i = 0; i < questionList.Count; ++i)
            {
                // Question...
                Console.WriteLine(questionList[i].Question);
                Console.WriteLine();

                string[] questions = questionList[i].Answers;

                // Answers...
                for (int j = 0; j < questions.Length; ++j)
                {
                    Console.WriteLine(1+j + ". " + questions[j]);
                }

                // Input
                Console.Write( "Answer: " );
                int answer = int.Parse(Console.ReadLine());

                // Compare
                // Manage count of correct answers
                // display result
                if (answer == questionList[i].CorrectAnswer)
                {
                    correctAnswers++;
                    Console.WriteLine("Correct!!");
                }
                else
                {
                    Console.WriteLine("...ahem...WRONG");
                }
                Console.WriteLine();
                // repeat
            }
            // display count of correct answers
            Console.WriteLine();
            Console.WriteLine("Correct Answers: " + correctAnswers);
            Console.Write("Press Enter to Exit Program...");
            Console.ReadLine();
        }
    }
}
