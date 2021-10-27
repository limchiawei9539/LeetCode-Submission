using System;

namespace _75._Sort_Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            SortColors(new int[6] { 2, 0, 2, 1, 1, 0 });
        }

        public static void SortColors(int[] nums)
        {
            if (nums.Length <= 1 || nums == null)
            {
                return;
            }
            int idx = 0;
            int x = 0;
            int y = nums.Length - 1;
            while (idx <= y)
            {
                if (nums[idx] == 0)
                {
                    var temp = nums[x];
                    nums[x++] = nums[idx];
                    nums[idx++] = temp;
                }
                else if (nums[idx] == 2)
                {
                    var temp = nums[y];
                    nums[y--] = nums[idx];
                    nums[idx] = temp;
                }
                else
                {
                    idx++;
                }

                for(int i=0;i<nums.Length;i++)
                {
                    Console.WriteLine(nums[i]);
                }
            }
        }
    }
}
