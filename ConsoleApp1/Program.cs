using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
        }

        public static int LengthOfLongestSubstring(string s)
        {
            var longestSS = string.Empty;
            var count = 0;
            var start = 0;
            var length = 0;
            for (int i = start; i < s.Length; i++)
            {
                if (!longestSS.Contains(s[i]))
                {
                    longestSS += s[i];
                    count++;
                }
                else
                {
                    length = Math.Max(count, length);
                    longestSS = string.Empty;
                    i = start++;
                    count = 0;
                }
            }
            length = Math.Max(count, length);
            return length;
        }


    }
}
