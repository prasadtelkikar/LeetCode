using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dream
{
    public class FruitIntoBaskets
    {
        public static void Main(string[] args)
        {
            int[] fruits = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            int result = TotalFruits(fruits);
            Console.WriteLine(result);
        }

        //Sliding window example: Implement without cheating
        private static int TotalFruits(int[] fruits)
        {
            Dictionary<int, int> fruitDict = new Dictionary<int, int>();
            for(int i = 0; i < fruits.Length; i++)
            {
                if(fruitDict.ContainsKey(fruits[i]))
                    fruitDict[fruits[i]]++;
                else
                    fruitDict.Add(fruits[i], 1);
            }


            var filteredData = fruitDict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x=> x.Value);
            var sum = filteredData.Take(2).Select(x => x.Value).Sum();
            return sum;
        }
    }
}
