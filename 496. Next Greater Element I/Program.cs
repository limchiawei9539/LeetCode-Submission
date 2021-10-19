using System;

namespace _496._Next_Greater_Element_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NextGreaterElement(new int[3] { 4, 1, 2 }, new int[4] { 1, 3, 4, 2 }));
        }

        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var len1 = nums1.Length;
            var len2 = nums2.Length;
            var i = 0;
            var j = 0;
            var k = 0;
            var arr = new int[len1];
            while (i < len1)
            {
                j = Array.IndexOf(nums2, nums1[i]);
                k = j + 1;
                if (k <= len2 - 1)
                {
                    while(k <= len2 - 1)
                    {
                        if (nums2[j] < nums2[k])
                        {
                            arr[i] = nums2[k];
                            break;
                        }
                        else
                        {
                            arr[i] = -1;
                        }
                        k++;
                    }
                }
                else
                {
                    arr[i] = -1;
                }
                i++;
            }
            return arr;
        }
    }
}
