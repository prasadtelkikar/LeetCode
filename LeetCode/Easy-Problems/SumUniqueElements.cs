using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class SumUniqueElements
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var result = SumOfUnique(nums);
            Console.WriteLine(result);
        }

        private static int SumOfUnique(int[] nums)
        {
            int[] count = new int[101];
            int sum = 0;
            foreach (var num in nums)
                count[num]++;
            for (int i = 0; i < 101; i++)
            {
                if (count[i] == 1)
                    sum = sum + i;
            }
            return sum;
        }

        //Let's try with dictionary and Linq tomorrow.
    }
}
