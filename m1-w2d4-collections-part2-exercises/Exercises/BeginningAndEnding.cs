﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of non-empty strings, return a Dictionary<string, string> where for every different string in the array, 
         * there is a key of its first character with the value of its last character.
         *
         * beginningAndEnding(["code", "bug"]) → {"b": "g", "c": "e"}
         * beginningAndEnding(["man", "moon", "main"]) → {"m": "n"}
         * beginningAndEnding(["muddy", "good", "moat", "good", "night"]) → {"g": "d", "m": "t", "n": "t"}
         */
        public Dictionary<string, string> BeginningAndEnding(string[] words)
        {
            Dictionary<string, string> resultDictionary = new Dictionary<string, string>();

            for (int i = 0; i < words.Length; ++i)
            {
                resultDictionary[words[i].Substring(0, 1)] = words[i].Substring(words[i].Length - 1);
            }

            return resultDictionary;
        }
    }
}
