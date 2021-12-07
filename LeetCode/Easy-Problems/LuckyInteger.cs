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
            var result = FindLuckyLinqFunc2(arr);
            Console.WriteLine(result);
        }

        private static int FindLucky(int[] arr)
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
        public static int FindLuckyLinqFunc1(int[] arr)
        {
            var occurences = arr
            .GroupBy(x => x)
            .Select(x => new { Index = x.Key, Count = x.Count() })
            .Where(x => x.Index == x.Count);

            return occurences.Any() ? occurences.OrderByDescending(x => x.Index).First().Index : -1;
        }

        //Removed extra select clause
        public static int FindLuckyLinqFunc2(int[] arr)
        {
            var occurences = arr
                .GroupBy(x => x)
                .Where(x => x.Key == x.Count());

            return occurences.Any() ?
                occurences.OrderByDescending(x => x.Key).First().Key : -1;
        }
    }
}
