using System;

namespace _167._Two_Sum_II___Input_array_is_sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TwoSum(new int[4] { 2, 7, 11, 15 }, 9));
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i != j)
                    {
                        if (numbers[i] + numbers[j] == target)
                        {
                            if (i < j)
                            {
                                return new int[2] { i + 1, j + 1 };
                            }
                            else
                            {
                                return new int[2] { j + 1, i + 1 };
                            }
                        }
                    }
                }
            }
            return numbers;
        }
    }
}
