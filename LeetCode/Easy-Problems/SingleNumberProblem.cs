using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class SingleNumberProblem
    {
        public static void Main(string[] args)
        {
            var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int result = SingleNumber(nums);
        }

        private static int SingleNumber(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                    dict[num]++;
                else
                    dict.Add(num, 1);
            }
            var result = dict.Where(x => x.Value == 1).First();
            return result.Key;
        }

        //Math formula
        private static int SingleNumberFunc(int[] nums)
        {

            var expectedSum = 2 * (nums.Distinct().Sum());
            var actualSum = nums.Sum();
            return expectedSum - actualSum;
        }
    }
}
