using System;
using System.Linq;

namespace _4._Median_of_Two_Sorted_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindMedianSortedArrays(new int[2] { 1, 2 }, new int[2] { 3, 4 }));
        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            nums1 = nums1.Concat(nums2).ToArray();
            Array.Sort(nums1);
            if (nums1.Count() % 2 == 0)
            {
                double med = nums1.Length / 2;
                double result = (double)(nums1[(int)med] + nums1[(int)(med - 1)]) / 2.0;
                return result;
            }
            else
            {
                return nums1[nums1.Length / 2];
            }
        }
    }
}
