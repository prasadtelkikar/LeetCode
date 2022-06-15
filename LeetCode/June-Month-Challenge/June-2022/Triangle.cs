using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June_2022
{
    public class Triangle
    {
        public static void Main(string[] args)
        {
            IList<IList<int>> triangle = new List<IList<int>>();
            triangle.Add(new List<int>() { -1 });
            triangle.Add(new List<int>() { 2, 3 });
            triangle.Add(new List<int>() { 1, -1, -3 });
            //triangle.Add(new List<int>() { 4, 1, 8, 3 });

            //This will not consider path...
            //Partial succeeded
            //var sum = triangle.Select(t => t.Min()).Sum();
            var sum = TopDownApproach(triangle);
            Console.WriteLine(sum);
        }

        //This won;t work, because it does not support [[-1],[2,3],[1,-1,-3]]. Expected -1 + 3 + -3 = -1 current 0.
        //Similar logic with two for loop will probably work, lets try tomorrow
        public static int FindPath(IList<IList<int>> triangle)
        {
            var result = 0;
            var minIndex = 0;
            for (int i = 0; i < triangle.Count; i++)
            {

                if (triangle[i].Count > minIndex+1)
                {
                    if (triangle[i][minIndex] < triangle[i][minIndex + 1])
                        result += triangle[i][minIndex];
                    else
                    {
                        result += triangle[i][minIndex + 1];
                        minIndex = minIndex + 1;
                    }
                }
                else
                {
                    result += triangle[i][minIndex];
                }
            }
            return result;
        }
        //Try to solve it using top-down, bottom up approach.

        public static int TopDownApproach(IList<IList<int>> triangle)
        {
            for (int row = 1; row < triangle.Count; row++)
            {
                for (int column = 0; column < triangle[row].Count; column++)
                {
                    int sum = 0;
                    if (column == 0)
                    {
                        sum = triangle[row][column] + triangle[row-1][column];
                    }
                    else if(column == triangle[row].Count - 1)
                    {
                        sum = triangle[row][column] + triangle[row-1][triangle[row - 1].Count - 1];
                    }
                    else
                    {
                        int min = Math.Min(triangle[row - 1][column], triangle[row - 1][column - 1]);
                        sum = min + triangle[row][column];
                    }
                    triangle[row][column] = sum;
                }
            }
            return triangle.Last().Min();
        }
    }
}
