using System;
using System.Collections.Generic;
using System.Text;

namespace Dream
{
    public class RotateImage
    {
        public static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[3] { 1, 2, 3 };
            matrix[1] = new int[3] { 4, 5, 6 };
            matrix[2] = new int[3] { 7, 8, 9 };

            Rotate(matrix);

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for(int j = 0; j < 3; j++)
                    Console.Write(matrix[i][j] + " ");
            }
        }

        private static void Rotate(int[][] matrix)
        {
            //Swap rows,
            var length = matrix.Length;
            for (int i = 0; i < length/2; i++)
            {
                var temp = matrix[i];
                matrix[i] = matrix[length - 1 - i];
                matrix[length - 1 - i] = temp;
            }

            //Swap location i j to j i

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
        }
    }
}
