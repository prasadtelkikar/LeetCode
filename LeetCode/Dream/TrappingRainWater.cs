using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dream
{
    public class TrappingRainWater
    {
        public static void Main(string[] args)
        {
            int[] height = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int result = TrapTwoPointer(height);
            Console.WriteLine(result);
        }

        //Using two lists, MaxR and MaxL
        private static int Trap(int[] height)
        {
            //Step1: Calculate MaxLeft
            int maxLeft = int.MinValue;
            Dictionary<int, int> indexWithMaxLeft = new Dictionary<int, int>();
            //For first left element, max left height will be 0 always
            indexWithMaxLeft.Add(0, 0); 
            for (int i = 1; i < height.Length; i++)
            {
                maxLeft = Math.Max(maxLeft, height[i-1]);
                indexWithMaxLeft.Add(i,maxLeft);
            }

            //Step 2: Calculate maximum right height
            int maxRight = int.MinValue;
            Dictionary<int, int> indexWithMaxRight = new Dictionary<int, int>();
            //For first right hand side element, height will be always zero
            indexWithMaxRight.Add(height.Length - 1, 0);
            for (int i = height.Length - 2; i >= 0; i--)
            {
                maxRight = Math.Max(maxRight, height[i+1]);
                indexWithMaxRight.Add(i, maxRight);
            }

            //Find Minimum from Left max height and right max height
            List<int> MinLeftRigthHeight = new List<int>();
            for(int i = 0; i < height.Length; i++)
            {
                int min = Math.Min(indexWithMaxLeft[i], indexWithMaxRight[i]);
                MinLeftRigthHeight.Add(min);
            }

            //Now, calculate trapped water
            int result = 0;
            for (int i = 0; i < height.Length; i++)
            {
                int temp = MinLeftRigthHeight[i] - height[i];
                result += temp > 0 ? temp : 0;
            }
            return result;
        }

        //Two pointers problem
        private static int TrapTwoPointer(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int maxLeft = height[left];
            int maxRight = height[right];
            int result = 0;

            while (left < right)
            {
                if(maxLeft < maxRight)
                {
                    left++;
                    maxLeft = Math.Max(maxLeft, height[left]);
                    result += maxLeft - height[left];
                }
                else
                {
                    right--;
                    maxRight = Math.Max(maxRight, height[right]);
                    result += maxRight - height[right]; 
                }
            }
            return result;
        }
    }
}
