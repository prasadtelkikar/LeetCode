using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June_2022
{
    public class DeciBinary
    {
        public static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int result = MinPartitions(n);
            Console.WriteLine(result);
        }

        private static int MinPartitions(string n)
        {
            int minOnce = int.MinValue;
            for (int i = 0; i < n.Length; i++)
            {
                int value = n[i] - '0';
                if (value == 9) return 9;
                else
                    minOnce = Math.Max(minOnce, value);
            }
            return minOnce;
        }
    }
}
