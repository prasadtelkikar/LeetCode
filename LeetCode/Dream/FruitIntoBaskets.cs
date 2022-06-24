using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dream
{
    public class FruitIntoBaskets
    {
        public static void Main(string[] args)
        {
            int[] fruits = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            int result = TotalFruitsSlidingWindowCheated(fruits);
            Console.WriteLine(result);
        }

        //Sliding window example: Implement without cheating
        private static int TotalFruits(int[] fruits)
        {
            Dictionary<int, int> fruitDict = new Dictionary<int, int>();
            for(int i = 0; i < fruits.Length; i++)
            {
                if(fruitDict.ContainsKey(fruits[i]))
                    fruitDict[fruits[i]]++;
                else
                    fruitDict.Add(fruits[i], 1);
            }


            var filteredData = fruitDict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x=> x.Value);
            var sum = filteredData.Take(2).Select(x => x.Value).Sum();
            return sum;
        }

        //Failed sliding window attemp
        private static int TotalFruitsSlidingWindow(int[] fruits)
        {
            HashSet<int> window = new HashSet<int>();
            int j = 0, max = 0;
            for(int i = 0; i < fruits.Length; i++)
            {
                int currentTree = fruits[i];
                while(window.Contains(currentTree))
                {
                    //Here we are shifting now step forward in the window
                    window.Remove(fruits[j]);
                    j++;
                }
                window.Add(currentTree);
                //Here always i > j, because i iterate every time but j iterate only if it finds duplicate
                max = Math.Max(max, i - j + 1);
            }
            return max;

        }

        private static int TotalFruitsSlidingWindowCheated(int[] tree)
        {
            int[] map = new int[40001];
            int visitedTreeCount = 0;
            int max = 0;
            for (int l = 0, r = 0; r < tree.Length; r++)
            {
                //If new tree is present, then increment the visitedTree count.
                if (map[tree[r]] == 0)
                    visitedTreeCount++;
                //Increment the tree count
                map[tree[r]]++;
                //If there are more than two tree visited, then move the initially visited tree
                while (visitedTreeCount > 2)
                {
                    //Reduce tree count, from first
                    map[tree[l]]--;

                    //if there is no fruits from this tree then remove visisted tree count
                    if (map[tree[l]] == 0)
                        visitedTreeCount--;
                    //Move left side of window by one
                    l++;
                }
                //Take max
                max = Math.Max(max, r - l + 1);
            }
            return max;
        }
    }


}
