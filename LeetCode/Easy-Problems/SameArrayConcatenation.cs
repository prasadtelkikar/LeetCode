using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class SameArrayConcatenation
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            var result = GetConcatenation(input);
            Console.WriteLine(string.Join(" ", result));
        }

        //Efficient than others
        private static int[] GetConcatenation(int[] input)
        {
            var length = input.Length;
            var result = new int[length*2];
            for (int i = 0; i < length; i++)
            {
                result[i] = input[i];
                result[i+length] = input[i];
            }
            return result;
            throw new NotImplementedException();
        }

        private static int[] GetConcatenationList(int[] nums)
        {
            var list = new List<int>();
            list.AddRange(nums);
            list.AddRange(nums);
            return list.ToArray();
        }

        private static int[] GetConcatenationLinq(int[] nums)
        {
            return nums.Concat(nums).ToArray();
        }
    }
}
