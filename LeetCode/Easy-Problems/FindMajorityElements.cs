using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class FindMajorityElements
    {
        public static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int result = MajorityElement(arr);
            Console.WriteLine(result);
        }

        private static int MajorityElement(int[] arr)
        {
            int middle = arr.Length/2;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int i in arr)
            {
                if(dict.ContainsKey(i))
                    dict[i] = ++dict[i];
                else
                    dict.Add(i, 1);
            }
            foreach (var kvp in dict)
            {
                if (kvp.Value > middle)
                    return kvp.Key;
            }
            return 0;
        }
    }
}
