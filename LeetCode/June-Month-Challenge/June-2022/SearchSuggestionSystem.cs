using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June_2022
{
    public class SearchSuggestionSystem
    {
        public static void Main(string[] args)
        {
            string[] products = new string[5] { "mobile", "mouse", "moneypot", "monitor", "mousepad" };
            string searchWord = "mouse";
            IList<IList<string>> result = SuggestedProducts(products, searchWord);
            foreach (var item in result)
            {
                Console.WriteLine(string.Join(", ", item));
            }
            Console.ReadLine();
        }

        private static IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            IList<IList<string>> result = new List<IList<string>>();
            for (int i = 0; i < searchWord.Length; i++)
            {
                var subString = searchWord.Substring(0, i+1);
                var product = products.Where(x => x.StartsWith(subString)).OrderBy(x => x).Take(3).ToList();
                result.Add(product);
            }
            return result;
        }
    }
}
