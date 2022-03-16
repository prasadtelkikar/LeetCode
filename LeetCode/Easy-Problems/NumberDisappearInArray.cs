using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class NumberDisappearInArray
    {
        public static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            IList<int> outputList = FindDisappearedNumbers(inputArray);
            Console.WriteLine(string.Join(", ", outputList));
        }

        private static IList<int> FindDisappearedNumbers(int[] nums)
        {
            IList<int> result = new List<int>();
            int[] temp = new int[nums.Length];
            foreach (int num in nums)
            {
                temp[num-1] = -1;
            }
            for(int i =0; i < temp.Length; i++)
            {
                if(temp[i] != -1)
                    result.Add(i+1);
            }
            return result;
        }

        //Acceptable code is to use O(n) time complexity, without extra space complexity.
        //Above code satisfy time complexity criteria, for extra space complexity we have to look alternate solution.

    }
}
