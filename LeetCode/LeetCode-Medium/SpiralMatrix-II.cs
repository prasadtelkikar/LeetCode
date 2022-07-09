using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_Medium
{
    public class SpiralMatrix_II
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] result = GenerateMatrix(n);
            for(int row = 0; row < n; row++)
            {
                for(int col = 0; col < n; col++)
                    Console.Write(result[row][col] + " ");
                Console.WriteLine();
            }
        }

        private static int[][] GenerateMatrix(int n)
        {
            int count = 1;
            int[][] matrix = new int[n][];
            for(int i = 0; i < n; i++)
                matrix[i] = new int[n];

            int up = 0, left = 0;
            int down = n - 1, right = n - 1;

            while(up <= down && left <= right)
            {
                for (int col = up; col <= down; col++)
                    matrix[up][col] = count++;
                for (int row = up+1; row <= right; row++)
                    matrix[row][right] = count++;

                if(up < down)
                {
                    for(int col = down-1; col >= up; col--)
                        matrix[down][col] = count++;
                }
                if(left < right)
                {
                    for (int row = down-1; row > up; row--)
                        matrix[row][left] = count++;
                }

                up++;
                down--;
                left++;
                right--;
            }
            return matrix;
        }
    }
}
