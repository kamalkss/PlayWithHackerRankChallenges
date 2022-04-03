using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    internal class missingNumbersClass
    {
        public static List<int> missingNumbers(List<int> arr, List<int> brr)
        {
            List<int> Missing = new List<int>();
            brr.Sort();
            foreach (var i in brr)
            {
                if (arr.Contains(i))
                {
                    arr.Remove(i);
                }
                else
                {
                    Missing.Add(i);
                }
            }
            Missing.Sort();
            return Missing;
        }
    }
}
