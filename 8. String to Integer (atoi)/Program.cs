using System;
using System.Text.RegularExpressions;

namespace _8._String_to_Integer__atoi_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyAtoi("-42"));
        }

        public static int MyAtoi(string s)
        {
            long.TryParse(s.Trim(),out long ss);
            long test = long.Parse(Math.Pow(2, 31).ToString());
            if(s[0]!=' ' && (s[0]!='-' && s[0]!='+' && !char.IsDigit(s[0])))
            {
                return 0;
            }
            else if(ss > test)
            {
                return Int32.Parse((test-1).ToString());
            }
            else if (ss < test * -1)
            {
                return Int32.Parse((test*-1 + 1).ToString());
            }
            s.Trim();
            s = Regex.Replace(s, "[^0-9]", "");
            Int32.TryParse(s, out int result);
            return result;
        }
    }
}
