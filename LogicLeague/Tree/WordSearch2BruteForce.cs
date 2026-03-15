

namespace LogicLeague.Tree
{
    /// <summary>
    /// https://leetcode.com/problems/word-search-ii/description/
    /// </summary>
    internal static class WordSearch2BruteForce
    {
        public static IList<string> FindWords(char[][] board, string[] words)
        {
            IList<string> result = [];
            foreach (var word in words)
            {
                if (IsPresent(word, board))
                {
                    result.Add(word);
                }
            }

            return result;
        }

        private static bool IsPresent(string word, char[][] board)
        {
            if (word is null || board is null) return false;


            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (DFS(board, i, j, word))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool DFS(char[][] board, int i, int j, string word)
        {
            if (string.IsNullOrEmpty(word)) return true;

            if (i < 0 || i >= board.Length || j < 0 || j >= board[i].Length || board[i][j] != word[0])
            {
                return false;
            }

            board[i][j] = '#';

            var isPresent = DFS(board, i + 1, j, word.Substring(1)) ||
                   DFS(board, i - 1, j, word.Substring(1)) ||
                   DFS(board, i, j + 1, word.Substring(1)) ||
                   DFS(board, i, j - 1, word.Substring(1));

            board[i][j] = word[0];

            return isPresent;
        }
    }
}
