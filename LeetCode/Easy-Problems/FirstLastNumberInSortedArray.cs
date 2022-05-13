using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class FirstLastNumberInSortedArray
    {
        public static void Main(string[] args)
        {
            FirstLastNumberInSortedArray range = new FirstLastNumberInSortedArray();
            var inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var target = int.Parse(Console.ReadLine());
            int[] result = range.SearchRange(inputArr, target);
        }

        private int[] SearchRange(int[] inputArr, int target)
        {
            if (inputArr.Length == 0 || !inputArr.Contains(target))
                return new int[] { -1, -1 };
            else
            {
                int i = 0;
                int j = inputArr.Length - 1;
                int startIndex = int.MaxValue;
                int endIndex = int.MinValue;
                for(int count = 0; count < inputArr.Length; count++)
                {
                    if (inputArr[i] == target)
                        startIndex = Math.Min(i, startIndex);
                    if (inputArr[j] == target)
                        endIndex = Math.Max(j, endIndex);
                    if (inputArr[i] < target)
                        i++;
                    if (inputArr[j] > target)
                        j--;
                }
                return new int[] { startIndex, endIndex };
            }
        }
    }
}
