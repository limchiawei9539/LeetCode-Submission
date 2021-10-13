using System;
using System.Collections.Generic;
using System.Linq;

namespace _290._Word_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(("abba", "dog cat cat fish"));
        }

        public static bool WordPattern(string pattern, string s)
        {
            var ss = s.Split(' ');
            var list = new List<matchObject>();
            var sidx = 0;
            if (pattern.Length != ss.Length)
            {
                return false;
            }
            foreach (var sss in ss)
            {
                if (!list.Any(x => x.Char == pattern[sidx]))
                {
                    var obj = new matchObject()
                    {
                        Char = pattern[sidx],
                        Str = ss[sidx]
                    };
                    list.Add(obj);
                }
                else
                {
                    var obj = new matchObject()
                    {
                        Char = '?',
                        Str = ss[sidx]
                    };
                    list.Add(obj);
                }
                sidx++;
            }
            var idx = 0;
            var res = "";
            while (idx < ss.Length)
            {
                res += list.Any(x => x.Str == ss[idx] && x.Char != '?') ? list[list.IndexOf(list.Where(x => x.Str == ss[idx]).First())].Char : '?';
                idx++;
            }
            if (res == pattern)
            {
                return true;
            }
            return false;
        }

        public class matchObject
        {
            public char Char { get; set; }
            public string Str { get; set; }
        }
    }
}
