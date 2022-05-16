using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class FirstMissingPositive
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            FirstMissingPositive missingNo = new FirstMissingPositive();
            var result = missingNo.FindFirstMissingPositiveNo(input);
            Console.WriteLine(result);
        }

        private int FindFirstMissingPositiveNo(int[] nums)
        {
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] <=0 || nums[i] > n)
                    nums[i] = n + 1;
            }

            for (int i = 0; i<n; i++)
            {
                int num = Math.Abs(nums[i]);
                if (num > n)
                    continue;
                num--;
                if(nums[num]>0)
                    nums[num] = -1 * nums[num];
            }

            for (int i = 0; i < n; i++)
            {
                if (nums[i] >= 0)
                    return i + 1;
            }
            return n + 1;
        }
    }
}
