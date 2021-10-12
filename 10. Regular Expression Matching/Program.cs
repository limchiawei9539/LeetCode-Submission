using System;

namespace _10._Regular_Expression_Matching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsMatch("mississippi", "mis*is*p*."));
        }

        public static bool IsMatch(string s, string p)
        {
            var idx = 0;
            var pidx = 0;
            var pointer = 0;
            while (pidx < p.Length && idx < s.Length)
            {
                if (p[pidx] == '*')
                {
                    pointer = idx;
                    if (!s.Substring(idx, s.Length - 1).Contains(s[pointer]) && pidx < p.Length - 1)
                    {
                        pidx++;
                        idx++;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (p[pidx] == '.')
                {
                    //do nothing
                }
                else if (s[idx] != p[pidx])
                {
                    return false;
                }
                idx++;
                pidx++;
            }
            return true;
        }
    }
}
