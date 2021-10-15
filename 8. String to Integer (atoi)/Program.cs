using System;
using System.Text.RegularExpressions;

namespace _8._String_to_Integer__atoi_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyAtoi("  -42"));
        }

        public static int MyAtoi(string s)
        {
            s = s.Trim();
            bool is_pos = true;
            bool has_sign = false;
            bool has_digit = false;
            long output = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i]== '-' || s[i]=='+')
                {
                    if(has_sign||has_digit)
                    {
                        break;
                    }
                    is_pos = s[i] == '+' ? true : false;
                    has_sign = true;
                    continue;
                }

                if(int.TryParse(s[i].ToString(),out int digits))
                {
                    output *= 10;
                    output = is_pos ? output + digits : output - digits;

                    if(output >=int.MaxValue)
                    {
                        return int.MaxValue;
                    }
                    else if(output <= int.MinValue)
                    {
                        return int.MinValue;
                    }
                    has_digit = true;
                }
                else
                {
                    break;
                }
            }
            return (int)output;
        }
    }
}
