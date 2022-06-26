using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June_2022
{
    public class MaximumPoints
    {
        public static void Main(string[] args)
        {
            int[] cardPoints = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int k = Convert.ToInt32(Console.ReadLine());

            int maxScore = MaxScoreFunc(cardPoints, k);
            Console.WriteLine(maxScore);
        }

        //It is not generating maximum score
        private static int MaxScore(int[] cardPoints, int k)
        {
            if(cardPoints.Length == 1)
                return cardPoints[0];
            if (cardPoints.Length == k)
                return cardPoints.Sum();

            int sum = 0;
            int start = 0;
            int end = cardPoints.Length - 1;
            while(k > 0)
            {
                int startValue = cardPoints[start];
                int endValue = cardPoints[end];
                if(startValue > endValue)
                {
                    sum+=cardPoints[start];
                    start++;
                }
                else
                {
                    sum+=cardPoints[end];
                    end--;
                }
                k--;
            }
            return sum;
        }

        private static int MaxScoreFunc(int[] cardPoints, int k)
        {
            if(cardPoints.Length == 1)
                return cardPoints[0];
            if (cardPoints.Length == k)
                return cardPoints.Sum();

            int frontSum = 0;
            for(int i = 0; i < k; i++)
                frontSum += cardPoints[i];
            int maxSum = frontSum;

            int rearScore = 0;
            for (int i = 0; i < k; i++)
            {
                rearScore += cardPoints[cardPoints.Length - i - 1];
                frontSum -= cardPoints[k - i - 1];
                int backwordSum = rearScore + frontSum;
                maxSum = Math.Max(maxSum, backwordSum);
            }
            return maxSum;
        }

    }
}
