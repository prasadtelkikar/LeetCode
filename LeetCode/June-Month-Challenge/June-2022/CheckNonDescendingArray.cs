using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June_2022
{
    public class CheckNonDescendingArray
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isAscending = CheckPosibility(nums);
            Console.WriteLine(isAscending);
        }

        private static bool CheckPosibility(int[] nums)
        {
            if (nums.Length == 1)
                return true;
            else
            {
                int count = 0;
                int previousMax= int.MinValue;
                for (int i = 0; i < nums.Length; i++)
                {
                    int currentMax = Math.Max(previousMax, nums[i]);
                    if (currentMax >= previousMax)
                        count++;
                    else
                        previousMax = currentMax;
                    if (count > 2)
                        return false;
                }
                return true;
            }
        }

        //This need some brain storming
        //private static bool CheckPosibility(int[] nums)
        //{

        //}
    }
}
