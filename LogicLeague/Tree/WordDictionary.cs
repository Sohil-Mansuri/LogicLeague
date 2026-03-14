namespace LogicLeague.Tree
{
    /// <summary>
    /// https://leetcode.com/problems/design-add-and-search-words-data-structure/
    /// </summary>
    public class WordDictionary
    {
        private readonly TrieNode root;

        public WordDictionary()
        {
            root = new();
        }

        public void AddWord(string word)
        {
            var currentNode = root;

            foreach (var c in word)
            {
                if (!currentNode.Children.ContainsKey(c))
                {
                    currentNode.Children.Add(c, new TrieNode());
                }

                currentNode = currentNode.Children[c];
            }

            currentNode.IsEndOfWord = true;
        }

        public bool Search(string word)
        {
            return DFS(word, 0, root);
        }

        public bool DFS(string word, int index, TrieNode currentNode)
        {
            if (index == word.Length)
            {
                return currentNode.IsEndOfWord;
            }

            var c = word[index];

            if (c == '.')
            {
                foreach (var child in currentNode.Children)
                {
                    if (DFS(word, index + 1, child.Value))
                    {
                        return true;
                    }
                }

                return false;
            }

            if (!currentNode.Children.ContainsKey(c))
            {
                return false;
            }

            return DFS(word, index + 1, currentNode.Children[c]);          
        }
    }

}
