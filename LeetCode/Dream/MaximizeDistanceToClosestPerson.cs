using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dream
{
    public class MaximizeDistanceToClosestPerson
    {
        public static void Main(string[] args)
        {
            int[] seats = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            int result = MaxDistToClosest(seats);
        }

        private static int MaxDistToClosest(int[] seats)
        {
            int j = 0, maxDistance = 0;
            for (int i = 0; i < seats.Length; i++)
            {
                if(seats[i] == 1)
                {
                    if (j == -1)
                        maxDistance = i;
                    else
                        maxDistance = Math.Max(maxDistance, (i - j)/2);
                    j = i;
                }
            }
            int n = seats.Length;
            if (seats[n-1] == 0)
                maxDistance = Math.Max(maxDistance, n - j - 1);

            return maxDistance;

        }
    }
}
