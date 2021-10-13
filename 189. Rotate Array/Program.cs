using System;

namespace _189._Rotate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Rotate(new int[7] { 1, 2, 3, 4, 5, 6, 7 }, 3);
        }

        public static void Rotate(int[] nums, int k)
        {
            if (nums.Length <= 1 || nums == null || k == 0 || nums.Length == k)
            {
                return;
            }
            int i = 0;
            int[] arr = new int[nums.Length];
            int idx = nums.Length - (k % nums.Length);
            while (i < nums.Length)
            {
                arr[i] = nums[idx];
                if (idx == nums.Length - 1)
                {
                    idx = 0;
                }
                else
                {
                    idx++;
                }
                i++;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                nums[j] = arr[j];
            }
        }
    }
}
