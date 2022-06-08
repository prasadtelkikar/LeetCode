using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June_2022
{
    public class MergeSortedArray
    {
        public static void Main(string[] args)
        {
            //int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            //int[] nums2 = new int[] { 2, 5, 6 };
            //int m = 3;
            //int n = nums2.Length;
            int[] nums1 = new int[] { 0 };
            int[] nums2 = new int[] { 1 };
            int m = 0;
            int n = 1;

            MergeSortedArray mergeSortedArray = new MergeSortedArray();
            mergeSortedArray.Merge(nums1, m, nums2, n);
            Console.WriteLine(string.Join(" ", nums1));

        }

        private void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            m -=1;
            n-= 1;
            for (int i = nums1.Length - 1; i >= 0; i--)
            {
                if (n < 0)
                    break;
                if (m >= 0 && nums1[m] > nums2[n])
                    nums1[i] = nums1[m--];
                else
                    nums1[i] = nums2[n--];
            }
        }
    }
}
