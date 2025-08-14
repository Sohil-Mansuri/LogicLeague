namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/k-closest-points-to-origin/
    /// </summary>
    internal class ClosestPointOfOrigin
    {
        public static int[][] KClosest(int[][] points, int k)
        {
            int[][] result = new int[k][];

            var maxHeap = new PriorityQueue<(int, int), double>();

            foreach (var point in points)
            {
                var distance = FindDistance(point[0], point[1]);
                maxHeap.Enqueue((point[0], point[1]), -distance);

                if (maxHeap.Count > k)
                    maxHeap.Dequeue();
            }


            int index = 0;
            while (maxHeap.Count > 0)
            {
                var element = maxHeap.Dequeue();
                result[index] = [element.Item1, element.Item2];
                index++;
            }

            return result;
        }

        private static double FindDistance(int x2, int y2)
        {
            int x1 = 0, y1 = 0;

            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }
    }
}
