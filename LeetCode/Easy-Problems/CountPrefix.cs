using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class CountPrefix
    {
        public static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ');
            string prefix = Console.ReadLine();
            int result = PrefixCount(inputs, prefix);
            Console.WriteLine(result);
        }

        private static int PrefixCount(string[] inputs, string prefix)
        {
            return inputs.Count(x => x.StartsWith(prefix));
        }
    }
}
