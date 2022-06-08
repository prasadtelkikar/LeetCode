using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June_2022
{
    public class RemovePalindromicSubsequence
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int result = RemovePalindromeSub(s);
        }

        //Solution: From Discussion
        private static int RemovePalindromeSub(string s)
        {
            int length = s.Length;
            for (int i = 0; i < length; i++)
            {
                if (s[i] != s[length - i - 1])
                    return 2;
            }
            return 1;
        }
    }
}
