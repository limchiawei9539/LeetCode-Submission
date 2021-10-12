using System;

namespace _704._Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int Search(int[] nums, int target)
        {
            var res = -1;
            int low = 0;
            int high = nums.Length - 1;
            if(!Array.Exists(nums,t => t == target))
            {
                return -1;
            }
            while (low <= high)
            {
                var mid = low + (high - low) / 2;
                res = nums[mid];
                if (res == target)
                {
                    return mid;
                }
                else if (res > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return res;
        }
    }
}
