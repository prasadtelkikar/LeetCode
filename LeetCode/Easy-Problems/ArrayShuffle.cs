using System;
using System.Linq;

namespace Easy_Problems
{
    public class ArrayShuffle
    {
        public static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var n = Convert.ToInt32(Console.ReadLine());

            int[] result = Shuffle(nums, n);

            Console.WriteLine(String.Join(" ", result));
        }

        private static int[] Shuffle(int[] nums, int n)
        {
            int[] result = new int[n*2];
            for (int i = 0, j = 0; i < n; i++, j+=2)
            {
                result[j] = nums[i];
                result[j + 1] = nums[n+i];
            }
            return result;
        }
    }
}
