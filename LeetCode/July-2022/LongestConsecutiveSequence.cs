using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace July_2022
{
    public class LongestConsecutiveSequence
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int result = LongestConsecutive(nums);
        }

        private static int LongestConsecutive(int[] nums)
        {
            //ToRemove duplicates
            HashSet<int> hNum = nums.ToHashSet();
            if (nums.Length == 0)
                return 0;
            SortedDictionary<int, bool> map = new SortedDictionary<int, bool>();
            //Store all nums with true as a value
            //Here true denotes all nums are start of the sequence, which is not true in all cases
            foreach (int num in hNum)
            {
                if (!map.ContainsKey(num))
                    map.Add(num, true);
            }

            //Set false to all non starting elements
            foreach(var num in hNum)
                map[num] = !map.ContainsKey(num - 1);

            int max = int.MinValue;
            foreach(int num in hNum)
            {
                if(map.TryGetValue(num, out bool isStart) && isStart)
                {
                    int sequence = 1;
                    while(map.TryGetValue(num + sequence, out bool isSequence) && !isSequence)
                        sequence++;

                    max = Math.Max(max, sequence);
                }
            }
            return max;
        }
    }
}
