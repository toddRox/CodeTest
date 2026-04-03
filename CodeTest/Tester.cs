using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    public static class Tester
    {
        /// <summary>
        /// Function that take a string and returns true if the string is a palindrome
        /// </summary>
        /// <param name="input">string</param>
        /// <returns>bool</returns>
        public static bool IsPalindrome(string input)
        {
            return input == null ? false : string.Join("", input.Reverse()).Equals(input);
        }

        /// <summary>
        /// Function that takes a string and returns the count of each character in the string
        /// </summary>
        /// <param name="input">input string</param>
        /// <returns>Dictionary with each character from the string as the key and the count of each charter as the value</returns>
        public static Dictionary<char, int> CharacterCount(string input)
        {
            Dictionary<char, int> output = new Dictionary<char, int>();
            if(input == null) return output;

            foreach (char c in input)
            {
                output[c] =  output.GetValueOrDefault(c, 0) + 1;
            }

            return output;
        }


        /// <summary>
        /// Function that accepts two arrays of integers and returns an array of integers that are in both arrays.
        /// </summary>
        /// <param name="input1">an array of integers</param>
        /// <param name="input2">an array of integers</param>
        /// <returns>an array of integers</returns>
        public static int[] GetMatches(int[] input1, int[] input2)
        {
            if(input1 == null || input2 == null) throw new ArgumentException("Parameters cannot be null.");

            var set1 = new HashSet<int>(input1);
            var set2 = new HashSet<int>(input2);

            return set1.Intersect(set2).ToArray();
        }


        /// <summary>
        /// Function that accepts two arrays of integers and returns an array of integers that are not in both arrays.
        /// </summary>
        /// <param name="input1">an array of integers</param>
        /// <param name="input2">an array of integers</param>
        /// <returns>an array of integers</returns>
        public static int[] GetDiff(int[] input1, int[] input2)
        {
            if(input1 == null || input2 == null) throw new ArgumentException("Parameters cannot be null.");

            var set1 = new HashSet<int>(input1);
            var set2 = new HashSet<int>(input2);

            var diff1 = set1.Except(set2).ToArray();
            var diff2 = set2.Except(set1).ToArray();

            return diff1.Union(diff2).ToArray();
        }
    }
}
