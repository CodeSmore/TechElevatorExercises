using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        /*
         The Fibonacci numbers are the integers in the following sequence:  
	        0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...
         By definition, the first two numbers in the Fibonacci sequence are 0 and 1, and each subsequent number is the sum of the previous two.
 
         Write a command line program which prompts the user for an integer value and display the Fibonacci sequence leading up to that number.
  
         C:\Users> Fiboncci
         Please enter the Fibonacci number: 25
         
         0, 1, 1, 2, 3, 5, 8, 13, 21
         */
        static void Main(string[] args)
        {
            int inputInt;

            Console.Write("Here's the deal; enter an integer, and I'll give you the Fibonacci sequence up to that number. Have at it: ");
            inputInt = int.Parse(Console.ReadLine());

            PrintFibonacciSequence(inputInt);
        }

        static void PrintFibonacciSequence(int endNum)
        {
            int currentFibNum = 1;
            int lastFibNumber = 0;

            if (endNum >= 0)
            {
                Console.Write(0);
            }
           
            while (currentFibNum < endNum)
            {
                

                Console.Write(", " + currentFibNum);

                int holderVar = currentFibNum;
                currentFibNum += lastFibNumber;
                lastFibNumber = holderVar;



                // THIS DIDN'T WORK ARRRRRRG!!!11!1!!
                //if (currentFibNum == 0)
                //{
                //    currentFibNum = 1;
                //    lastFibNumber = 0;
                //    Console.Write(", " + currentFibNum);
                //}
                //else
                //{
                //    Console.Write(", " + currentFibNum);
                //    currentFibNum += lastFibNumber;
                //}
            }

            Console.WriteLine();
        }
    }
}
