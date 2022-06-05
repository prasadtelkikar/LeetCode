using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June_2022
{
    public class RangeSum2D
    {
        //TODO: Check it tomorrow
        public static void Main(string[] args)
        {
            int[][] matrix = new int[5][];
            matrix[0] = new int[5] { 3, 0, 1, 4, 2 };
            matrix[1] = new int[5] { 5, 6, 3, 2, 1 };
            matrix[2] = new int[5] { 1, 2, 0, 1, 5 };
            matrix[3] = new int[5] { 4, 1, 0, 1, 7 };
            matrix[4] = new int[5] { 1, 0, 3, 0, 5 };

            NumMatrix numMatrix = new NumMatrix(matrix);

            Console.WriteLine(numMatrix.SumRegion(1, 2, 2, 4));

        }
    }
    //Awesome explaination: https://youtu.be/rkLDDxOcJxU
    public class NumMatrix
    {
        int[][] sumMatrix = new int[5][];
        public NumMatrix(int[][] matrix)
        {
            for(int i=0; i<matrix.Length; i++)
            {
                sumMatrix[i] = new int[matrix[i].Length];
                sumMatrix[i][0] = matrix[i][0];
                for (int j = 1; j < matrix.Length; j++)
                {
                    sumMatrix[i][j] = sumMatrix[i][j-1] + matrix[i][j];
                }
            }

            for(int i = 1; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                    sumMatrix[i][j] += sumMatrix[i-1][j];
            }
        }

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            int total = sumMatrix[row2][col2];
            int extra = (col1 != 0 ? sumMatrix[row2][col1-1] : 0) + (row1 != 0 ? sumMatrix[row1-1][col2] : 0) - ((row1 != 0 && col1 != 0) ? sumMatrix[row1-1][col1-1] : 0);
            return total - extra;
        }
    }
}
