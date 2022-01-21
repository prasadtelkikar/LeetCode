using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class LongestCommonPrefix
    {
        public static void Main(string[] args)
        {
            var str = Console.ReadLine().Split(", ");
            string result = LongestCommonPrefixFun(str);
        }

        private static string LongestCommonPrefixFun(string[] str)
        {
            var smallestString = str.OrderBy(x => x.Length).First();
            var result = string.Empty;
            for (int i = 0; i < smallestString.Length; i++)
            {
                var subSmallestString = smallestString.Substring(0, i + 1);
                //if()
            }
            throw new NotImplementedException();
        }
    }
}
