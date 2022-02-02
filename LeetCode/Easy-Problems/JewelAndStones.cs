using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class JewelAndStones
    {
        public static void Main(string[] args)
        {
            string jewels = Console.ReadLine();
            string stones = Console.ReadLine();
            int result = NumJewelsInStones(jewels, stones);
        }

        private static int NumJewelsInStones(string jewels, string stones)
        {
            int result = 0;
            foreach(var ch in jewels.ToCharArray())
                result += stones.Count(x => x.Equals(ch));
            return result;
        }
    }
}
