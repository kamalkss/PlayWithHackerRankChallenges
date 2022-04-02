using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.UpTo0104
{
    internal class RomanNumber
    {
        static public string Run(int n)
        {
            //
            // Write your code below; return type and arguments should be according to the problem\'s requirements
            //


            string n_in_roman_alphabet = "";
            int[] roman_numbers = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] roman_alphabet = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            for (int i = 0; i < roman_numbers.Length; i++)
            {
                while (n >= roman_numbers[i])
                {
                    n_in_roman_alphabet += roman_alphabet[i];
                    n -= roman_numbers[i];
                }
            }

            return n_in_roman_alphabet;
        }
    }
}
