namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/last-stone-weight/
    /// </summary>
    internal class LastStoneProblem
    {
        public static int LastStoneWeight(int[] stones)
        {
            if (stones.Length == 1) return stones[0];

            var maxHeap = new PriorityQueue<int, int>();

            foreach (int num in stones)
                maxHeap.Enqueue(num, -num);

            while (maxHeap.Count > 1)
            {
                int y = maxHeap.Dequeue();
                int x = maxHeap.Dequeue();

                var delta = y - x;

                if (delta > 0)
                {
                    maxHeap.Enqueue(delta, -delta);
                }
            }

            return maxHeap.Count > 0 ? maxHeap.Dequeue() : 0;
        }


    }
}
