using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class Max69Number
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = Maximum69Number(number);
            Console.WriteLine(result);
        }

        //Regex does not work on leet code, try different approach
        private static int Maximum69Number(int num)
        {
            string strNum = num.ToString();
            var regex = new Regex(Regex.Escape("6"));
            var newText = regex.Replace(strNum, "9", 1);

            return int.Parse(newText);

        }
    }
}
