namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/kth-largest-element-in-an-array/
    /// </summary>
    internal class KthLargestProblem
    {
        public static int FindKthLargest(int[] nums, int k)
        {
            var minHeap = new PriorityQueue<int, int>();

            foreach (int x in nums)
            {
                if (minHeap.Count < k)
                    minHeap.Enqueue(x, x);
                else if(x > minHeap.Peek())
                    minHeap.DequeueEnqueue(x, x);

            }

            return minHeap.Peek();

        }
    }
}
