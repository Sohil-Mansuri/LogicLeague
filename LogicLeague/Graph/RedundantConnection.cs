namespace LogicLeague.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/redundant-connection/description/
    /// </summary>
    internal class RedundantConnection
    {
        public static int[] FindRedundantConnection(int[][] edges)
        {
            int[] parent = new int[edges.Length + 1];

            for (int i = 1; i <= edges.Length; i++)
            {
                parent[i] = i;
            }

            foreach (var edge in edges)
            {
                int node1 = edge[0];
                int node2 = edge[1];

                int root1 = Find(node1, parent);
                int root2 = Find(node2, parent);

                if (root1 == root2) return edge;

                parent[root2] = root1;

            }

            return [];
        }

        private static int Find(int node, int[] parent)
        {
            while (node != parent[node])
            {
                parent[node] = parent[parent[node]];
                node = parent[node];
            }

            return node;
        }
    }
}
