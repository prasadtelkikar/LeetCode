using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class MaxProductTwoElements
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int output = MaxProduct(nums);
            Console.WriteLine(output);
        }

        private static int MaxProduct(int[] nums)
        {
            int largest = int.MinValue;
            int secondLargest = int.MinValue;
            foreach (var num in nums)
            {
                if(num >= largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if(num > secondLargest)
                    secondLargest = num;
            }

            return (largest-1) * (secondLargest-1);
        }
    }
}
