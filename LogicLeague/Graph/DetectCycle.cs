
namespace LogicLeague.Graph
{
    internal class DetectCycle
    {
        //for undirected
        public static bool IsCycle(int[][] edges)
        {
            Dictionary<int, HashSet<int>> graph = [];

            foreach (var edge in edges)
            {
                if (!graph.ContainsKey(edge[0]))
                    graph[edge[0]] = [];

                if (!graph.ContainsKey(edge[1]))
                    graph[edge[1]] = [];

                graph[edge[0]].Add(edge[1]);
                graph[edge[1]].Add(edge[0]);
            }

            HashSet<int> visited = [];
            foreach (var node in graph.Keys)
            {
                if (!visited.Contains(node) && BFS(graph, visited, node))
                    return true;
            }

            return false;
        }

        private static bool BFS(Dictionary<int, HashSet<int>> graph, HashSet<int> visited, int node)
        {
            Queue<(int node, int parent)> queue = [];
            queue.Enqueue((node, -1));
            visited.Add(node);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                foreach (var neighbour in graph[current.node])
                {
                    if (!visited.Contains(neighbour))
                    {
                        visited.Add(neighbour);
                        queue.Enqueue((neighbour, current.node));
                    }
                    else if (neighbour != current.parent)
                        return true;
                }
            }

            return false;

        }

        public static bool IsCycleV2(int[][] edges)
        {
            Dictionary<int, HashSet<int>> graph = [];

            foreach (var edge in edges)
            {
                if (!graph.ContainsKey(edge[0]))
                    graph[edge[0]] = [];

                if (!graph.ContainsKey(edge[1]))
                    graph[edge[1]] = [];

                graph[edge[0]].Add(edge[1]);
                graph[edge[1]].Add(edge[0]);
            }

            HashSet<int> visited = [];

            foreach (var node in graph.Keys)
            {
                if (!visited.Contains(node) && DFS(graph, visited, node, -1))
                    return true;
            }

            return false;
        }

        private static bool DFS(Dictionary<int, HashSet<int>> graph, HashSet<int> visited, int node, int parent)
        {
            visited.Add(node);

            foreach (var neighbour in graph[node])
            {
                if (!visited.Contains(neighbour))
                {
                    if (DFS(graph, visited, neighbour, node))
                        return true;
                }
                else if (neighbour != parent)
                    return true;
            }

            return false;
        }
    }
}
