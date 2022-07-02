using System;
using System.Collections.Generic;
using System.Text;

namespace Dream
{
    public class BackspaceStringCompare
    {
        public static void Main(string[] args)
        {
            string firstStr = Console.ReadLine();
            string secondStr = Console.ReadLine();
            bool isSame = BackspaceCompareOptimized(firstStr, secondStr);
            Console.WriteLine(isSame);
        }

        private static bool BackspaceCompare(string firstStr, string secondStr)
        {
            Stack<char> firstStack = new Stack<char>();
            Stack<char> secondStack = new Stack<char>();
            foreach(char ch in firstStr)
            {
                if (ch == '#')
                {
                    if (firstStack.Count > 0)
                        firstStack.Pop();
                }
                else
                    firstStack.Push(ch);
            }
            foreach(char ch in secondStr)
            {
                if(ch == '#')
                {
                    if (secondStack.Count > 0)
                        secondStack.Pop();
                }
                else
                    secondStack.Push(ch);
            }
            int temp1Length = firstStack.Count;
            int temp2Length = secondStack.Count;
            char[] temp1 = new char[firstStack.Count];
            char[] temp2 = new char[secondStack.Count];
            while(firstStack.Count > 0)
                temp1[--temp1Length] = firstStack.Pop();
            while (secondStack.Count > 0)
                temp2[--temp2Length] = secondStack.Pop();

            return new string(temp1) == new string(temp2);
        }

        //Editorial: O(n)
        private static bool BackspaceCompareOptimized(string firstStr, string secondStr)
        {
            int i = firstStr.Length - 1;
            int j = secondStr.Length - 1;
            int skipFirst = 0;
            int skipSecond = 0;
            while(i >= 0 || j >= 0)
            {
                while(i >= 0)
                {
                    if (firstStr[i] == '#')
                    {
                        skipFirst++;
                        i--;
                    }
                    else if (skipFirst > 0)
                    {
                        skipFirst--;
                        i--;
                    }
                    else break;
                }
                while(j >= 0)
                {
                    if (secondStr[j] == '#')
                    {
                        skipSecond++;
                        j--;
                    }
                    else if (skipSecond > 0)
                    {
                        skipSecond--;
                        j--;
                    }
                    else break;
                }

                if(i >= 0 && j >= 0 && firstStr[i] != secondStr[j])
                    return false;
                if((i >= 0) != (j >= 0))
                    return false;
                i--; j--;
            }
            return true;
        }
    }
}
