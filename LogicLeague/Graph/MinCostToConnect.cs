namespace LogicLeague.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/min-cost-to-connect-all-points/
    /// </summary>
    internal class MinCostToConnect
    {
        public int MinCostConnectPoints(int[][] points)
        {
            int cost = 0;
            HashSet<int> visited = [];
            PriorityQueue<(int distance, int point), int> minHeap = new();
            minHeap.Enqueue((0, 0), 0);

            while (visited.Count < points.Length)
            {
                var current = minHeap.Dequeue();

                if (visited.Contains(current.point)) continue;

                cost += current.distance;
                visited.Add(current.point);

                for (int i = 0; i < points.Length; i++)
                {
                    if (visited.Contains(i)) continue;

                    var newDistance = CalculateDistance(points[current.point], points[i]);
                    minHeap.Enqueue((newDistance, i), newDistance);
                }
            }



            return cost;
        }

        //Calculate the Manhattan distance between two points
        private int CalculateDistance(int[] point1, int[] point2)
        {
            return Math.Abs(point1[0] - point2[0]) + Math.Abs(point1[1] - point2[1]);
        }
    }
}
