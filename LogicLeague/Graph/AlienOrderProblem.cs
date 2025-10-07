using System.Text;

namespace LogicLeague.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/alien-dictionary/description/
    /// </summary>
    internal class AlienOrderProblem
    {
        // using DFS
        public static string AlienOrder(string[] words)
        {
            Dictionary<char, HashSet<char>> graph = [];
            StringBuilder result = new();

            foreach (var word in words)
            {
                foreach (var chars in word)
                {
                    if (!graph.TryGetValue(chars, out var _))
                        graph[chars] = [];
                }
            }

            for (int i = 0; i < words.Length - 1; i++)
            {
                var firstWord = words[i];
                var secondWord = words[i + 1];

                if (firstWord.Length > secondWord.Length && firstWord.StartsWith(secondWord))
                    return string.Empty;

                for (int j = 0; j < Math.Min(firstWord.Length, secondWord.Length); j++)
                {
                    if (firstWord[j] != secondWord[j])
                    {
                        graph[firstWord[j]].Add(secondWord[j]);
                        break;
                    }
                }
            }

            Dictionary<char, int> state = []; // 0 -unvisited, 1 - visting, 2 - visited

            foreach (var node in graph.Keys)
            {
                if (HasCycle(node))
                    return string.Empty;
            }

            bool HasCycle(char node)
            {
                if (state.TryGetValue(node, out var val))
                {
                    if (val == 1) return true;
                    if (val == 2) return false;
                }

                state[node] = 1;

                foreach (var edge in graph[node])
                {
                    if (HasCycle(edge)) return true;
                }

                state[node] = 2;
                result.Append(node);
                return false;
            }

            var revese = Reverse(result.ToString());

            return revese;
        }

        private static string Reverse(string input)
        {
            if (string.IsNullOrEmpty(input)) return "";
            return Reverse(input.Substring(1)) + input[0];
        }


        //Using BFS and Kahn's algorithem
        public static string AlienOrderV2(string[] words)
        {
            Dictionary<char, HashSet<char>> graph = [];
            Dictionary<char, int> inDegree = [];
            StringBuilder result = new();

            foreach (var word in words)
            {
                foreach (var chars in word)
                {
                    if (!graph.ContainsKey(chars))
                        graph[chars] = [];

                    if (!inDegree.ContainsKey(chars))
                        inDegree[chars] = 0;
                }
            }

            for (int i = 0; i < words.Length - 1; i++)
            {
                var firstWord = words[i];
                var secondWord = words[i + 1];

                if (firstWord.Length > secondWord.Length && firstWord.StartsWith(secondWord))
                    return string.Empty;

                for (int j = 0; j < Math.Min(firstWord.Length, secondWord.Length); j++)
                {
                    if (firstWord[j] != secondWord[j])
                    {
                        graph[firstWord[j]].Add(secondWord[j]);
                        inDegree[secondWord[j]]++;
                        break;
                    }
                }
            }

            Queue<char> queue = new(inDegree.Where(g => g.Value == 0).Select(s => s.Key));

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                result.Append(node);

                foreach (var item in graph[node])
                {
                    inDegree[item]--;
                    if (inDegree[item] == 0)
                        queue.Enqueue(item);
                }
            }

            if (result.Length != graph.Count)
                return string.Empty;

            return result.ToString();
        }
    }
}
