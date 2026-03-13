namespace LogicLeague.Tree
{
    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children { get; set; }
        public bool IsEndOfWord { get; set; }
        public TrieNode()
        {
            Children = [];
            IsEndOfWord = false;
        }
    }

    public class Trie
    {
        private TrieNode root = new();

        public Trie()
        {
        }

        public void Insert(string word)
        {
            var currentNode = root;
            foreach (var c in word)
            {
                if (currentNode.Children.ContainsKey(c))
                {
                    currentNode = currentNode.Children[c];
                }
                else
                {
                    var newNode = new TrieNode();
                    currentNode.Children.Add(c, newNode);
                    currentNode = newNode;
                }
            }
            currentNode.IsEndOfWord = true;
        }


        public bool Search(string word)
        {
            if (string.IsNullOrEmpty(word)) return false;

            var currentNode = root;
            foreach (var item in word)
            {
                if (currentNode.Children.ContainsKey(item))
                {
                    currentNode = currentNode.Children[item];
                }
                else
                {
                    return false;
                }
            }

            return currentNode.IsEndOfWord;
        }

        public bool StartsWith(string prefix)
        {
            if (string.IsNullOrEmpty(prefix)) return false;

            var currentNode = root;

            foreach (var item in prefix)
            {
                if (currentNode.Children.ContainsKey(item))
                {
                    currentNode = currentNode.Children[item];
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
