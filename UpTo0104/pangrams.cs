using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.UpTo0104
{
    internal class pangrams
    {
        public static string pangram(string s)
        {
            // return "pangram" if s is a pangram, otherwise return "not pangram"
            s = s.ToLower();
            var alphabet = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            foreach (var letter in alphabet)
            {
                if (!s.Contains(letter))
                {
                    return "not pangram";
                }
            }
            return "pangram";

            //Permute an array
            //var arr = new List<int> { 1, 2, 3, 4, 5 };
            //var permutations = new List<List<int>>();
            //permute(arr, 0, permutations);
            //Console.WriteLine(string.Join(",", permutations));

        }
    }
}
