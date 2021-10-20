using System;

namespace _151._Reverse_Words_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("    the sky  is    blue"));
        }

        public static string ReverseWords(string s)
        {
            s = s.Trim();
            var result = "";
            var arr = s.Split(' ');
            for (int i = arr.Length-1; i >=0; i--)
            {
                if (!String.IsNullOrWhiteSpace(arr[i]))
                {
                    result += arr[i];
                    if (i > 0)
                    {
                        result += " ";
                    }
                }
            }
            return result;
        }
    }
}
