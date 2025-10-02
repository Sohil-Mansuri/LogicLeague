namespace LogicLeague.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/clone-graph/
    /// </summary>
    internal class CloneGraphProblem
    {
       static Dictionary<Node, Node> _visited = [];
        public static Node CloneGraph(Node node)
        {
            if (node == null) return null;

            if (_visited.ContainsKey(node)) return _visited[node];

            var cloneNode = new Node(node.val, []);

            _visited[node] = cloneNode;
            foreach (var item in node.neighbors)
            {
                cloneNode.neighbors.Add(CloneGraph(item));
            }

            return cloneNode;
        }
    }
}
