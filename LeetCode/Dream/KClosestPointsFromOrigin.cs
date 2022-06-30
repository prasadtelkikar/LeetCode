using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dream
{
    public class KClosestPointsFromOrigin
    {
        public static void Main(string[] args)
        {
            int[][] points = new int[3][];
            points[0] = new int[2] { 3, 3 };
            points[1] = new int[2] { 5, -1 };
            points[2] = new int[2] { -2, 4 };

            int k = 2;
            int[][] result = KClosest(points, k);
        }

        private static int[][] KClosest(int[][] points, int k)
        {
            List<Point> pointsObj = points.Select(x => new Point(x[0], x[1])).ToList();
            return  pointsObj.OrderBy(x => x.Distance).Take(k).Select(x => x.Print()).ToArray();
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Double Distance { get; set; }
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
            var sqr = x * x + y * y;
            this.Distance = Math.Sqrt(sqr);
        }

        public int[] Print()
        {
            return new int[2] { this.X, this.Y };
        }
    }
}
