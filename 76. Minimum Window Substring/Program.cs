using System;
using System.Collections.Generic;
using System.Linq;

namespace _76._Minimum_Window_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinWindow("abacfffaaa", "abc"));
        }

        public static string MinWindow(string s, string t)
        {
            int count = 0;
            int start = 0;
            int correct = 0;
            string result = string.Empty;
            string min = string.Empty;
            List<char> list = new List<char>();
            foreach (var t1 in t)
            {
                list.Add(t1);
            }
            while (count < s.Length)
            {
                if (list.Where(x => s.Substring(start, count).Count(y => y == x) > 1).Count() < t.Length)
                {
                    count++;
                    
                    result = s.Substring(start, count);
                }
                else
                {
                    start = count;
                    count++;
                }
            }
            return result;
        }
    }
}
