using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class LengthOfLastWord
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int result = LengthOfLastWordFunc(input);
        }

        private static int LengthOfLastWordFunc(string input)
        {
            return input.Trim().Split().Last().Length;
        }
    }
}
