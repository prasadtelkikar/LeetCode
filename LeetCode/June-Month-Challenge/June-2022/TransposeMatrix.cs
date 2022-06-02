using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June_2022
{
    public class TransposeMatrix
    {
        public static void Main(string[] args)
        {
            int[][] input = new int[4][];
            input[0] = new int[3] { 1, 2, 3 };
            input[1] = new int[3] { 4, 5, 6 };
            input[2] = new int[3] { 7, 8, 9 };
            input[3] = new int[3] { 10, 11, 12 };

            int[][] result = Transpose(input);
            int columnLenght = result[0].Length;
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < columnLenght; j++)
                {
                    Console.Write(result[i][j] + " ");
                }
                Console.WriteLine();
            }

        }

        private static int[][] Transpose(int[][] matrix)
        {
            var columnLength = matrix[0].Length;
            int[][] result = new int[columnLength][];
            
            for (int i = 0; i < columnLength; i++)
            {
                result[i] = new int[matrix.Length];
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    result[j][i] = matrix[i][j];
                }
            }
            return result;
        }
    }
}
