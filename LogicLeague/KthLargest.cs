namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/kth-largest-element-in-a-stream/
    /// </summary>
    public class KthLargest
    {
        readonly PriorityQueue<int, int> _minHeap;

        private int _size;

        public KthLargest(int k, int[] nums)
        {
            _minHeap = new PriorityQueue<int, int>();
            _size = k;
            BulkAdd(nums);
        }

        public int Add(int val)
        {
            if (_minHeap.Count >= _size)
            {
                if (val > _minHeap.Peek())
                    _minHeap.DequeueEnqueue(val, val);
            }
            else
            {
                _minHeap.Enqueue(val, val);
            }

            return _minHeap.Peek();
        }

        private void BulkAdd(int[] nums)
        {
            foreach (var item in nums)
            {
                _minHeap.Enqueue(item, item);

                if (_minHeap.Count > _size)
                    _minHeap.Dequeue();
            }
        }
    }
}
