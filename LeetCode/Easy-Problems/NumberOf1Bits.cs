using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class NumberOf1Bits
    {
        public static void Main(string[] args)
        {
            uint input = uint.Parse(Console.ReadLine());
            int output = HammingWeight(input);
            Console.WriteLine(output);
        }

        private static int HammingWeight(uint input)
        {
            var str = Convert.ToString(input, 2);
            return str.Count(x => x == '1');
        }

        private static int HammingWeightForLoop(uint input)
        {
            var str = Convert.ToString(input, 2);
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '1')
                    count++;
            }
            return count;
        }
    }
}
