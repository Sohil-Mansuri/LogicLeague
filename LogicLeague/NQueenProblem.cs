
using System.Text;

namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/n-queens/
    /// </summary>
    internal class NQueenProblem
    {
        public static IList<IList<string>> SolveNQueens(int n)
        {
            IList<IList<string>> result = [];

            string[][] board = new string[n][];

            for (int i = 0; i < n; i++)
            {
                board[i] = new string[n];
                for (int j = 0; j < n; j++)
                {
                    board[i][j] = ".";
                }
            }

            Backtrack(result, board, 0, n);

            return result;
        }

        private static void Backtrack(IList<IList<string>> result, string[][] board, int column, int n)
        {
            if (column == n)
            {
                result.Add(Generate(board));
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (IsValid(board, i, column, n))
                {
                    board[i][column] = "Q";
                    Backtrack(result, board, column + 1, n);
                    board[i][column] = ".";
                }
            }
        }

        private static bool IsValid(string[][] board, int row, int column, int n)
        {
            //horizonal
            for (int j = 0; j < column; j++)
            {
                if (board[row][j] == "Q") return false;
            }

            //left diagonal
            for (int i = row, j = column; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i][j] == "Q") return false;
            }

            //right diagonal
            for (int i = row, j = column; i < n && j >= 0; i++, j--)
            {
                if (board[i][j] == "Q") return false;
            }

            return true;
        }

        private static List<string> Generate(string[][] board)
        {
            var result = new List<string>(board.Length);

            for (int i = 0; i < board.Length; i++)
            {
                var sb = new StringBuilder(board[i].Length);
                for (int j = 0; j < board[i].Length; j++)
                {
                    sb.Append(board[i][j]);
                }
                result.Add(sb.ToString());
            }

            return result;
        }
    }
}
