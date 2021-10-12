using System;

namespace _374._Guess_Number_Higher_or_Lower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int GuessNumber(int n)
        {
            int low = 1;
            int high = n;
            while (low <= high)
            {
                var mid = low + (high - low) / 2;
                var res = guess(mid);
                if (res == 0)
                {
                    return mid;
                }
                else if (res < 0)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }

        //---ignore code below---//
        public int guess(int n)
        {
            return n;
        }
    }
}
