using System;
using System.Collections.Generic;
using System.Text;

namespace Easy_II
{
    public class RomanToInteger
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int output = RomanToInt(input);
            Console.WriteLine(output);
        }

        private static int RomanToInt(string input)
        {
            Dictionary<char, int> map = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            int last = input.Length - 1;
            int total = map[input[last]];

            for(int i = last-1; i >= 0; i--)
            {
                int lastValue = map[input[i+1]];
                int lastButOneValue = map[input[i]];
                if (lastValue > lastButOneValue)
                    total -= lastButOneValue;
                else
                    total += lastButOneValue;
            }
            return total;
        }
    }
}
