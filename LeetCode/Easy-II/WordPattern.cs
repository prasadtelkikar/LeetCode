using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easy_II
{
    public class WordPattern
    {
        public static void Main(string[] args)
        {
            string pattern = "abba";
            string s = "dog dog dog dog";

            var isValidPattern = WordPatternFun(pattern, s);
            Console.WriteLine(isValidPattern);
        }

        private static bool WordPatternFun(string pattern, string s)
        {
            Dictionary<char, string> dic = new Dictionary<char, string>();
            char[] chs = pattern.ToCharArray();
            string[] words = s.Split();
            if (chs.Length != words.Length || words.Distinct().Count() != chs.Distinct().Count())
                return false;
            for (int i = 0; i < chs.Length; i++)
            {
                var word = words[i];
                char ch = chs[i];
                if (dic.ContainsKey(ch))
                {
                    if (dic[ch] != word)
                        return false;
                }
                else
                    dic.Add(ch, word);
            }
            return true;
        }
    }
}
