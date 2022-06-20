using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June_2022
{
    public class WordShortEncoding
    {
        public static void Main(string[] args)
        {
            string[] words = new string[] { "time", "me", "bell" };
            int count = MinimumLengthEncoding(words);
            Console.WriteLine(count);
        }

        //Satisfaction.... 😊
        private static int MinimumLengthEncoding(string[] words)
        {
            var temp = words.ToHashSet().OrderByDescending(x => x.Length).ToList();
            var length = temp.Count;
            int sum = 0;
            var list = new HashSet<string>();
            for (int i = length-1; i >= 0; i--)
            {
                var t = temp.FirstOrDefault(x => x.EndsWith(temp[i]));
                if (t != null)
                    list.Add(t);
                else
                    list.Add(temp[i]);
            }
            foreach (var t in list)
                sum += t.Length + 1;
            return sum;
        }
    }
}
