namespace LogicLeague.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/find-eventual-safe-states/
    /// </summary>
    internal class EventualSafeState
    {
        //DFS
        public static IList<int> EventualSafeNodes(int[][] edges)
        {
            Dictionary<int, HashSet<int>> graph = [];

            for (int i = 0; i < edges.Length; i++)
            {
                graph[i] = [];
                for (int j = 0; j < edges[i].Length; j++)
                {
                    graph[i].Add(edges[i][j]);
                }
            }

            int[] state = new int[graph.Count]; // 0 unvisited, 1 visiting , 2 safe
            IList<int> result = [];
            foreach (var node in graph.Keys)
            {
                if (IsSafe(graph, state, node))
                    result.Add(node);
            }


            return result;
        }

        private static bool IsSafe(
            Dictionary<int, HashSet<int>> graph,
            int[] state,
            int node)
        {
            if (state[node] > 0)
                return state[node] == 2;

            state[node] = 1;

            foreach (var neighbour in graph[node])
            {
                if (state[neighbour] == 1 || !IsSafe(graph, state, neighbour))
                    return false;
            }

            state[node] = 2;
            return true;
        }

        //BFS
        public static IList<int> EventualSafeNodesV2(int[][] edges)
        {
            Dictionary<int, HashSet<int>> graph = [];
            int[] indegree = new int[edges.Length];

            for (int i = 0; i < edges.Length; i++)
            {
                if (!graph.ContainsKey(i))
                    graph[i] = [];

                for (int j = 0; j < edges[i].Length; j++)
                {
                    if (!graph.ContainsKey(edges[i][j]))
                        graph[edges[i][j]] = [];

                    graph[edges[i][j]].Add(i);

                    indegree[i]++;
                }

            }

            List<int> result = [];
            Queue<int> queue = new(Enumerable.Range(0, edges.Length).Where(i => indegree[i] == 0));

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                result.Add(current);

                foreach (var neighbour in graph[current])
                {
                    indegree[neighbour]--;
                    if (indegree[neighbour] == 0)
                        queue.Enqueue(neighbour);
                }
            }

            result.Sort();

            return result;
        }
    }
}
