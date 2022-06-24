using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class AddToArray
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int k = Convert.ToInt32(Console.ReadLine());

            IList<int> list = AddToArrayFormNum(nums, k);
            Console.WriteLine(String.Join(", ", list));
        }

        //Turned k into array
        private static IList<int> AddToArrayForm(int[] num, int k)
        {
            IList<int> list = new List<int>();
            IList<int> secondNum = new List<int>();
            for (;k != 0; k /= 10)
                secondNum.Add(k % 10);
            num = num.Reverse().ToArray();
            int carry = 0;
            int maxLength = Math.Max(num.Length, secondNum.Count);
            for (int i = 0; i < maxLength; i++)
            {
                int sum = 0;
                if(i < num.Length)
                    sum += num[i];
                if(i < secondNum.Count)
                    sum+= secondNum[i];
                if (carry != 0)
                    sum += carry;

                var lastDigit = sum % 10;
                carry = sum / 10;
                list.Add(lastDigit);
            }
            if(carry != 0)
                list.Add(carry);

            return list.Reverse().ToList();
        }

        //This is not possible as range of num is 1 <= num.length <= 10^4
        private static IList<int> AddToArrayFormNum(int[] num, int k)
        {
            long number = 0;
            List<int> list = new List<int>();   
            for (int i = 0; i < num.Length; i++)
                number = number * 10 + num[i];
            long total = number + k;
            for (; total != 0; total /=10)
                list.Add((int)(total%10));
            list.Reverse();
            return list;
        }
    }
}
