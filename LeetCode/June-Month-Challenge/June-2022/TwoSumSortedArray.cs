using System;
using System.Linq;

namespace June_2022
{
    public class TwoSumSortedArray
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int target = Convert.ToInt32(Console.ReadLine());
            int[] result = TwoSum(numbers, target);
            Console.WriteLine(string.Join(" ", result));
        }

        private static int[] TwoSum(int[] numbers, int target)
        {
            int i = 0;
            int j = numbers.Length -  1;
            while(i < j)
            {
                var temp = numbers[i] + numbers[j];
                if (temp == target)
                    return new int[]{i+1, j+1};
                else if(temp < target)
                    i++;
                else j--;
            }
            //This will never come
            return new int[]{int.MinValue, int.MaxValue};
        }
    }
}
