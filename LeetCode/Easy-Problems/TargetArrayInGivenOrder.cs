using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class TargetArrayInGivenOrder
    {
        public static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var index = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            TargetArrayInGivenOrder targetArrayObj = new TargetArrayInGivenOrder();
            var result = targetArrayObj.CreateTargetArray(nums, index);
        }

        private int[] CreateTargetArray(int[] nums, int[] index)
        {
            Dictionary<int, List<int>> temp = new Dictionary<int, List<int>>();
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var indexI = index[i];
                var num = nums[i];
                if(temp.ContainsKey(indexI))
                    temp[indexI].Add(num);
                else
                    temp.Add(indexI, new List<int>() {num});

            }
            foreach(var kvp in temp)
            {
                kvp.Value.Reverse();
                list.AddRange(kvp.Value);
            }
            return list.ToArray();
        }
    }
}
