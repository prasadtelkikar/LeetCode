using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class TruncateSentence
    {
        public static void Main(string[] args)
        {
            var sentence = Console.ReadLine();
            var takeCount = int.Parse(Console.ReadLine());
            var result = string.Join(" ", sentence.Split(' ').Take(takeCount));
            Console.WriteLine(result);
        }
    }
}
