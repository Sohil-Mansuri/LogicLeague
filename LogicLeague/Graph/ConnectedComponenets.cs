
namespace LogicLeague.Graph
{
    /// <summary>
    /// https://leetcode.ca/2016-10-18-323-Number-of-Connected-Components-in-an-Undirected-Graph/
    /// </summary>
    internal class ConnectedComponenets
    {
        public int CountComponents(int n, int[][] edges)
        {
            Dictionary<int, HashSet<int>> graph = [];

            for (int i = 0; i < n; i++)
            {
                graph[i] = [];
            }

            foreach (var edge in edges)
            {
                graph[edge[0]].Add(edge[1]);
                graph[edge[1]].Add(edge[2]);
            }


            HashSet<int> visited = [];
            int components = 0;
            foreach (var node in graph.Keys)
            {
                if (!visited.Contains(node))
                {
                    components++;
                    DFS(node, graph, visited);
                }
            }

            return components;
        }

        private void DFS(int node, Dictionary<int, HashSet<int>> graph, HashSet<int> visited)
        {
            if (visited.Contains(node)) return;

            visited.Add(node);
            foreach (var neighbour in graph[node])
            {
                if (!visited.Contains(neighbour))
                    DFS(neighbour, graph, visited);
            }
        }
    }
}
