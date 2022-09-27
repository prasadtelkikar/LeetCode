using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Easy_II
{
    public class FindPivotalIndex
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int endSum = nums.Sum();
            int startSum = 0;
            List<PivotalIndex> pIndex = new List<PivotalIndex>();
            for(int i = 0; i < nums.Length; i++)
            {
                endSum = endSum - nums[i];
                pIndex.Add(new PivotalIndex(i, startSum, endSum));
                startSum = startSum + nums[i];
            }

            var result = pIndex.FirstOrDefault(x => x.LeftSum == x.RightSum)?.Index ?? -1;
            Console.WriteLine(result);
        }
    }

    public class PivotalIndex
    {
        public int Index { get; set; }

        public int LeftSum { get; set; }

        public int RightSum { get; set; }

        public PivotalIndex(int index, int leftSum, int rightSum)
        {
            this.Index = index;
            this.LeftSum = leftSum;
            this.RightSum = rightSum;
        }
    }
}
