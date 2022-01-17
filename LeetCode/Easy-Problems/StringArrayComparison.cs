using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class StringArrayComparison
    {
        public static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split(' ').ToArray();
            var arr2 = Console.ReadLine().Split(' ').ToArray();
            bool equal = ArrayStringsAreEqual(arr1, arr2);
            Console.WriteLine(equal);
        }

        private static bool ArrayStringsAreEqual(string[] arr1, string[] arr2)
        {
            var str1 = string.Join("", arr1);
            var str2 = string.Join("", arr2);
            return str1.Equals(str2);
        }
    }
}
