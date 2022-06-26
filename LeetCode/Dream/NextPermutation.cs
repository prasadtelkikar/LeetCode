using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dream
{
    public class NextPermutation
    {
        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            NextPermutationFunction(input);
            Console.WriteLine(String.Join(", ", input));
        }

        private static void NextPermutationFunction(int[] input)
        {
            if (input.Length == 1)
                return;
            int peak = -1;
            for(int i=1; i<input.Length; i++)
            {
                if (input[i-1] < input[i])
                    peak = i;
            }

            if (peak == -1)
            {
                Array.Sort(input);
                return;
            }
            int index = peak;
            for(int i=peak; i<input.Length; i++)
            {
                if(input[i] > input[peak-1] && input[i] < input[index])
                    index = i;
            }

            Swap(input, peak-1, index);
            Array.Sort(input, peak, input.Length-peak);
        }

        private static void Swap(int[] input, int v1, int v2)
        {
            int temp = input[v1];
            input[v1] = input[v2];
            input[v2] = temp;
        }
    }
}
