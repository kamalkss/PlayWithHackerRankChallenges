using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    internal class StringTheory
    {
        static public string Run(string p)
        {
            string combined_queries = "";
            //how many vowels and consonants
            
            int vowels = 0;
            int consonants = 0;
            foreach (char c in p.Replace(" ",""))
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                    c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }
            //reversed words order and reversed cases 
            string reversed_words = "";
            string reversed_cases = "";
            string[] words = p.Split(' ');
            //reverse words order
            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversed_words += words[i] + " ";
            }
            //reverse cases of reversed_words
            for (int i = 0; i < reversed_words.Length; i++)
            {
                if (reversed_words[i] >= 'a' && reversed_words[i] <= 'z')
                {
                    reversed_cases += (char)(reversed_words[i] - 32);
                }
                else if (reversed_words[i] >= 'A' && reversed_words[i] <= 'Z')
                {
                    reversed_cases += (char)(reversed_words[i] + 32);
                }
                else
                {
                    reversed_cases += reversed_words[i];
                }
            }
            reversed_cases = reversed_cases.Trim();
            //Every work seperate by dash
            string seperated_words = "";
            foreach (string word in words)
            {
                seperated_words += word + "-";
            }
            seperated_words = seperated_words.Remove(seperated_words.Length - 1);
            //insert "pv" before every vowel
            string pv_vowels = "";
            foreach (char c in p)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'||
                    c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    pv_vowels += "pv" + c;
                }
                else
                {
                    pv_vowels += c;
                }
            }
            //combine all queries
            combined_queries += vowels + " " + consonants + "::" +reversed_cases + "::" + seperated_words + "::" + pv_vowels;
            return combined_queries;
        }
    }
}
