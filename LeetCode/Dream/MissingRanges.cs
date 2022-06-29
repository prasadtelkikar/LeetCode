using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dream
{
    public class MissingRanges
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            int lower = Convert.ToInt32(Console.ReadLine());
            int upper = Convert.ToInt32(Console.ReadLine());
            IList<string> result = FindMissingRanges(nums, lower, upper);
            Console.WriteLine(string.Join(", ", result));
        }

        private static IList<string> FindMissingRanges(int[] nums, int lower, int upper)
        {
            List<string> result = new List<string>();
            if (lower < nums[0])
                result.Add(Print(lower, nums[0]));
            for (int i = 0; i < nums.Length-1; i++)
            {
                int diff = nums[i+1] - nums[i];
                if(diff > 1)
                {
                    int start = nums[i] + 1;
                    int end = nums[i+1] - 1;
                    result.Add(Print(start, end));
                }
            }
            if(upper > nums[nums.Length-1] && (upper - nums[nums.Length - 1]) > 1)
                result.Add(Print(nums[nums.Length - 1]+1, upper));

            return result;
        }

        private static string Print(int lower, int upper)
        {
            if (lower == upper)
                return $"{lower}";
            else
                return $"{lower}-> {upper}";

        }
    }
}
