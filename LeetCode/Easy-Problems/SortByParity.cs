using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class SortByParity
    {
        public static void Main(string[] args)
        {
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int[] result = SortArrayByParity(nums);
        }

        private static int[] SortArrayByParity(int[] nums)
        {
            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();
            foreach (var num in nums)
            {
                if(num % 2 == 0)
                    evenList.Add(num);
                else
                    oddList.Add(num);
            }
            evenList.AddRange(oddList);
            return evenList.ToArray();
        }
    }
}
