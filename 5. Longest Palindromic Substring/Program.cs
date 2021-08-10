using System;

namespace _5._Longest_Palindromic_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestPalindrome("qa11qaqqqxabax"));
        }

        public static string LongestPalindrome(string s)
        {
            string result = string.Empty;
            int maxLength = -1;
            for (int i = 0; i < s.Length; i++)
            {
                int l1 = getPalindromeLength(s, i, i);
                if (l1 > maxLength)
                {
                    maxLength = l1;
                    int l = i - (l1 - 1) / 2;
                    int r = i + (l1 - 1) / 2;
                    result = s.Substring(l, r - l + 1);
                }

                int l2 = getPalindromeLength(s, i, i + 1);
                if (l2 > maxLength)
                {
                    maxLength = l2;
                    int l = i - (l2 - 2) / 2;
                    int r = i + 1 + (l2 - 2) / 2;
                    result = s.Substring(l, r - l + 1);
                }
            }
            return result;
        }

        public static int getPalindromeLength(string s, int left, int right)
        {
            int result = 1;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                result = right - left + 1;
                left--;
                right++;
            }
            return result;
        }
    }
}
