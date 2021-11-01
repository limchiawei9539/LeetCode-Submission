using System;

namespace _130._Surrounded_Regions
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new char[4][];
            board[0] = new char[4] { 'X', 'X', 'X', 'X' };
            board[1] = new char[4] { 'X', 'O', 'O', 'X' };
            board[2] = new char[4] { 'X', 'X', 'O', 'X' };
            board[3] = new char[4] { 'X', 'O', 'X', 'X' };
            Solve(board);
        }

        public static void Solve(char[][] board)
        {
            var reference = new bool[board.Length][];
            for (int i = 0; i < board.Length; i++)
            {
                reference[i] = new bool[board[i].Length];
            }
            if (board == null || board.Length == 0 || board[0].Length == 0)
            {
                return;
            }
            var row = board.Length;
            var col = board[0].Length;
            for (var i = 0; i < row; i++)
            {
                for (var j = 0; j < col; j++)
                {
                    if (i == 0 || i == row - 1 || j == 0 || j == col - 1)
                    {
                        if (board[i][j] == 'O')
                        {
                            getRef(board, reference, i, j);
                        }
                    }
                }
            }

            for (var i = 0; i < row; i++)
            {
                var line = "";
                for (var j = 0; j < col; j++)
                {
                    if (board[i][j] == 'O')
                    {
                        board[i][j] = reference[i][j] ? 'O' : 'X';
                    }
                    line += board[i][j];
                }
                Console.WriteLine(line);
            }
        }

        public static void getRef(char[][] board, bool[][] reference, int i, int j)
        {
            if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || reference[i][j])
            {
                return;
            }

            if (board[i][j] == 'O')
            {
                reference[i][j] = true;
                getRef(board, reference, i + 1, j);
                getRef(board, reference, i - 1, j);
                getRef(board, reference, i, j + 1);
                getRef(board, reference, i, j - 1);
            }
        }
    }
}
