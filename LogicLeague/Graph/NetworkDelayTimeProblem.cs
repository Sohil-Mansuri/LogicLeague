namespace LogicLeague.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/network-delay-time/description/
    /// </summary>
    internal class NetworkDelayTimeProblem
    {
        public static int NetworkDelayTime(int[][] times, int n, int k)
        {
            Dictionary<int, List<(int nextNode, int nextDistance)>> graph = [];

            foreach (var item in times)
            {
                if (!graph.TryGetValue(item[0], out var neighbour))
                    neighbour = [];

                neighbour.Add((item[1], item[2]));
                graph[item[0]] = neighbour;
            }

            var distance = new int[n + 1];
            for (int i = 0; i < distance.Length; i++)
            {
                distance[i] = int.MaxValue;
            }

            distance[k] = 0;
            PriorityQueue<int[], int> minHeap = new();
            minHeap.Enqueue([k, 0], 0);

            while (minHeap.Count > 0)
            {
                var element = minHeap.Dequeue();
                var currentNode = element[0];
                var currentDistance = element[1];

                if (currentDistance > distance[currentNode])
                    continue;

                if (graph.TryGetValue(currentNode, out var neighbours))
                {
                    foreach (var neighbour in neighbours)
                    {
                        var nextNode = neighbour.nextNode;
                        var nextDistance = currentDistance + neighbour.nextDistance;
                        if (nextDistance < distance[nextNode])
                        {
                            distance[nextNode] = nextDistance;
                            minHeap.Enqueue([nextNode, nextDistance], nextDistance);
                        }
                    }
                }
            }

            int minTime = -1;
            for (int i = 1; i < distance.Length; i++)
            {
                if (distance[i] == int.MaxValue) return -1;
                minTime = Math.Max(minTime, distance[i]);
            }

            return minTime;
        }
    }
}
