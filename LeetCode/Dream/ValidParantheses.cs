using System;
using System.Collections.Generic;
using System.Text;

namespace Dream
{
    public class ValidParantheses
    {
        public static void Main(string[] args)
        {
            string paran = Console.ReadLine();
            bool isValid = CheckValidity(paran);
            Console.WriteLine(isValid);
        }

        private static bool CheckValidity(string paran)
        {
            Stack<char> stack = new Stack<char>();
            foreach(var ch in paran)
            {
                if(ch == '{' || ch == '[' || ch == '(')
                    stack.Push(ch);
                else
                {
                    if (stack.Count == 0)
                        return false;

                    var lastParan = stack.Pop();
                    if(ch == '}' && lastParan != '{')
                        return false;
                    if(ch == ']' && lastParan != '[')
                        return false;
                    if (ch == ')' && lastParan != '(')
                        return false;

                }
            }
            if (stack.Count != 0)
                return false;
            return true;
        }
    }
}
