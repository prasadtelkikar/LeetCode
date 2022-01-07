using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class FinalValueAfterPerformingOperation
    {
        public static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            FinalValueAfterPerformingOperation operations = new FinalValueAfterPerformingOperation();
            var result = operations.FinalValueAfterOperations(inputs);
            Console.WriteLine(result);
        }

        private int FinalValueAfterOperations(string[] operations)
        {
            var result = 0;
            foreach (var operation in operations)
            {
                if (operation.Contains("++"))
                    result++;
                else
                    result--;
            }
            return result;
        }

        //TODO: Try other approaches.
    }
}
