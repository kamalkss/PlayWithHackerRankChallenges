using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    internal class nonDivisibleSubsetClass
    {
        public static int nonDivisibleSubset(int k, List<int> s)
        {
            //List of all possible subsets of size 2
            List<List<int>> subsets = new List<List<int>>();
            for (int i = 0; i < s.Count; i++)
            {
                for (int j = i + 1; j < s.Count; j++)
                {
                    List<int> subset = new List<int>();
                    subset.Add(s[i]);
                    subset.Add(s[j]);
                    subsets.Add(subset);
                }
            }

            //make a list of the all sum of 2 digits in s 
            List<List<int>> sumOfTwoDigits = new List<List<int>>();
            Dictionary<int, int> SUm = new Dictionary<int, int>();
            Stack<int> CountOfelement = new Stack<int>();
            List<int> temp = new List<int>();
            for (int i = 0; i < s.Count; i++)
            {
                for (int j = i + 1; j < s.Count; j++)
                {
                    if ((s[i] + s[j]) % k != 0)
                    {
                        sumOfTwoDigits.Add(new List<int> { s[i], s[j] });
                        if (!SUm.ContainsKey(s[i]) && !SUm.ContainsValue(s[j]))
                            SUm.Add(s[i], s[j]);
                        if (!CountOfelement.Contains(s[i]))
                        {
                            CountOfelement.Push(s[i]);
                        }
                        if (!CountOfelement.Contains(s[j]))
                        {
                            CountOfelement.Push(s[j]);
                        }
                    }
                }
            }
            List<int> S1 = sumOfTwoDigits.Select(x => x[0]).ToList();
            S1 = S1.Distinct().ToList();
            //Make longest possible list of distinct numbers in sumOfTwoDigits
            List<int> distinctNumbers = new List<int>();
            for (int i = 0; i < SUm.Count; i++)
            {
                if (!distinctNumbers.Contains(SUm.ElementAt(i).Key))
                    distinctNumbers.Add(SUm.ElementAt(i).Key);
                if (!distinctNumbers.Contains(SUm.ElementAt(i).Value))
                    distinctNumbers.Add(SUm.ElementAt(i).Value);
            }
            
            distinctNumbers.Distinct();
            return distinctNumbers.Count;
        }
    }
}
