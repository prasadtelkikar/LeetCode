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
            //int result1 = MissingNumberFunc1(nums);
            //int result2 = MissingNumberFunc3(nums);
            //int result3 = MissingNumberFunc3(nums);

            Console.WriteLine(result);
            //Console.WriteLine(result1);
        }

        //Brute-Force.
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

        //Missing number = (Sum of 0 - n) - (sum of input array)

        public static int MissingNumberFunc1(int[] nums)
        {
            var sumN = (nums.Length * (nums.Length + 1)) / 2;
            var sumNums = nums.Sum();
            return sumN - sumNums;
        }

        //Improved Solution, Thanks @i-siso
        public static int MissingNumberFunc2(int[] nums)
        {
            var numSums = 0;
            var actualSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                actualSum += i + 1;
                numSums += nums[i];
            }
            return actualSum - numSums;
        }

        //Simplified version of MissingNumbersFunc2
        public static int MissingNumberFunc3(int[] nums)
        {
            var result = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                result += (i + 1) - nums[i];
            }
            return result;
        }
    }
}
