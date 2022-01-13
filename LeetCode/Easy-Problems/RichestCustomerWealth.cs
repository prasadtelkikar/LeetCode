using System;
using System.Linq;

namespace Easy_Problems
{
    public class RichestCustomerWealth
    {
        public static void Main(string[] args)
        {
            //int[,] inputMatrix = new int[,]
            //{
            //    new int[] { 2, 8, 7 },
            //    new int[] { 7, 1, 3 },
            //    new int[] { 1, 9, 5 }
            //};
            int[][] inputMatrix = new int[][]
            {
                new int[] { 1, 5 },
                new int[] { 7, 3 },
                new int[] { 3, 5 }
             };
            int result = GetMaxWealthByLinq(inputMatrix);

            Console.WriteLine(result);

        }

        private static int GetMaxWealth(int[][] accounts)
        {
            var maxWealth = int.MinValue;
            foreach (var account in accounts)
            {
                var sum = account.Sum();
                if(sum > maxWealth)
                    maxWealth = sum;
            }
            return maxWealth;
        }

        private static int GetMaxWealthTwoLoops(int[][] accounts)
        {
            var maxWealth = int.MinValue;
            for (int i = 0; i < accounts.Length; i++)
            {
                var sum = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    sum += accounts[i][j];
                }
                if (sum > maxWealth)
                    maxWealth= sum;
            }
            return maxWealth;
        }

        private static int GetMaxWealthByLinq(int[][] accounts)
        {
            var result = accounts.Select(x => x.Sum()).Max();
            return result;
        }
    }
}
