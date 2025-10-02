namespace LogicLeague
{
    /// <summary>
    /// 
    /// </summary>
    internal class CopyRandomLinkedList
    {
        private Dictionary<Node, Node> _visited = [];

        public Node CopyRandomList(Node head)
        {
            if (head == null) return null;

            if (_visited.ContainsKey(head))
            {
                return _visited[head];
            }

            var newNode = new Node(head.val);

            _visited[head] = newNode;

            newNode.next = CopyRandomList(head.next);
            newNode.random = CopyRandomList(head.random);

            return newNode;
        }
    }


    public class Node(int _val)
    {
        public int val = _val;
        public Node next = null;
        public Node random = null;
    }
}
