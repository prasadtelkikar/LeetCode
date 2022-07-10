using System;
using System.Collections.Generic;
using System.Text;

namespace Easy_Problems
{
    public class RemoveAllAdjacentElements
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = RemoveDuplicates(input);
            Console.WriteLine(output);
        }

        private static string RemoveDuplicates(string input)
        {
            Stack<char> stack = new Stack<char>();
            stack.Push(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                char nextChar = input[i];
                if(stack.Count == 0)
                    stack.Push(nextChar);
                else if(nextChar == stack.Peek())
                    stack.Pop();
                else
                    stack.Push((char)nextChar);
            }

            char[] result = new char[stack.Count];
            for(int i = stack.Count - 1; i >= 0; i--)
            {
                result[i] = stack.Pop();

            }
            return new string(result);
        }
    }
}
