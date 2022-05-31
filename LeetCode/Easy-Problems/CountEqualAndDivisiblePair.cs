using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class CountEqualAndDivisiblePair
    {
        public static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').ToArray();
            var k = int.Parse(Console.ReadLine());

            int result = CountPairs(nums, k);
        }

        private static int CountPairs(string[] nums, int k)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if(nums[i] == nums[j] && (i * j % 2 == 0))
                        count++;
                }
            }
            return count;
        }
    }
}
