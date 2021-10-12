using System;
using System.Diagnostics;
using System.Linq;

namespace _463._Island_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = new int[1][];
            //grid[0] = new int[4] { 0, 1, 0, 0 };
            //grid[1] = new int[4] { 1, 1, 1, 0 };
            //grid[2] = new int[4] { 0, 1, 0, 0 };
            //grid[3] = new int[4] { 1, 1, 0, 0 };
            grid[0] = new int[2] { 1, 0 };

            Console.WriteLine(IslandPerimeter(grid));
        }

        public static int IslandPerimeter(int[][] grid)
        {
            var perimeter = 0;
            var newgrid = grid.SelectMany((array, row) => array.Select((element, column) => new { Row = row, Column = column, Value = element }));

            foreach (var n in newgrid.Where(x => x.Value == 1))
            {
                Console.WriteLine(getBorder(n.Row, n.Column, grid));
                perimeter += getBorder(n.Row, n.Column, grid);
            }
            return perimeter;
        }

        public static int getBorder(int i, int j, int[][] grid)
        {
            var count = 0;
            if (i - 1 < 0)
            {
                count++;
            }
            else if (grid[i - 1][j] == 0)
            {
                count++;
            }

            if (i + 1 >= grid[0].Length)
            {
                count++;
            }
            else if (grid[i + 1][j] == 0)
            {
                count++;
            }

            if (j - 1 < 0)
            {
                count++;
            }
            else if (grid[i][j - 1] == 0)
            {
                count++;
            }

            if (j + 1 >= grid.Length)
            {
                count++;
            }
            else if (grid[i][j + 1] == 0)
            {
                count++;
            }
            return count;
        }
    }
}
