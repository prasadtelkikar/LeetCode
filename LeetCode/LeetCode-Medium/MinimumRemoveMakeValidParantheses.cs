using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Medium
{
    public class MinimumRemoveMakeValidParantheses
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = MinRemoveToMakeValid(input);
            Console.WriteLine(output);
        }

        private static string MinRemoveToMakeValid(string input)
        {
            List<int> removeIndex = new List<int>();
            StringBuilder sb = new StringBuilder();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == '(')
                    stack.Push(i);
                if(input[i] == ')')
                {
                    if(stack.Count == 0)
                        removeIndex.Add(i);
                    else 
                        stack.Pop();
                }
            }
            while(stack.Count > 0)
                removeIndex.Add(stack.Pop());

            for (int i = 0; i < input.Length; i++)
            {
                if(!removeIndex.Contains(i))
                    sb.Append(input[i]);
            }
            return sb.ToString();
        }
    }
}
