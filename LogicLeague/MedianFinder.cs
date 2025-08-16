namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/find-median-from-data-stream/
    /// </summary>
    public class MedianFinder
    {
        private PriorityQueue<int, int> maxHeap = new();
        private PriorityQueue<int, int> minHeap = new();


        public void AddNum(int num)
        {
            maxHeap.Enqueue(num, -num);

            var topMax = maxHeap.Dequeue();
            minHeap.Enqueue(topMax, topMax);

            if (maxHeap.Count < minHeap.Count)
            {
                var minValue = minHeap.Dequeue();
                maxHeap.Enqueue(minValue, -minValue);
            }
        }

        public double FindMedian()
        {
            return maxHeap.Count > minHeap.Count ? maxHeap.Peek() : (maxHeap.Peek() + minHeap.Peek()) * 0.5;
        }
    }
}
