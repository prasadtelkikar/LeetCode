using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class SumOfOddLengthArray
    {
        public static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var outputArray = SumOddLengthSubarrays(inputArray);
            Console.WriteLine(outputArray);
        }

        //Not Working
        private static int SumOddLengthSubarrays(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i+1; j < inputArray.Length; j++)
                {
                    int diff = j - i;
                    if(diff % 2 != 0)
                    {
                        sum += inputArray.Select((x, z) => z >= i && z < j ? x : 0).Sum();
                    }
                }
            }
            return sum;
        }
    }
}
