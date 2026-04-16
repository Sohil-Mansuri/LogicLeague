namespace LogicLeague.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/word-ladder-ii/description/
    /// </summary>
    internal class WordLadder2
    {
        public static IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            HashSet<string> wordSet = [.. wordList];
            Queue<(string word, List<string> path)> queue = new();

            IList<IList<string>> result = [];
            queue.Enqueue((beginWord, new List<string> { beginWord }));
            wordSet.Remove(beginWord);

            bool isFound = false;
            while (queue.Count > 0 && !isFound)
            {
                var levelSize = queue.Count;

                HashSet<string> visitedThisLevel = [];
                for (int j = 0; j < levelSize; j++)
                {
                    var current = queue.Dequeue();

                    if (current.word == endWord)
                    {
                        result.Add(current.path);
                        isFound = true;
                        continue;
                    }

                    for (int i = 0; i < current.word.Length; i++)
                    {
                        var originalChar = current.word[i];
                        for (char ch = 'a'; ch <= 'z'; ch++)
                        {
                            current.word = current.word.Remove(i, 1).Insert(i, ch.ToString());

                            if (wordSet.Contains(current.word))
                            {
                                visitedThisLevel.Add(current.word);
                                queue.Enqueue((current.word, new List<string>(current.path) { current.word }));
                            }
                        }
                        current.word = current.word.Remove(i, 1).Insert(i, originalChar.ToString());
                    }
                }

                foreach (var item in visitedThisLevel)
                {
                    wordSet.Remove(item);
                }
            }


            return result;
        }

    }
}
