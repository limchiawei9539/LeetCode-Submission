using System;

namespace _1._Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TwoSum(new int[4] { 2, 7, 11, 15 }, 9));
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] indices = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                int j = i;
                while (j != nums.Length)
                {
                    if ((nums[i] + nums[j] == target) && i != j)
                    {
                        indices[0] = i;
                        indices[1] = j;
                    }
                    j++;
                }
            }
            return indices;
        }
    }
}
