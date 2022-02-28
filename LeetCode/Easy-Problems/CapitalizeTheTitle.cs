using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class CapitalizeTheTitle
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = CapitalizeTitle(input);
            Console.WriteLine(output);
        }

        //buggy code, solve it easy fix
        private static string CapitalizeTitle(string input)
        {
            return string.Join(' ',input.Split().Select(x => char.ToUpper(x[0]) + x.Substring(1).ToLower()));
        }

        //Solve same problem with different approach.
    }
}
