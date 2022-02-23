using System;
using System.Collections.Generic;

namespace Easy_Problems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var target = int.Parse(Console.ReadLine());
            Program pObject = new Program();
            var result = pObject.TargetIndices(inputs, target);
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }

        public IList<int> TargetIndices(int[] nums, int target)
        {
            var result = new List<int>();
            Array.Sort(nums);
            for(int i = 0; i < nums.Length;i++)
            {
                if (nums[i] == target)
                    result.Add(i); 
            }
            return result;
        }
    }
}
