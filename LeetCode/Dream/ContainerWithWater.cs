using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dream
{
    public class ContainerWithWater
    {
        public static void Main(string[] args)
        {
            int[] heights = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int result = FindMostWaterFunc(heights);
            Console.WriteLine(result);
        }

        //Time-out error
        private static int FindMostWater(int[] heights)
        {
            int maxArea = int.MinValue;
            for (int i = 0; i < heights.Length; i++)
            {
                for (int j = i+1; j < heights.Length; j++)
                {
                    int difference = j - i;
                    var height = Math.Min(heights[i], heights[j]);
                    int area = height * difference;
                    maxArea = Math.Max(maxArea, area);
                }
            }
            return maxArea;
        }

        private static int FindMostWaterFunc(int[] heights)
        {
            int start = 0;
            int end = heights.Length - 1;
            int maxArea = int.MinValue;
            while(start < end)
            {
                int area = Math.Min(heights[start], heights[end]) * (end - start);
                maxArea = Math.Max(maxArea, area);
                if (heights[start] > heights[end])
                    end--;
                else start++;
            }
            return maxArea;
        }
    }
}
