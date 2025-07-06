namespace LogicLeague
{
    internal class TopKFrequestElements
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            if (nums.Length == k) return nums;

            Dictionary<int, int> hashMap = [];
            PriorityQueue<int, int> priorityQueue = new();

            int[] result = new int[k];
            foreach (int num in nums)
            {
                if (hashMap.TryGetValue(num, out int value)) hashMap[num] = ++value;
                else hashMap[num] = 1;
            }


            foreach (var item in hashMap)
            {
                if (priorityQueue.Count < k)
                    priorityQueue.Enqueue(item.Key, item.Value);
                else
                {
                    if (item.Value > hashMap[priorityQueue.Peek()])
                        priorityQueue.DequeueEnqueue(item.Key, item.Value);
                }
            }

            for (int index = 0; index < result.Length; index++)
            {
                result[index] = priorityQueue.Dequeue();
            }

            return result;
        }
    }
}
