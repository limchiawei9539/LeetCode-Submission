using System;
using System.Diagnostics;

namespace _279._Perfect_Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumSquares(12));
        }

        public static int NumSquares(int n)
        {
            int[] arr = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                int val = 1;
                int count = int.MaxValue;
                while (val * val <= i)
                {
                    count = Math.Min(count, arr[i - val * val]);
                    val++;
                }
                arr[i] = count+1;
                Debug.WriteLine($"{i} : {arr[i]}");
            }
            return arr[n];
        }
    }
}
