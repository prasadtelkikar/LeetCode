using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class CountMatchingRule
    {
        public static void Main(string[] args)
        {
            IList<IList<string>> items = new List<IList<string>>();
            for (int i = 0; i < 3; i++)
            {
                var item = Console.ReadLine().Split().ToList();
                items.Add(item);
            }
            string ruleKey = Console.ReadLine();
            string ruleValue = Console.ReadLine();

            int result = CountMatches(items, ruleKey, ruleValue);
        }

        private static int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            string[] rules = new string[] { "type", "color", "name" };
            var ruleIndex = 0;
            for (int i = 0; i < rules.Length; i++)
            {
                if(rules[i] == ruleKey)
                {
                    ruleIndex = i;
                    break;
                }
            }
            var result = 0;
            foreach (var item in items)
            {
                if(item[ruleIndex] == ruleValue)
                    result++;
            }
            return result;
        }
        private static int CountMatchesLinq(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            var rule = new List<string> { "type", "color", "name" };
            var index = rule.FindIndex(x => x == ruleKey);

            var result = items.Count(x => x[index] == ruleValue);
            return result;
        }
    }
}
