using System;
using System.Text;

namespace _557._Reverse_Words_in_a_String_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("Let's take LeetCode contest"));
        }

        public static string ReverseWords(string s)
        {
            var arr = new StringBuilder(s);
            int i = 0;
            int j = 0;
            var first = 0;

            for (int l = 0; l < arr.Length; l++)
            {
                if (arr[l] == ' ' || l == s.Length - 1)
                {
                    j = l == s.Length - 1 ? l : l - 1;
                    i = first;
                    while (i < j)
                    {
                        var temp = s[i];
                        arr[i] = s[j];
                        arr[j] = temp;
                        i++;
                        j--;
                    }
                    first = l + 1;
                }
            }
            return arr.ToString();
        }
    }
}
