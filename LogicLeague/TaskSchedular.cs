namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/task-scheduler/
    /// </summary>
    internal class TaskSchedular
    {
        public static int LeastInterval(string[] tasks, int n)
        {
            int count = 0;
            Dictionary<string, int> hashMap = [];

            foreach (string task in tasks)
            {
                if (hashMap.ContainsKey(task)) hashMap[task]++;
                else hashMap[task] = 1;
            }

            var maxHeap = new PriorityQueue<int, int>();

            foreach (var map in hashMap)
            {
                maxHeap.Enqueue(map.Value, -map.Value);
            }

            while (maxHeap.Count > 0)
            {
                List<int> temp = [];

                for (int i = 0; i < n+1; i++)
                {
                    if (maxHeap.Count > 0)
                        temp.Add(maxHeap.Dequeue());

                }

                foreach (var element in temp)
                {
                    var value = element;
                    if (--value > 0)
                        maxHeap.Enqueue(value, -value);
                }

                count += maxHeap.Count == 0 ? temp.Count : n + 1;
            }

            return count;
        }
    }
}
