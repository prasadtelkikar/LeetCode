using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_Medium
{
    public class CountSmallerNumberAfterSelf
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int[] result = CountSmaller(arr);
            Console.WriteLine(string.Join(',', result));
        }

        private static int[] CountSmaller(int[] arr)
        {
            var sortedDescArr = arr.OrderByDescending(x => x).ToList();
            int[] result = new int[sortedDescArr.Count];
            for(int i = 0;i < arr.Length;i++)
            {
                result[i] = sortedDescArr.FindIndex(x => x == arr[i]);
            }
            return result;
        }
    }
}
