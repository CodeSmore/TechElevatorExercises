using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuizMaker
{
    public class QuizQuestion
    {
        public string Question { get; private set; }
        public string[] Answers { get; private set; }
        public int CorrectAnswer { get; private set; }

        public QuizQuestion(string question, string[] options, int answer)
        {
            Question = question;

            Answers = options;
            CorrectAnswer = answer;
        }



        public static void PopulateQuiz(List<QuizQuestion> questionList)
        {
            // pull questions from file, populate listy-list
            string fileName = "quiz-file.txt";
            string directory = Directory.GetCurrentDirectory();
            string fullPath = Path.Combine(directory, fileName);

            using (StreamReader sr = new StreamReader(fullPath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    string[] substrings = line.Split('|');
                    string[] questionString = new string[4];
                    int correctAnswerSlot = 0;

                    for (int i = 1; i < substrings.Length; ++i)
                    {
                        if (substrings[i].Contains("*"))
                        {
                            substrings[i] = substrings[i].Remove(substrings[i].IndexOf('*'));
                            correctAnswerSlot = i;

                        }

                        questionString[i - 1] = substrings[i];
                    }

                    questionList.Add(new QuizQuestion(substrings[0], questionString, correctAnswerSlot));

                    //for (int i = 0; i < 5; ++i)
                    //{
                    //    int n = line.IndexOf("|");

                    //    question.Add()
                    //}
                }
            }
            
        }
    }
}
