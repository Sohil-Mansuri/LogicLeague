namespace LogicLeague.Graph
{
    internal class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = [];
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = [];
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }

        public static Node CrateGraph(int[][] edges)
        {
            Dictionary<int, Node> nodes = [];

            for (int i = 0; i < edges.Length; i++)
            {
                int value = i + 1;
                if (!nodes.ContainsKey(value))
                {
                    nodes[value] = new Node(value);
                }
            }

            for (int i = 0; i < edges.Length; i++)
            {
                int nodeValue = i + 1;

                var currentNode = nodes[nodeValue];

                foreach (var neighbourValue in edges[i])
                {
                    if (!nodes.ContainsKey(neighbourValue))
                    {
                        nodes[neighbourValue] = new Node(neighbourValue);
                    }

                    currentNode.neighbors.Add(nodes[neighbourValue]);
                }
            }

            return nodes[1];

        }
    }
}
