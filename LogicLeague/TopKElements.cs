namespace LogicLeague
{
    internal class TopKElements
    {
        public static int[] Top5MaximumElements(int[] nums)
        {
            PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();

            List<int> result = [];
            foreach (int num in nums)
            {
                if (priorityQueue.Count < 5)
                    priorityQueue.Enqueue(num, num);
                else
                {
                    if (priorityQueue.Peek() < num)
                    {
                        //priorityQueue.Dequeue();
                        //priorityQueue.Enqueue(num, num);
                        priorityQueue.DequeueEnqueue(num, num);
                    }
                }
            }

            while (priorityQueue.Count > 0)
            {
                result.Add(priorityQueue.Dequeue());
            }

            return result.ToArray();
        }
    }
}
