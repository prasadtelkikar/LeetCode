using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class ContainsDuplicate
    {
        public static void Main(string[] args)
        {
            var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var isDuplicate = ContainsDuplicateFun1(nums);
            Console.WriteLine(isDuplicate);
        }

        private static bool ContainsDuplicateFun(int[] nums)
        {
            var distNums = nums.Distinct();
            return nums.Length != distNums.Count();
        }
        
        private static bool ContainsDuplicateFun1(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] == nums[i + 1])
                    return true;
            }
            return false;
        }
    }
}
