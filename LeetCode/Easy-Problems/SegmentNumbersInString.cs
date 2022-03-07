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

        //Failed few test cases
        private static int FindNumberOfSpacesFun(string input)
        {
            int result = 0;
            while(true)
            {
                if(string.IsNullOrWhiteSpace(input))
                    break;
                int newSpaceIndex = input.IndexOf(' ');
                if(newSpaceIndex > 1)
                {
                    string temp = input.Substring(0, newSpaceIndex);
                    input = input.Substring(newSpaceIndex+1);
                    if(!string.IsNullOrWhiteSpace(temp))
                        result++;
                }   
                else if(input.Length > 0)
                {
                    result++;
                    break;

                }
            }
            return result;
        }
    }
}
