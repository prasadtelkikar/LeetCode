using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class TwoSum
    {
        public static void Main(string[] args)
        {
            var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var target = int.Parse(Console.ReadLine());

            TwoSum ts = new TwoSum();
            var result = ts.TwoSumFun(nums, target);
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }

        public int[] TwoSumFun(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                var secondNumber = target - nums[i];
                var secondNumberIndex = Array.IndexOf(nums, secondNumber);
                if (i == secondNumberIndex)
                    continue;
                if (secondNumberIndex != -1)
                {
                    result[0] = i;
                    result[1] = secondNumberIndex;
                    return result;
                }
            }
            return result;
        }
    }
}
