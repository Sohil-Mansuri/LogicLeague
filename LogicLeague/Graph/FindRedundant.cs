


namespace LogicLeague.Graph
{
    internal class FindRedundant
    {
        public int[] FindRedundantExample(int[][] edges, int n)
        {
            int[] parent = new int[n + 1];

            for (int i = 0; i < parent.Length; i++)
            {
                parent[i] = i;
            }

            foreach (var edge in edges)
            {
                int node1 = edge[0];
                int node2 = edge[1];

                int root1 = FindRoot(parent, node1);
                int root2 = FindRoot(parent, node2);

                if (root1 == root2)
                {
                    return edge;
                }

                parent[root1] = root2;
            }

            return [];
        }

        private int FindRoot(int[] parent, int node)
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
