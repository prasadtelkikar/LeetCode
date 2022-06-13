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
            triangle.Add(new List<int>() { 2 });
            triangle.Add(new List<int>() { 3, 4 });
            triangle.Add(new List<int>() { 6, 5, 7 });
            triangle.Add(new List<int>() { 4, 1, 8, 3 });

            //This will not consider path...
            //Partial succeeded
            var sum = triangle.Select(t => t.Min()).Sum();
        }

        //Try to solve it using top-down, bottom up approach.
    }
}
