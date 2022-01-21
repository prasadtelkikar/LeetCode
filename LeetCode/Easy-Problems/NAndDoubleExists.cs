using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class NAndDoubleExists
    {
        public static void Main(string[] args)
        {
            var inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var exists = CheckIfNAndDoubleExists(inputArr);
        }

        private static bool CheckIfNAndDoubleExists(int[] inputArr)
        {
            for (int i = 0; i < inputArr.Length; i++)
            {
                var doubleI = inputArr[i] * 2;
                for (int j = 0; j < inputArr.Length; j++)
                {
                    if (doubleI == inputArr[j])
                        return true;
                }
            }
            return false;
        }

        //private static bool CheckIfNAndDoubleExists(int[] inputArr)
        //{
            
        //}
    }
}
