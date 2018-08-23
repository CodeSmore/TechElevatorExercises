using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxLines;
            

            string directory = Environment.CurrentDirectory;
            string inputFile;
            string outputFile;
            string inputFullPath;
            string outputFullPath;

            //Console.WriteLine("What is the name of the input file? ");
            //inputFileName = Console.ReadLine();
            inputFile = "input.txt";
            outputFile = inputFile;

            inputFullPath = Path.Combine(directory, inputFile);

            Console.Write("Enter the lines of text (max) that " +
                "should be in each split file: ");
            maxLines = int.Parse(Console.ReadLine());

            using (StreamReader sr = new StreamReader(inputFullPath))
            {
                int totalLines = 0;
                int numOutputFiles;

                // counts the total number of lines in original file
                while (!sr.EndOfStream)
                {
                    sr.ReadLine();

                    totalLines++;
                }

                // RESETS THE STREAMREADER BACK TO POSITION 0
                sr.DiscardBufferedData();
                sr.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
                // If I didn't use this, I'd likely just have 2 reader 'using'
                // statements; one for counting, and one for writing


                numOutputFiles = totalLines / maxLines;

                if (totalLines % maxLines != 0)
                {
                    numOutputFiles++;
                }

                Console.WriteLine();
                Console.WriteLine("For a " + totalLines + " line input file " +
                    "\"" + inputFile + "\" this will produce " + numOutputFiles
                    + " output files.");

                int index = inputFile.IndexOf(".");
                Console.WriteLine("**GENERATING OUTPUT**");
                // create files and list each one in the output
                Console.ReadLine();

                for (int i = 1; i <= numOutputFiles; ++i)
                {
                    outputFile = inputFile.Substring(0, index) + "-" + i.ToString() + ".txt";
                    outputFullPath = Path.Combine(directory, outputFile);
                    using (StreamWriter sw = new StreamWriter(outputFullPath))
                    {
                        for (int j = 1; j <= maxLines && !sr.EndOfStream; ++j)
                        {
                            sw.WriteLine(sr.ReadLine());
                        }
                    }
                    Console.WriteLine("Generating " + outputFile);
                }

                Console.ReadLine();
            }
        }
    }
}
