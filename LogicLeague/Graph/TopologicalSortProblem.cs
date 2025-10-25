
namespace LogicLeague.Graph
{
    public class TopologicalSortProblem
    {
        public static IList<int> TopologicalSort(int[][] edges)
        {
            Dictionary<int, HashSet<int>> graph = [];

            foreach (var edge in edges)
            {
                if (!graph.ContainsKey(edge[0]))
                    graph[edge[0]] = [];

                if (!graph.ContainsKey(edge[1]))
                    graph[edge[1]] = [];         // just empty node

                graph[edge[0]].Add(edge[1]);
            }

            HashSet<int> visited = [];
            HashSet<int> path = [];
            Stack<int> stack = [];

            foreach (var node in graph.Keys)
            {
                if (!visited.Contains(node))
                    DFS(graph, node, visited, stack, path);
            }

            IList<int> sorted = [];

            while (stack.Count > 0)
            {
                sorted.Add(stack.Pop());
            }

            return sorted;
        }


        private static void DFS(Dictionary<int, HashSet<int>> graph,
            int node,
            HashSet<int> visited,
            Stack<int> stack,
            HashSet<int> path)
        {
            if (path.Contains(node))
                throw new Exception("Cycle detected");

            visited.Add(node);
            path.Add(node);

            foreach (var neighbour in graph[node])
            {
                if (!visited.Contains(neighbour))
                    DFS(graph, neighbour, visited, stack, path);
            }

            path.Remove(node);
            stack.Push(node);
        }

        // Kahn's algorithem
        public static IList<int> TopologicalSortV2(int[][] edges)
        {
            Dictionary<int, HashSet<int>> graph = [];
            Dictionary<int, int> inDegree = [];

            foreach (var edge in edges)
            {
                if (!graph.ContainsKey(edge[0]))
                    graph[edge[0]] = [];

                if (!graph.ContainsKey(edge[1]))
                    graph[edge[1]] = [];

                graph[edge[0]].Add(edge[1]);

                inDegree[edge[1]] = inDegree.GetValueOrDefault(edge[1], 0) + 1;
                inDegree[edge[0]] = inDegree.GetValueOrDefault(edge[0], 0);
            }

            Queue<int> queue = new(inDegree.Where(w => w.Value == 0).Select(s => s.Key));

            IList<int> result = [];
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                result.Add(current);

                foreach (var neighbour in graph[current])
                {
                    inDegree[neighbour]--;
                    if (inDegree[neighbour] == 0)
                        queue.Enqueue(neighbour);
                }
            }

            if (result.Count != graph.Count)
                throw new InvalidOperationException("Cycle detected");

            return result;
        }

    }
}
