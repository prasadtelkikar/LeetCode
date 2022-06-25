using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dream
{
    public class _3Sum
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> result = FindThreeSum(nums);
            foreach (var item in result)
            {
                Console.WriteLine(String.Join(", ", item));
            }
        }

        private static IList<IList<int>> FindThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            nums = nums.OrderBy(x => x).ToArray();
            for (int i = 0; i < nums.Length-2; i++)
            {
                if(i == 0 || (i > 0 && nums[i] != nums[i-1]))
                {
                    int lowerBound = i+1;
                    int upperBound = nums.Length-1;
                    int sum = 0 - nums[i];

                    while (lowerBound < upperBound)
                    {
                        if (nums[lowerBound] + nums[upperBound] == sum)
                        {
                            result.Add(new List<int> { nums[i], nums[lowerBound], nums[upperBound] });
                            while (lowerBound < upperBound && nums[lowerBound] == nums[lowerBound+1]) lowerBound++;
                            while (lowerBound < upperBound && nums[upperBound] == nums[upperBound-1]) upperBound--;

                            lowerBound++;
                            upperBound--;
                        }
                        else if (nums[lowerBound] + nums[upperBound] > sum)
                            upperBound--;
                        else
                            lowerBound++;
                    }
                }
            }
            return result;
        }
    }
}
