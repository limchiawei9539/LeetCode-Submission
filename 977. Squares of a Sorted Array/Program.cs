using System;

namespace _977._Squares_of_a_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SortedSquares(new int[5] { -4, -1, 0, 3, 10 }));
        }

        public static int[] SortedSquares(int[] nums)
        {
            int i = 0;
            int j = nums.Length - 1;
            int current = nums.Length - 1;
            int[] arr = new int[nums.Length];

            if(nums.Length==1)
            {
                arr[0] = nums[0] * nums[0];
                return arr;
            }

            while (i < j)
            {
                if(Math.Abs(nums[i]) > Math.Abs(nums[j]))
                {
                    arr[current] = nums[i] * nums[i];
                    i++;
                }
                else
                {
                    arr[current] = nums[j] * nums[j];
                    j--;
                }
                current--;
            }
            return arr;
        }
    }
}
