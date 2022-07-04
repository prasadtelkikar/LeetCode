using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class ProductArrayExceptSelf
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] result = ProductExceptSelf(nums);
            Console.WriteLine(result);
        }

        private static int[] ProductExceptSelf(int[] nums)
        {
            int[] left = new int[nums.Length];
            int[] right = new int[nums.Length];

            left[0] = 1;
            for (int i = 1; i < nums.Length; i++)
                left[i] = left[i-1] * nums[i-1];

            //Set boundary to 1
            right[right.Length - 1] = 1;
            for (int i = right.Length - 2; i >= 0; i--)
                right[i] = right[i + 1] * nums[i + 1];

            int[] product = new int[nums.Length];
            for(int i = 0; i < nums.Length; i++)
            {
                product[i] = left[i] * right[i];
            }
            return product;
        }
    }
}
