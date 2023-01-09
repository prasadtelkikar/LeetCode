using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easy_II
{
    public class DeleteUnSortedColumn
    {
        public static void Main(string[] args)
        {
            string[] str = { "cba", "daf", "ghi" };
            int result = MinDeletionSize(str);
            Console.WriteLine(result);
        }


        //Make it better
        private static int MinDeletionSize(string[] str)
        {

            var columns = str[0].Length;
            var rows = str.Length;
            char[][] reverseMatrix = new char[columns][];
            for (int i = 0; i < columns; i++)
                reverseMatrix[i] = new char[rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    reverseMatrix[j][i] = str[i][j];
                }
            }
            List<string> temp = new List<string>();
            for (int i = 0; i < columns; i++)
            {
                temp.Add(new string(reverseMatrix[i]));
            }
            List<string> sortedList = new List<string>();
            foreach (string s in temp)
            {
                var charArray = s.ToCharArray();
                Array.Sort(charArray);
                sortedList.Add(new string(charArray));
            }
            int count = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i] != sortedList[i])
                    count++;
            }
            return count;
        }
    }
}
