using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class SentenseSorting
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = SortStringByLastCharFun(input);
            Console.WriteLine(result);
        }

        private static string SortStringByLastChar(string input)
        {
            var result = string.Join(" ", input.Split()
                .Select(x => new { sequenceNo = x.Last() - '0', Word = x.Remove(x.Length - 1) })
                .OrderBy(x => x.sequenceNo)
                .Select(x => x.Word));
            return result;
        }

        public static string SortStringByLastCharFun(string input)
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<int, string> dict = new Dictionary<int, string>();
            foreach (var word in input.Split())
            {
                var index = word.Last() - '0';
                dict.Add(index, word.Substring(0, word.Length - 1));
            }
            var result = string.Join(" ", dict.OrderBy(x => x.Key).Select(x => x.Value));
            return result;
        }
    }
}
