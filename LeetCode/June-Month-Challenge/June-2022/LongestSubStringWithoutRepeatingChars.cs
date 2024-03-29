﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June_2022
{
    public class LongestSubStringWithoutRepeatingChars
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int result = LengthOfLongestSubStringFunc(s);
            Console.WriteLine(result);
        }

        //Cheated, this can be imporved using hashset. break if it contains.Lets try it tomorrow
        private static int LengthOfLongestSubstring(string s)
        {
            char[] sa = s.ToCharArray();
            int count = 0;
            if (sa.Length > 0)
                count = 1;
            string sub = "";
            for (int i = 0; i< sa.Length; i++)
            {
                sub = sa[i].ToString();
                for (int j = i+1; j < sa.Length; j++)
                {
                    if (sub.Contains(sa[j]))
                        break;
                    else
                        sub += sa[j];
                }
                count = count > sub.Length ? count : sub.Length;
            }
            return count;
        }

        //Sliding window algorithm: https://youtu.be/4i6-9IzQHwo
        private static int LengthOfLongestSubStringFunc(string s)
        {
            if(string.IsNullOrEmpty(s))
                return 0;
            int  j = 0, max = 0;
            HashSet<char> chars = new HashSet<char>();  
            for (int i = 0; i < s.Length; i++)
            {
                var ch  = s[i];
                while(chars.Contains(ch))
                {
                    //Key point, do not remove just duplicate char
                    //Remove all character, till the duplicate character
                    chars.Remove(s[j]);
                    j++;
                }
                chars.Add(ch);
                max = Math.Max(max, i - j + 1);
            }
            return max;
        }
    }
}
