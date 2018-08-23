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
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").  
         * 
         * The animal name should be case insensitive so "elephant", "Elephant", and 
         * "ELEPHANT" should all return "herd". 
         * 
         * If the name of the animal is not found, null, or empty, return "unknown". 
         * 
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * animalGroupName("giraffe") → "Tower"
         * animalGroupName("") -> "unknown"         
         * animalGroupName("walrus") -> "unknown"
         * animalGroupName("Rhino") -> "Crash"
         * animalGroupName("rhino") -> "Crash"
         * animalGroupName("elephants") -> "unknown"
         * 
         */
        public string AnimalGroupName(string animalName)
        {
            Dictionary<string, string> animalGroupNames = new Dictionary<string, string>()
            {
                // C
                { "CROCODILE", "Float" },
                { "CROW", "Murder" },

                // D
                { "DEER", "Herd" },
                { "DOG", "Pack" },

                // E
                { "ELEPHANT", "Herd" },

                // F
                { "FLAMINGO", "Pat" },

                // G
                { "GIRAFFE", "Tower" },

                // L
                { "LION", "Pride" },

                // P
                { "PIDGEON", "Kit" },

                // R
                { "RHINO", "Crash" } 
            };

            string result;

            if (animalGroupNames.ContainsKey(animalName.ToUpper()))
            {
                result = animalGroupNames[animalName.ToUpper()];
            }
            else
            {
                result = "unknown";
            }

            return result;
        }
    }
}
