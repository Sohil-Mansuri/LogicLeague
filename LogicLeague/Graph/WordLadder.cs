namespace LogicLeague.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/word-ladder/description/
    /// </summary>
    internal class WordLadder
    {
        public static int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            HashSet<string> wordSet = [.. wordList];

            Queue<(string word, int length)> queue = new();
            queue.Enqueue((beginWord, 1));
            wordSet.Remove(beginWord);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (current.word == endWord)
                {
                    return current.length;
                }

                for (int i = 0; i < current.word.Length; i++)
                {
                    var originalChar = current.word[i];
                    for (char ch = 'a'; ch <= 'z'; ch++)
                    {
                        current.word = current.word.Remove(i, 1).Insert(i, ch.ToString());
                        if (wordSet.Contains(current.word))
                        {
                            queue.Enqueue((current.word, current.length + 1));
                            wordSet.Remove(current.word);
                        }
                    }
                    current.word = current.word.Remove(i, 1).Insert(i, originalChar.ToString());
                }
            }

            return 0;
        }
    
    }
}
