using System;
using System.Collections.Generic;

namespace LeetCode_Medium
{
    public class SpiralMatrx
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[4] { 1, 2, 3, 4 };
            matrix[1] = new int[4] { 5, 6, 7, 8 };
            matrix[2] = new int[4] { 9, 10, 11, 12 };

            IList<int> result = SpiralOrder(matrix);
            Console.WriteLine(String.Join(" ", result));
        }

        //Interesting Problem: Solution from Leetcode solution
        //Visualization and variable names are IMPORTANT
        private static IList<int> SpiralOrder(int[][] matrix)
        {
            //This is important
            int rows = matrix.Length;
            int columns = matrix[0].Length;

            //This is sooo important
            int up = 0, left = 0;
            int down = rows-1, right = columns-1;


            List<int> result = new List<int>();
            while(result.Count < rows * columns)
            {
                for(int col = left; col <= right; col++)
                    result.Add(matrix[up][col]);

                for (int row = up+1; row <= down; row++)
                    result.Add(matrix[row][right]);

                if(up != down)
                {
                    for(int col = right - 1; col >= left; col--)
                        result.Add(matrix[down][col]);
                }
                if(left != right)
                {
                    for (int row = down - 1; row > up; row--)
                        result.Add(matrix[row][left]);
                }
                up++;
                right--;
                down--;
                left++;
            }
            return result;
        }
    }
}
