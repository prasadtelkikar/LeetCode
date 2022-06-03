using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class DiagonalSum
    {
        public static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[3] {1, 2, 3};
            arr[1] = new int[3] {4, 5, 6};
            arr[2] = new int[3] {7, 8, 9};
            int result = DiagonalSumFun(arr);
        }

        private static int DiagonalSumFun(int[][] mat)
        {
            var length = mat.Length;
            var majorDiagonalSum = 0;
            var minorDiagonalSum = 0;   
            for (int i = 0; i < length; i++)
            {
                majorDiagonalSum+=mat[i][i];
                var column = length - i - 1;
                if (column != i)
                    minorDiagonalSum += mat[i][column];
            }
            return majorDiagonalSum + minorDiagonalSum;
        }
    }
}
