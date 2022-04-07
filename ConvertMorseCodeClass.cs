using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    internal class ConvertMorseCodeClass
    {
        public static void ConvertToMorseCode(string input)
        {
            //dictionary of morse code
            Dictionary<char, string> morseCode = new Dictionary<char, string>()
            {
                {'a', ".-"},
                {'b', "-..."},
                {'c', "-.-."},
                {'d', "-.."},
                {'e', "."},
                {'f', "..-."},
                {'g', "--."},
                {'h', "...."},
                {'i', ".."},
                {'j', ".---"},
                {'k', "-.-"},
                {'l', ".-.."},
                {'m', "--"},
                {'n', "-."},
                {'o', "---"},
                {'p', ".--."},
                {'q', "--.-"},
                {'r', ".-."},
                {'s', "..."},
                {'t', "-"},
                {'u', "..-"},
                {'v', "...-"},
                {'w', ".--"},
                {'x', "-..-"},
                {'y', "-.--"},
                {'z', "--.."},
                {'1', ".----"},
                {'2', "..---"},
                {'3', "...--"},
                {'4', "....-"},
                {'5', "....."},
                {'6', "-...."},
                {'7', "--..."},
                {'8', "---.."},
                {'9', "----."},
                {'0', "-----"},
                {' ', "/"},
                {'.', ".-.-.-"},
                {',', "--..--"},
                {'?', "..--.."},
                {'\'', ".----."},
                {'!', "-.-.--"},
                {'/', "-..-."},
                {'(', "-.--."},
                {')', "-.--.-"},
                {'&', ".-..."},
                {':', "---..."},
                {';', "-.-.-."},
                {'=', "-...-"},
                {'+', ".-.-"}};

            //convert input to lowercase
            input = input.ToLower();

            //loop through input
            foreach (char c in input)
            {
                //if the character is in the dictionary
                if (morseCode.ContainsKey(c))
                {
                    //print the morse code
                    Console.Write(morseCode[c] + " ");
                }
                else
                {
                    //if the character is not in the dictionary
                    //print the character
                    Console.Write(c + " ");
                }
            }
            Console.WriteLine();
            
            
        }
        public static void ConvertToEnglish(string input)
        {
            //dictionary of morse code
            Dictionary<string, char> morseCode = new Dictionary<string, char>()
            {
                { ".-", 'a' },
                { "-...", 'b' },
                { "-.-.", 'c' },
                { "-..", 'd' },
                { ".", 'e' },
                { "..-.", 'f' },
                { "--.", 'g' },
                { "....", 'h' },
                { "..", 'i' },
                { ".---", 'j' },
                { "-.-", 'k' },
                { ".-..", 'l' },
                { "--", 'm' },
                { "-.", 'n' },
                { "---", 'o' },
                { ".--.", 'p' },
                { "--.-", 'q' },
                { ".-.", 'r' },
                { "...", 's' },
                { "-", 't' },
                { "..-", 'u' },
                { "...-", 'v' },
                { ".--", 'w' },
                { "-..-", 'x' },
                { "-.--", 'y' },
                { "--..", 'z' },
                { ".----", '1' },
                { "..---", '2' },
                { "...--", '3' },
                { "....-", '4' },
                { ".....", '5' },
                { "-....", '6' },
                { "--...", '7' },
                { "---..", '8' },
                { "----.", '9' },
                { "-----", '0' },
                { "/", ' ' },
                { ".-.-.-", '.' },
                { "--..--", ',' },
                { "..--..", '?' },
                { ".----.", '\'' },
                { "-.-.--", '!' },
                { "-..-.", '/' },
                { "-.--.", '(' },
                { "-.--.-", ')' },
                { ".-...", '&' },
                { "---...", ':' },
                { "-.-.-.", ';' },
            };

            //loop through input
            foreach (string s in input.Split(' '))
            {
                //if the character is in the dictionary
                if (morseCode.ContainsKey(s))
                {
                    //print the morse code
                    Console.Write(morseCode[s] + " ");
                }
                else
                {
                    //if the character is not in the dictionary
                    //print the character
                    Console.Write(s + " ");
                }
            }
            Console.WriteLine();
            
        }

    }
}
