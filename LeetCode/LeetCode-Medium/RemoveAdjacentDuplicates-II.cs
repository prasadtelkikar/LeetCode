using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Medium
{
    public class RemoveAdjacentDuplicates_II
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());
            string output = RemoveDuplicatesStack(input, k);
            Console.WriteLine(output);
        }

        private static string RemoveDuplicates(string input, int k)
        {
            StringBuilder sb = new StringBuilder(input);
            int length = -1;
            while(length != sb.Length)
            {
                length = sb.Length;
                for(int i = 0, count = 0; i < sb.Length; i++)
                {
                    if (i == 0 || sb[i] != sb[i-1])
                        count = 1;
                    else if(++count == k)
                    {
                        sb.Remove(i - k + 1, k);
                        break;
                    }
                }
            }
            return sb.ToString();
        }

        private static string RemoveDuplicatesStack(string input, int k)
        {
            Stack<AdjucentDuplicate> stack = new Stack<AdjucentDuplicate>();
            for(int i = 0; i < input.Length; i++)
            {
                if (stack.Count > 0 && stack.Peek().Char == input[i])
                    stack.Peek().Count += 1;
                else
                    stack.Push(new AdjucentDuplicate(input[i]));

                if (stack.Peek().Count == k)
                    stack.Pop();
            }

            StringBuilder sb = new StringBuilder();
            foreach(AdjucentDuplicate item in stack)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    sb.Append(item.Char);
                }
            }
            var temp = sb.ToString().ToCharArray();
            Array.Reverse(temp);
            return new string(temp);
        }
    }

    public class AdjucentDuplicate
    {
        public char Char { get; set; }
        public int Count { get; set; }

        public AdjucentDuplicate(char ch)
        {
            this.Char = ch;
            this.Count = 1;
        }
    }
}
