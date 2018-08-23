using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for the search string
            //2. Ask the user for the file path
            //3. Open the file
            //4. Loop through each line in the file
            //5. If the line contains the search string, print it out along with its line number

            Console.Write("Gimme the search string: ");
            string searchString = Console.ReadLine();
            Console.Write("You want the search to be case insensitive? (y/n)");
            string caseInsensitiveChar = Console.ReadLine();
            Console.Write("Now, gimme the file path: ");
            string filePath = Console.ReadLine();


            //filePath = "C:\\\\Users\\pkirk\\,Repos\\peterkirk-c-exercises\\m1-w4d2-file-io-part1-exercises\\alices_adventures_in_wonderland.txt";
            

            int lineCounter = 1;

            using (StreamReader sr = new StreamReader(filePath))
            {
                // Read the file until the end of the stream is reached
                // EndOfStream is a "marker" that the stream uses to determine 
                // if it has reached the end
                // As we read forward the marker moves forward like a typewriter.
                while (!sr.EndOfStream)
                {
                    // Read in the line
                    string line = sr.ReadLine();

                    if (line.ToUpper().Contains(searchString.ToUpper()) && caseInsensitiveChar == "y")
                    {
                        Console.WriteLine(lineCounter + ") " + line);
                    }

                    if (line.Contains(searchString) && caseInsensitiveChar == "n")
                    {
                        Console.WriteLine(lineCounter + ") " + line);
                    }
                    lineCounter++;
                }
            }
            Console.ReadLine();
        }
    }
}
