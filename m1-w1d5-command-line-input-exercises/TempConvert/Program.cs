using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConvert
{
    class Program
    {
        /*
         The Fahrenheit to Celsius conversion formula is:
 	        Tc = (Tf - 32) / 1.8
 	        where 'Tc' is the temperature in Celsius, and 'Tf' is the temperature in Fahrenheit
 	
         The Celsius to Fahrenheit conversion formula is:
 	        Tf = Tc * 1.8 + 32
 	         
        Write a command line program which prompts a user to enter a temperature, and whether its in degrees (C)elsius or (F)arenheit.
        Convert the temperature to the opposite degrees, and display the old and new temperatures to the console.

         C:\Users> TempConvert
         Please enter the temperature: 58
         Is the temperature in (C)elcius, or (F)arenheit? F
         58F is 14C.
        
         */
        static void Main(string[] args)
        {
            double inputTemp;
            char charCF;

            Console.Write("Please enter the temperature: ");
            inputTemp = double.Parse(Console.ReadLine());
            Console.Write("Is the temperature in (C)elcius, or (f)arenheit? ");
            charCF = char.Parse(Console.ReadLine());

            if (charCF == 'C' || charCF == 'c')
            {
                Console.WriteLine(inputTemp + "C is " + ConvertCToF(inputTemp) + "F");
            }
            else if (charCF == 'F' || charCF == 'f')
            {
                Console.WriteLine(inputTemp + "F is " + ConvertFToC(inputTemp) + "C");
            }
        }

        static double ConvertFToC(double fTemp)
        {
            // Tc = (Tf - 32) / 1.8
            double cTemp;

            cTemp = (fTemp - 32) / 1.8;

            return cTemp;
        }

        static double ConvertCToF(double cTemp)
        {
            // Tf = Tc * 1.8 + 32
            double fTemp;

            fTemp = cTemp * 1.8 + 32;

            return fTemp;
        }
    }
}
