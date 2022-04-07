using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    internal class sockMerchantClass
    {
        public static int sockMerchant(int n, List<int> ar)
        {
            //how many pairs of socks are there
            int pairs = 0;
            //create a dictionary to store the number of socks
            Dictionary<int, int> sockDict = new Dictionary<int, int>();
            //loop through the array
            for (int i = 0; i < n; i++)
            {
                //if the number is already in the dictionary, add 1 to the value
                if (sockDict.ContainsKey(ar[i]))
                {
                    sockDict[ar[i]] += 1;
                }
                //if the number is not in the dictionary, add it to the dictionary with a value of 1
                else
                {
                    sockDict.Add(ar[i], 1);
                }
            }
            //loop through the dictionary
            foreach (KeyValuePair<int, int> pair in sockDict)
            {
                //if the value is greater than 1, add the value to the pairs variable
                if (pair.Value > 1)
                {
                    pairs += pair.Value / 2;
                }
            }
            return pairs;
        }
    }
}
