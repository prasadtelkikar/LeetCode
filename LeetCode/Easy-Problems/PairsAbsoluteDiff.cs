using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class PairsAbsoluteDiff
    {
        public static void Main(string[] args)
        {
            var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var k = int.Parse(Console.ReadLine());
            var result = CountKDifference(nums, k);
            Console.WriteLine(result);
        }

        private static object CountKDifference(int[] nums, int k)
        {
            var count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var n1 = nums[i] + k;
                var n2 = nums[i] - k;
                var newArray = nums.Skip(i);

                var countn = newArray.Count(x => x == n1 || x == n2);

                count += countn;
            }
            return count;
        }
    }
}
