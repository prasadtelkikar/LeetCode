using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class SegmentNumbersInString
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int output = FindNumberOfSpacesFun(input);
            Console.WriteLine(output);
        }

        private static int FindNumberOfSpaces(string input)
        {
            return input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }

        //Fix this code
        private static int FindNumberOfSpacesFun(string input)
        {
            int result = 0;
            for(int i = 0; i < input.Length || i == -1 ; i++)
            {
                int newSpaceIndex = input.IndexOf(' ', i);
                if(newSpaceIndex > 1)
                {
                    result++;
                    input = input.Substring(newSpaceIndex+1);
                }
            }
            return result;
        }
    }
}
