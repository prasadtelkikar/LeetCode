using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class ContainerMostWater
    {
        public static void Main(string[] args)
        {
            ContainerMostWater water = new ContainerMostWater();
            var height = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int result = water.MaxAreaSecondApproach(height);
            Console.WriteLine(result);
        }

        private int MaxArea(int[] height)
        {
            var length = height.Length;
            int maxArea = 0;
            for (int i = 0; i < length; i++)
            {
                for(int j = i+1; j < length; j++)
                {
                    var min = Math.Min(height[i], height[j]);
                    var diff = j - i;
                    var mul = min * diff;
                    maxArea = Math.Max(maxArea, mul);
                }
            }
            return maxArea;
        }

        private int MaxAreaSecondApproach(int[] height)
        {
            int start = 0;
            int end = height.Length - 1;
            int result = int.MinValue;
            while(start < end)
            {
                var area = Math.Min(height[start], height[end]) * (end - start);
                result = Math.Max(area, result);
                if (height[start] < height[end])
                    start++;
                else
                    end--;
            }
            return result;
        }
    }
}
