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

        //C# does not have in-built Priority queue, so I used SortedList
        private static int FurthestBuilding(int[] height, int bricks, int ladders)
        {
            //diff = key, i++ = Value
            SortedList<int, int> temp = new SortedList<int, int>();
            int i = 0;
           // int maxValue = int.MinValue;
            for (i = 0; i < height.Length-1; i++)
            {
                int diff = height[i+1] - height[i];
                if (diff > 0)
                {
                    bricks -= diff;
                    if(temp.ContainsKey(diff))
                        temp[diff]++;
                    else
                        temp.Add(diff, 1);
                    if(bricks < 0)
                    {
                        //We should use priority queue
                        var maxDiff = temp.Keys.Max();
                        ladders--;
                        bricks += maxDiff;
                        if(temp[maxDiff] == 1)
                            temp.Remove(maxDiff);
                        else
                            temp[maxDiff]--;
                    }
                    if (ladders < 0)
                        break;
                }
            }
            return i;
        }
    }
}
