using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class CheckRows
    {
        public static void Main(string[] args)
        {
            //int[][] input = new int[19][];

            //input[0] = new int[19] { 15, 7, 18, 11, 19, 10, 14, 16, 8, 2, 3, 6, 5, 1, 17, 12, 9, 4, 13 };
            //input[1] = new int[19] { 17, 15, 9, 8, 11, 13, 7, 6, 5, 1, 3, 16, 12, 19, 10, 2, 4, 14, 18 };
            //input[2] = new int[19] { 19, 14, 12, 10, 8, 9, 17, 16, 4, 3, 13, 18, 1, 5, 7, 11, 2, 15, 6 };
            //input[3] = new int[19] { 4, 2, 10, 15, 19, 16, 8, 9, 5, 3, 1, 11, 13, 14, 6, 18, 12, 17, 7 };
            //input[4] = new int[19] { 13, 19, 9, 16, 5, 8, 6, 12, 14, 11, 18, 10, 7, 2, 3, 4, 15, 17, 1 };
            //input[5] = new int[19] { 4, 7, 18, 11, 17, 16, 5, 12, 10, 1, 15, 13, 14, 6, 19, 2, 3, 9, 8 };
            //input[6] = new int[19] { 14, 5, 15, 1, 18, 6, 12, 7, 8, 9, 3, 13, 2, 10, 19, 4, 11, 16, 17 };
            //input[7] = new int[19] { 10, 3, 1, 8, 14, 19, 11, 18, 15, 13, 9, 12, 16, 17, 7, 4, 5, 2, 6 };
            //input[8] = new int[19] { 14, 13, 19, 18, 7, 2, 4, 8, 10, 17, 12, 5, 15, 1, 6, 9, 11, 3, 16 };
            //input[9] = new int[19] { 19, 8, 10, 18, 16, 12, 11, 17, 4, 9, 7, 2, 5, 13, 15, 3, 6, 1, 14 };
            //input[10] = new int[19] { 1, 10, 6, 14, 7, 18, 3, 9, 4, 16, 5, 11, 13, 17, 15, 8, 19, 2, 12 };
            //input[11] = new int[19] { 13, 10, 5, 16, 1, 19, 17, 3, 9, 11, 7, 8, 12, 6, 4, 2, 14, 15, 18 };
            //input[12] = new int[19] { 17, 2, 1, 6, 9, 19, 18, 14, 4, 11, 12, 13, 16, 5, 8, 7, 3, 10, 15 };
            //input[13] = new int[19] { 1, 4, 10, 5, 13, 6, 18, 11, 3, 2, 15, 14, 16, 12, 17, 19, 8, 9, 7 };
            //input[14] = new int[19] { 2, 14, 3, 12, 16, 17, 11, 9, 1, 6, 5, 19, 10, 13, 4, 18, 7, 15, 8 };
            //input[15] = new int[19] { 15, 9, 8, 18, 14, 13, 4, 12, 5, 17, 6, 1, 11, 16, 19, 3, 7, 2, 10 };
            //input[16] = new int[19] { 15, 8, 12, 16, 13, 2, 6, 19, 18, 14, 10, 5, 11, 9, 7, 1, 3, 17, 4 };
            //input[17] = new int[19] { 15, 6, 17, 7, 5, 3, 1, 9, 19, 12, 10, 11, 16, 14, 18, 8, 2, 13, 4 };
            //input[18] = new int[19] { 6, 11, 10, 14, 2, 13, 16, 1, 9, 15, 8, 19, 17, 3, 5, 18, 7, 4, 12 };

            int[][] input = new int[3][];
            input[0] = new int[3] { 1, 2, 3};
            input[1] = new int[3] { 3, 1, 2 };
            input[2] = new int[3] { 2, 3, 1 };

            bool isValid = CheckValid(input);
            Console.WriteLine(isValid);
        }

        private static bool CheckValid(int[][] matrix)
        {
            var length = matrix.Length;
            for (int i = 0; i < length; i++)
            {
                int[] row = new int[length];
                int[] columns = new int[length];
                for (int j = 0; j < length; j++)
                {
                    //Store row data
                    row[matrix[i][j]-1]++;
                    //Store column data
                    columns[matrix[j][i]-1]++;
                    //Instantly check health of temp array. Good health = 1
                    if (row[matrix[i][j]-1] > 1 || columns[matrix[j][i]-1] > 1)
                        return false;
                }
            }
            return true;
        }
    }
}
