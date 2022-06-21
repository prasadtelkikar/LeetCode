using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June_2022
{
    public class FurthestBuildingToReach
    {
        public static void Main(string[] args)
        {
            int[] height = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bricks = Convert.ToInt32(Console.ReadLine());
            int ladders = Convert.ToInt32(Console.ReadLine());

            int result = FurthestBuilding(height, bricks, ladders);
            Console.WriteLine(result);
        }

        //Time Limit exceed... Use priority queue
        private static int FurthestBuilding(int[] height, int bricks, int ladders)
        {
            Dictionary<int, int> temp = new Dictionary<int, int>();
            int i = 0;
           // int maxValue = int.MinValue;
            for (i = 0; i < height.Length-1; i++)
            {
                int diff = height[i+1] - height[i];
                if (diff > 0)
                {
                    bricks -= diff;
                    temp.Add(i, diff);
                    if(bricks < 0)
                    {
                        //We should use priority queue
                        var maxValue = temp.Max(x => x.Value);
                        ladders--;
                        var top = temp.First(x => x.Value == maxValue);
                        bricks += top.Value;
                        temp.Remove(top.Key);
                    }
                    if (ladders < 0)
                        break;
                }
            }
            return i;
        }
    }
}
