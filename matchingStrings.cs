using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class matchingStrings
    {
        public static List<int> matchingString(List<string> strings, List<string> queries)
        {
            // Count the patters listed in queries in strings
            List<int> result = new List<int>();
            foreach (string query in queries)
            {
                int count = 0;
                foreach (string str in strings)
                {
                    if (str.StartsWith(query))
                    {
                        count++;
                    }
                }
                result.Add(count);
            }

            return result;
        }
    }
}
