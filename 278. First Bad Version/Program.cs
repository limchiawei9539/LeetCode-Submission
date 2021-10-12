using System;

namespace _278._First_Bad_Version
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int FirstBadVersion(int n)
        {
            int low = 1;
            int high = n;
            while (low <= high)
            {
                var mid = low + (high - low) / 2;
                var res = IsBadVersion(mid);
                if (res)
                {
                    if (IsBadVersion(mid + 1))
                    {
                        high = mid - 1;
                    }
                    else if (!IsBadVersion(mid + 1))
                    {
                        return mid;
                    }
                }
                else if (!res)
                {
                    low = mid + 1;
                }
            }
            return low;
        }

        //---ignore code below---//
        public static bool IsBadVersion(int n)
        {
            return true;
        }
    }
}
