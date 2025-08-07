
namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/word-search/description/
    /// </summary>
    internal class WoardSearch
    {
        public static bool Exist(char[][] board, string word)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    var isFound = Backtrack(board, i, j, word, 0);
                    if (isFound) return true;
                }
            }

            return false;
        }

        private static bool Backtrack(char[][] board, int row, int column, string word, int index)
        {
            if (index >= word.Length) return true;

            if (row < 0 || row >= board.Length || column < 0 || column >= board[0].Length || board[row][column] != word[index])
                return false;

            //matched
            int[] rowDirections = [0, 1, 0, -1];
            int[] columnDirection = [1, 0, -1, 0];
            board[row][column] = '#';

            bool result = false;
            for (int k = 0; k < rowDirections.Length; k++)
            {
                result = Backtrack(board, row + rowDirections[k], column + columnDirection[k], word, index + 1);
                if (result) break;
            }

            board[row][column] = word[index];
            return result;
        }
    }
}
