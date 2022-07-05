using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dream
{
    public class FindAndReplaceInString
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] indices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] sources = Console.ReadLine().Split(" ").ToArray();
            string[] target = Console.ReadLine().Split(" ").ToArray();

            string output = FindReplaceString(input, indices, sources, target);
            Console.WriteLine(output);
        }

        private static string FindReplaceString(string input, int[] indices, string[] sources, string[] targets)
        {
            List<ReplacementElements> replacementElements = new List<ReplacementElements>();

            for (int i = 0; i < indices.Length; i++)
                replacementElements.Add(new ReplacementElements(indices[i], sources[i], targets[i]));

            replacementElements = replacementElements.OrderByDescending(x => x.Index).ToList();
            StringBuilder sb = new StringBuilder(input);
            foreach (var item in replacementElements)
            {
                int subStringLength = item.Index + item.Source.Length;
                string subString = "";
                if (subStringLength < input.Length)
                    subString = input.Substring(item.Index, item.Source.Length);
                else
                    subString = input.Substring(item.Index);
                if (subString == item.Source)
                {
                    sb.Remove(item.Index, item.Source.Length);
                    sb.Insert(item.Index, item.Target);
                    input = sb.ToString();
                }
            }
            return sb.ToString();
        }
    }

    public class ReplacementElements
    {
        public int Index { get; set; }
        public string Source { get; set; }
        public string Target { get; set; }

        public ReplacementElements(int index, string source, string target)
        {
            this.Index = index;
            this.Source = source;
            this.Target = target;
        }
    }
}
