using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class CapitalizeTheTitle
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = CapitalizeTitle(input);
            Console.WriteLine(output);
        }

        private static string CapitalizeTitle(string input)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in input.Split())
            {
                if(item.Length > 2)
                    stringBuilder.Append(char.ToUpper(item[0]) + item.Substring(1).ToLower() + ' ');
                else
                    stringBuilder.Append(item.ToLower() + ' ');
            }
            return stringBuilder.ToString().Trim();
        }

        private static string CapitalizeTitleLinq(string title)
        {
            return string.Join(' ', title.Split().Select(x => x.Length > 2 ? char.ToUpper(x[0]) + x.Substring(1).ToLower() : x.ToLower())).Trim();
        }
    }
}
