using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _451._Sort_Characters_By_Frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FrequencySort("tree"));
        }

        public static string FrequencySort(string s)
        {
            IDictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                {
                    dict.Add(s[i], 1);
                }
                else
                {
                    dict[s[i]] += 1;
                }
            }
            var str = new StringBuilder();
            var list = dict.OrderByDescending(x => x.Value);
            foreach (var l in list)
            {
                for (int i = 0; i < l.Value; i++)
                {
                    str.Append(l.Key);
                }
            }
            return str.ToString();
        }
    }
}
