using System;
using System.Linq;

namespace _850._Rectangle_Area_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] input = new int[1][];
            input[0] = new int[4] { 0, 2, 2, 0 };
            Console.WriteLine(RectangleArea(input));
        }

        public static int RectangleArea(int[][] rectangles)
        {
            var result = 0;
            int[,] jagged = new int[10000, 10000];
            foreach(var r in rectangles)
            {
                for (int i = r[0]; i < r[2]; i++)
                {
                    for (int j = r[1]; j < r[3]; j++)
                    {
                        jagged[i,j]= 1;
                        Console.WriteLine($"{i} {j}");
                    }
                }
            }
            foreach(var j in jagged)
            {
                result += j;
            }
            return result;
        }
    }
}
