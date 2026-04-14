namespace LogicLeague.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/swim-in-rising-water/
    /// </summary>
    public class SwimWatter
    {
        public static int SwimInWater(int[][] grid)
        {
            int rows = grid.Length;
            int columns = grid[0].Length;

            bool[][] visited = new bool[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
            {
                visited[i] = new bool[grid[i].Length];
            }

            PriorityQueue<(int x, int y, int height), int> minHeap = new();
            minHeap.Enqueue((0, 0, grid[0][0]), grid[0][0]);

            int[][] directions = [[0, 1], [1, 0], [0, -1], [-1, 0]];
            while (minHeap.Count > 0)
            {
                var current = minHeap.Dequeue();

                if (visited[current.x][current.y]) continue;


                if (current.x == rows - 1 && current.y == columns - 1)
                    return current.height;

                visited[current.x][current.y] = true;

                foreach (var dir in directions)
                {
                    var newX = current.x + dir[0];
                    var newY = current.y + dir[1];

                    if (newX < 0 || newY < 0 || newX >= rows || newY >= columns || visited[newX][newY]) continue;

                    var newHeight = Math.Max(current.height, grid[newX][newY]);
                    minHeap.Enqueue((newX, newY, newHeight), newHeight);
                }
            }

            return -1;
        }

    }
}
