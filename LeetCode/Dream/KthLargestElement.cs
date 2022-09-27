using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dream
{
    public class KthLargestElement
    {
        public static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(" ").ToArray();
            int kthLargest = FindKthLargest(nums);
        }

        //Try efficient approach    
        private static int FindKthLargest(string[] nums)
        {
            SortedList<int, int> keyValuePairs = new SortedList<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {

            }
            return int.MinValue;
        }
    }
}
