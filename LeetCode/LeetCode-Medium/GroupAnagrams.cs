using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_Medium
{
    public class GroupAnagrams
    {
        public static void Main(string[] args)
        {
            var inputArr = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };//Console.ReadLine().Split(' ');

            List<List<string>> result = GroupAnagramsFunc(inputArr);
            foreach(List<string> list in result)
            {
                Console.WriteLine(string.Join(",", list));
            }
        }

        private static List<List<string>> GroupAnagramsFunc(string[] strs)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            for(int i = 0; i < strs.Length; i++)
            {
                char[] charArr = strs[i].ToCharArray();
                Array.Sort(charArr);
                string sortedStr = new string(charArr);
                if (dict.ContainsKey(sortedStr))
                    dict[sortedStr].Add(strs[i]);
                else
                    dict.Add(sortedStr, new List<string>() { strs[i] });
            }

            return dict.Values.ToList();
        }
    }
}
