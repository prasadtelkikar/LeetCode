using System;
using System.Collections.Generic;
using System.Linq;

namespace Easy_Problems
{
    public class UniqueNumberOfOccurences
    {
        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isUnique = UniqueOccurrences(input);
            Console.WriteLine(isUnique ? "Yes" : "No");
        }

        private static bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            foreach (int i in arr)
            {
                if(keyValuePairs.ContainsKey(i))
                    keyValuePairs[i]++;
                else
                    keyValuePairs.Add(i, 0);
            }

            return keyValuePairs.Values.Count == keyValuePairs.Values.Distinct().Count();
        }
    }
}
