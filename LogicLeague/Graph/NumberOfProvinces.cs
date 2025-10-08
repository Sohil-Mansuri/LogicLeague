
namespace LogicLeague.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-provinces/
    /// </summary>
    public class NumberOfProvinces
    {
        public static int FindCircleNum(int[][] isConnected)
        {
            int noOfProvince = 0;
            HashSet<int> visited = [];

            for (int node = 0; node < isConnected.Length; node++)
            {
                if (!visited.Contains(node))
                {
                    noOfProvince++;
                    DFS(isConnected, node, visited);
                }
            }

            return noOfProvince;
        }

        private static void DFS(int[][] isConnected, int node, HashSet<int> visited)
        {
            visited.Add(node);

            for (int neighbour = 0; neighbour < isConnected.Length; neighbour++)
            {
                if (isConnected[node][neighbour] == 1 && !visited.Contains(neighbour))
                {
                    DFS(isConnected, neighbour, visited);
                }
            }
        }

        private static void BFS(int[][] isConnected, int node, HashSet<int> visited)
        {
            visited.Add(node);
            Queue<int> queue = [];
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                for (int neighbour = 0; neighbour < isConnected.Length; neighbour++)
                {
                    if (isConnected[current][neighbour] == 1 && !visited.Contains(neighbour))
                    {
                        visited.Add(neighbour);
                        queue.Enqueue(neighbour);
                    }
                }
            }

        }
    }
}
