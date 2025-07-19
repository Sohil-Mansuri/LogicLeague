namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/lru-cache/description/
    /// </summary>
    public class LRUCache
    {
        private int _capacity;
        private DoublyNode _head; // Most recently used
        private DoublyNode _tail; // least recently used
        private Dictionary<int, DoublyNode> _cache;

        public LRUCache(int capacity)
        {
            _capacity = capacity;
            _head = new(0, 0);
            _tail = new(0, 0);
            _head.Next = _tail;
            _tail.Prev = _head;
            _cache = [];
        }
        public int Get(int key)
        {
            if (!_cache.TryGetValue(key, out DoublyNode node)) return -1;

            Remove(node);
            InsertAfterHead(node);
            return node.Value;
        }

        public void Put(int key, int value)
        {
            if (_cache.TryGetValue(key, out DoublyNode node))
            {
                node.Value = value;
                Remove(node);
                InsertAfterHead(node);
            }
            else
            {
                if (_cache.Count == _capacity)
                {
                    _cache.Remove(_tail.Prev.Key);
                    Remove(_tail.Prev);
                }

                var newNode = new DoublyNode(key, value);
                _cache.Add(key, newNode);
                InsertAfterHead(newNode);
            }
        }


        private void Remove(DoublyNode node)
        {
            node.Prev.Next = node.Next;
            node.Next.Prev = node.Prev;
        }


        private void InsertAfterHead(DoublyNode node)
        {
            node.Next = _head.Next;
            node.Prev = _head;
            _head.Next.Prev = node;
            _head.Next = node;
        }
    }

    public class DoublyNode
    {
        public int Key { get; set; }
        public int Value { get; set; }

        public DoublyNode Prev { get; set; }

        public DoublyNode Next { get; set; }

        public DoublyNode(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }
}
