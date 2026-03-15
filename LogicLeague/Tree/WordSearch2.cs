
namespace LogicLeague.Tree
{
    /// <summary>
    /// https://leetcode.com/problems/word-search-ii/description/
    /// </summary>
    internal class WordSearch2
    {
        public static IList<string> FindWords(char[][] board, string[] words)
        {
            IList<string> result = [];
            var root = new TrieNode();
            foreach (var word in words)
            {
                var node = root;
                foreach (var c in word)
                {
                    if (!node.Children.ContainsKey(c))
                    {
                        node.Children[c] = new TrieNode();
                    }
                    node = node.Children[c];
                }

                node.IsEndOfWord = true;
                node.Word = word;
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    DFS(root, board, i, j, result);
                }
            }

            return result;
        }

        private static void DFS(TrieNode node, char[][] board, int i, int j, IList<string> result)
        {
            if (i < 0 || i >= board.Length || j < 0 || j >= board[i].Length)
                return;

            char c = board[i][j];
            if (c == '#' || !node.Children.ContainsKey(c))
                return;

            var child = node.Children[c];

            if (child.IsEndOfWord)
            {
                result.Add(child.Word);
                child.IsEndOfWord = false;
            }

            board[i][j] = '#';

            DFS(child, board, i + 1, j, result);
            DFS(child, board, i - 1, j, result);
            DFS(child, board, i, j + 1, result);
            DFS(child, board, i, j - 1, result);

            board[i][j] = c;

            if (child.Children.Count == 0)
            {
                node.Children.Remove(c);
            }
        }
    }
}
