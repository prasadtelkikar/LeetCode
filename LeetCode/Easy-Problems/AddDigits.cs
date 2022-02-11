using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class AddDigits
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int result = AddNumber(num);
            Console.WriteLine(result);
        }

        //Recursive
        private static int AddNumber(int num)
        {
            if (num >= 10)
            {
                var sum = num.ToString().ToCharArray().Select(x => x - '0').Sum();
                return AddNumber(sum);
            }
            else
                return num;
        }

        //Try non recursive and linq(If possible)
    }
}
