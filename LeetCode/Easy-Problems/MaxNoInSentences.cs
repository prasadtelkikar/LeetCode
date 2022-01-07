using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class MaxNoInSentences
    {
        public static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(", ").Select(x => x.Trim()).ToArray();
            MaxNoInSentences maxLengthInSentence = new MaxNoInSentences();
            var result = maxLengthInSentence.MostWordsFound(inputs);
            Console.WriteLine(inputs.Length);
        }
        public int MostWordsFound(string[] sentences)
        {
            var maxLength = int.MinValue;
            foreach (var sentence in sentences)
            {
                var wordLength = sentence.Split(' ').Length;
                if(maxLength < wordLength)
                    maxLength = wordLength;
            }
            return maxLength;
        }

        public int MostWordsFoundLinq(string[] sentences)
        {
            var maxLength = sentences
                .Select((x, i) => new { Length = x.Split().Length })
                .OrderByDescending(x => x.Length)
                .First()
                .Length;
            return maxLength;
        }

        //MSDN Help
        public int MostWordsAggregate(string[] sentences)
        {
            var result = sentences.Aggregate("", (longest, next) => next.Split().Length > longest.Split().Length ? next : longest);
            return result.Split().Length;
        }

        //Cheating
        public int MostWordsSelectLinq(string[] sentences)
        {
            var maxLength = sentences
                .Select(x => x.Split().Length).
                Max();
            return maxLength;
        }
    }
}
