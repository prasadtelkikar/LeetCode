using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    /// <summary>
    /// https://leetcode.com/problems/missing-number/
    /// </summary>
    public class MissingNumber
    {
        public static void Main(string[] args)
        {
            var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int result = MissingNumberFunc(nums); 
            Console.WriteLine(result);
        }

        private static int MissingNumberFunc(int[] nums)
        {
            var result = 0;
            if(nums.Contains(nums.Length))
            {
                var length = nums.Length + 1;
                int[] store = new int[length];
                Array.Sort(nums);
                for (int i = 0; i < length; i++)
                {
                    if (nums[i] != i)
                    {
                        result = i;
                        break;
                    }
                }
            }
            else
                result = nums.Length;
            return result; 
        }
    }
}
