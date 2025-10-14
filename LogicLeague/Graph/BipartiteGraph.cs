

namespace LogicLeague.Graph
{
    internal class BipartiteGraph
    {
        public bool IsBipartiteGraph(int[][] grid)
        {
            Dictionary<int, HashSet<int>> graph = [];

            foreach (var edge in grid)
            {
                if (!graph.ContainsKey(edge[0]))
                    graph[edge[0]] = [];

                if (!graph.ContainsKey(edge[1]))
                    graph[edge[1]] = [];

                graph[edge[0]].Add(edge[1]);
                graph[edge[1]].Add(edge[0]);
            }

            int[] color = new int[grid.Length];

            for (int i = 0; i < color.Length; i++)
            {
                color[i] = -1;
            }

            foreach (var node in graph.Keys)
            {
                if (color[node] == -1 && !BFS(graph, node, color))
                    return false;
            }

            return true;
        }

        public bool IsBipartiteGraphV2(int[][] grid)
        {
            Dictionary<int, HashSet<int>> graph = [];

            foreach (var edge in grid)
            {
                if (!graph.ContainsKey(edge[0]))
                    graph[edge[0]] = [];

                if (!graph.ContainsKey(edge[1]))
                    graph[edge[1]] = [];

                graph[edge[0]].Add(edge[1]);
                graph[edge[1]].Add(edge[0]);
            }

            var n = graph.Keys.Max() + 1;
            int[] color = new int[n];

            color = Enumerable.Repeat(-1, n).ToArray();

            //for (int i = 0; i < color.Length; i++)
            //{
            //    color[i] = -1;
            //}

            foreach (var node in graph.Keys)
            {
                if (color[node] == -1 && !DFS(graph, node, color, 0))
                    return false;
            }

            return true;
        }

        private bool DFS(Dictionary<int, HashSet<int>> graph, int node, int[] colors, int parentColor)
        {
            colors[node] = parentColor;

            foreach (var neighbour in graph[node])
            {
                if (colors[neighbour] == -1)
                {
                    int color = parentColor == 0 ? 1 : 0; // parentColor ^ 1 (EXOR) 0 -> 1 or 1 -> 0
                    if (!DFS(graph, neighbour, colors, color))
                        return false;
                }
                else if (colors[neighbour] == parentColor)
                    return false;
            }

            return true;
        }

        private bool BFS(Dictionary<int, HashSet<int>> graph, int node, int[] color)
        {
            color[node] = 0;
            Queue<int> queue = [];
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var parent = queue.Dequeue();
                foreach (var neighbour in graph[parent])
                {
                    if (color[neighbour] == -1)
                    {
                        color[neighbour] = color[parent] == 0 ? 1 : 0;
                        queue.Enqueue(neighbour);
                    }
                    else if (color[neighbour] == color[parent])
                        return false;
                }
            }

            return true;
        }


    }
}
