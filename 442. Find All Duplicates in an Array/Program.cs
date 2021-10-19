using System;
using System.Collections.Generic;
using System.Linq;

namespace _442._Find_All_Duplicates_in_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindDuplicates(new int[8] { 4, 3, 2, 7, 8, 2, 3, 1 }));
        }

        public static IList<int> FindDuplicates(int[] nums)
        {
            var result = new List<int>();
            if (nums == null || nums.Length <= 1)
            {
                return new List<int>();
            }
            var test = nums.GroupBy(x => x).Where(x => x.Count() > 1).ToList();
            foreach(var t in test)
            {
                result.Add(t.Key);
            }
            return result;
        }
    }
}
