using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_Medium
{
    public class MatchsticksToSquare
    {
        public static void Main(string[] args)
        {
            int[] matchsticks = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isMatchStick = Makesquare(matchsticks);

        }

        private static bool Makesquare(int[] matchsticks)
        {
            Dictionary<int, int> kvp = new Dictionary<int, int>();
            foreach (int match in matchsticks)
            {
                if (kvp.ContainsKey(match))
                    kvp[match]++;
                else
                    kvp.Add(match, 1);
            }
            int count = 0;
            foreach (var value in kvp.Values)
            {
                if (value >= 2)
                    count++;
                if (count == 2)
                    return true;
            }
            return false;
        }
    }
}
