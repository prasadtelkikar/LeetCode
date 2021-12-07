using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class LuckyInteger
    {
        public static void Main(string[] args)
        {
            var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var result = FindLucky(arr);
            Console.WriteLine(result);
        }

        private static object FindLucky(int[] arr)
        {
            Dictionary<int, int> occurences = new Dictionary<int, int>();
            var result = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if(occurences.ContainsKey(arr[i]))
                    occurences[arr[i]]++;
                else
                    occurences.Add(arr[i], 1);
            }

            foreach (var kvp in occurences)
            {
                if (kvp.Key == kvp.Value)
                    result = Math.Max(result, kvp.Key);
            }

            return result;

        }
    }
}
