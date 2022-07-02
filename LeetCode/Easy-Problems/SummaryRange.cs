using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class SummaryRange
    {
        public static void Main(string[]args)
        {
            int[] input = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            IList<string> output = SummaryRanges(input);
            Console.WriteLine(string.Join(",", output));
        }

        private static string StringReverse(string input)
        {
            char[] chars = new char[input.Length];
            for(int i = 0, j = input.Length-1; i < input.Length; i++, j--)
            {
                chars[i] = input[j];
            }
            return new string(chars);
        }

        private static IList<string> SummaryRanges(int[] nums)
        {
            int i = 0;
            IList<string> result = new List<string>();  
            while (i < nums.Length)
            {
                int start = nums[i];
                while (i < nums.Length-1 && nums[i] + 1 == nums[i+1])
                    i++;
                int end = nums[i];
                if (start == end)
                    result.Add($"{start}");
                else
                    result.Add($"{start}->{end}");
                i++;
            }
            return result;
        }
    }
}
