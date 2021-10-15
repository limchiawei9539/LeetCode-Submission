using System;

namespace _344._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseString(new char[5] { 'h', 'e', 'l', 'l', 'o' });
        }

        public static void ReverseString(char[] s)
        {
            int i = 0;
            int j = s.Length - 1;
            while (i <= j)
            {
                var temp = s[i];
                s[i] = s[j];
                s[j] = temp;
                i++;
                j--;
            }
        }
    }
}
