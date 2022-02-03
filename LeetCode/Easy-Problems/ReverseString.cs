using System;
using System.Linq;

namespace Easy_Problems
{
    public class ReverseString
    {
        public static void Main(string[] args)
        {
            var inputCharArray = Console.ReadLine().ToCharArray();
            ReverseStringFuncLinq(inputCharArray);
        }

        private static void ReverseStringFunc(char[] inputCharArray)
        {
            var length = inputCharArray.Length;
            for (int i = 0; i < length/2; i++)
            {
                char temp = inputCharArray[i]; //space complexity O(1)
                inputCharArray[i] = inputCharArray[length-i-1];
                inputCharArray[length - i - 1] = temp;
            }
            Console.WriteLine(new String(inputCharArray));
        }

        //Not work, because it is not updating actual char []
        private static void ReverseStringFuncLinq(char[] inputCharArray)
        {
            inputCharArray = inputCharArray.Reverse().ToArray();
            Console.WriteLine(new String(inputCharArray));
        }

        private static void ReverseStringFuncArray(char[] inputCharArray)
        {
            Array.Reverse(inputCharArray);
            Console.WriteLine(new String(inputCharArray));
        }
    }
}
