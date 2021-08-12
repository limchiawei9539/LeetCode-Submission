using System;

namespace _6._ZigZag_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert("ABCDE", 4));
        }

        public static string Convert(string s, int numRows)
        {
            var str = String.Empty;
            char[,] arr = new char[s.Length, numRows];
            var row = 0;
            var col = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if(numRows==1)
                {
                    while(i<s.Length)
                    {
                        arr[col, row] = s[i];
                        i++;
                        col++;
                    }
                }
                else if (row != numRows)
                {
                    arr[col, row] = s[i];
                    if (row <= numRows - 1)
                    {
                        row++;
                    }
                }
                else
                {
                    arr = printFromBottom(s, i, row, col, arr); // i become n-th char in string after first corner
                    i += getCount(s, i, row, col, arr) - 1;
                    row = 0;
                    col += numRows - 1;
                }
            }
            for(int i =0;i<arr.GetLength(1);i++)
            {
                for(int j=0;j<arr.GetLength(0);j++)
                {
                    if(arr[j,i]!='\0')
                    {
                        str += arr[j, i];
                    }
                }
            }
            return str;
        }

        public static char[,] printFromBottom(string s, int idx, int row, int col, char[,] arr)
        {
            row--;
            while (row > 1 && idx<s.Length)
            {
                arr[col + 1, row - 1] = s[idx];
                if (row > 0)
                    row--;
                    col++;
                    idx++;
            }
            return arr;
        }

        public static int getCount(string s, int idx, int row, int col, char[,] arr)
        {
            var count = 0;
            row--;
            while (row > 1 && idx < s.Length)
            {
                arr[col + 1, row - 1] = s[idx];
                if (row > 0)
                    row--;
                col++;
                idx++;
                count++;
            }
            return count;
        }
    }
}
