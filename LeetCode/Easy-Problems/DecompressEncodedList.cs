using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class DecompressEncodedList
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] result = DecompressRLElist(nums);
            Console.WriteLine(string.Join(" ", result));
        }

        private static int[] DecompressRLElist(int[] nums)
        {
            List<int> result = new List<int>(); 
            for(int i = 0; i < nums.Length; i += 2)
            {
                var freq = nums[i];
                var val = nums[i + 1];
                for (int j = 0; j < freq; j++)
                    result.Add(val);
            }
            return result.ToArray();
        }
    }
}
