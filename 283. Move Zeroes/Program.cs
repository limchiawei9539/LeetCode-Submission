using System;
using System.Diagnostics;

namespace _283._Move_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            MoveZeroes(new int[5] { 0, 1, 0, 3, 12 });
        }

        public static void MoveZeroes(int[] nums)
        {
            if (nums.Length <= 1 || nums == null)
            {
                return;
            }
            int idx = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                idx = i;
                while (nums[idx] == 0 && idx < nums.Length - 1)
                {
                    idx++;
                }
                var temp = nums[idx];
                nums[idx] = nums[i];
                nums[i] = temp;
            }
        }
    }
}
