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
            string result = SortStringByLastChar(input);
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

        //Buggy code: Test case failing due to Index out of bound
        public static string SortStringByLastCharFun(string input)
        {
            StringBuilder sb = new StringBuilder();
            List<string> list = new List<string>();
            foreach (var word in input.Split())
            {
                var index = word.Last() - '0';
                list[index] = word.Substring(0, word.Length - 1);
            }

            for (int i = 0; i < list.Count(); i++)
                sb.Append(list[i] + " ");

            return sb.ToString().Trim();
        }
    }
}
