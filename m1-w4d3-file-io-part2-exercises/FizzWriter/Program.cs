using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = Directory.GetCurrentDirectory();
            string fileName = "FizzBuzz.txt";
            string fullPath = Path.Combine(directory, fileName);

            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                string result;

                for (int i = 1; i <= 300; ++i)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        result = "FizzBuzz";
                    }
                    else if (i % 3 == 0)
                    {
                        result = "Fizz";
                    }
                    else if (i % 5 == 0)
                    {
                        result = "Buzz";
                    }
                    else
                    {
                        result = i.ToString();
                    }

                    // Write to file
                    sw.WriteLine(result);
                }
           
            }

            Console.ReadLine();
        }
    }
}
