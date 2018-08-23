using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearConvert
{
    class Program
    {
        /*
         The foot to meter conversion formula is:
 	        m = f * 0.3048
 	
         The meter to foot conversion formula is:
 	        f = m * 3.2808399
 	
         Write a command line program which prompts a user to enter a length, and whether the measurement is in (m)eters or (f)eet.
         Convert the length to the opposite measurement, and display the old and new measurements to the console.
  
         C:\Users> LinearConvert
         Please enter the length: 58
         Is the measurement in (m)eter, or (f)eet? f
         58f is 17m.
         */

        static void Main(string[] args)
        {
            double inputLength;
            char charMF;

            Console.Write("Please enter the length: ");
            inputLength = double.Parse(Console.ReadLine());
            Console.Write("Is the length in (m)eters, or (f)eet? ");
            charMF = char.Parse(Console.ReadLine());

            if (charMF == 'm' || charMF == 'M')
            {
                Console.WriteLine(inputLength + "m is " + ConvertMToF(inputLength) + "ft");
            }
            else if (charMF == 'F' || charMF == 'f')
            {
                Console.WriteLine(inputLength + "ft is " + ConvertFToM(inputLength) + "m");
            }
        }

        static double ConvertMToF(double mLength)
        {
            // Tc = (Tf - 32) / 1.8
            double fLength;

            fLength = mLength * 3.2808399;

            return fLength;
        }

        static double ConvertFToM(double fLength)
        {
            // Tf = Tc * 1.8 + 32
            double mLength;

            mLength = fLength * 0.3048;

            return mLength;
        }
    }
}
