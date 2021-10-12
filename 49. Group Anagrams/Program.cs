using System;
using System.Collections.Generic;
using System.Linq;

namespace _49._Group_Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GroupAnagrams(new string[6] { "eat", "tea", "tan", "ate", "nat", "bat" }));
        }

        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            return strs.GroupBy(x => new string(x.OrderBy(y => y).ToArray())).Select(x=>new List<string>(x) as IList<string>).ToList();
        }
    }
}
