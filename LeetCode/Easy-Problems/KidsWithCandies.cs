using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class KidsWithCandies
    {
        public static void Main(string[] args)
        {
            var candies = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var extraCandies = Convert.ToInt32(Console.ReadLine());

            bool[] result = FindKidsWithHighestCandies(candies, extraCandies);
            Console.WriteLine(string.Join(" ", result));
        }

        private static bool[] FindKidsWithHighestCandies(int[] candies, int extraCandies)
        {
            bool[] highestCandies = new bool[candies.Length];
            int maxCandies = candies.Max();
            for(int i = 0; i < candies.Length; i++)
            {
                highestCandies[i] = (candies[i]+extraCandies) >= maxCandies;
            }
            return highestCandies;
        }
        private static bool[] FindKidsWithHightestCandies(int[] candies, int extraCandies)
        {
            var maxCandieCount = candies.Max();
            return candies.Select(i => (i + extraCandies) > maxCandieCount).ToArray();
        }
    }
}
