namespace LogicLeague.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/rotting-oranges/
    /// </summary>
    internal class RottingOranges
    {
        public static int OrangesRotting(int[][] grid)
        {
            if (grid is null || grid.Length == 0) return -1;

            int freshCount = 0;
            Queue<(int x, int y)> queue = [];

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1) freshCount++;
                    else if (grid[i][j] == 2)
                    {
                        queue.Enqueue((i, j));
                    }
                }
            }

            if (freshCount == 0) return 0;

            int minutes = 0;
            int[][] directions = [[0, 1], [0, -1], [1, 0], [-1, 0]];

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;

                for (int i = 0; i < levelSize; i++)
                {
                    var current = queue.Dequeue();

                    foreach (var direction in directions)
                    {
                        int x = current.x + direction[0];
                        int y = current.y + direction[1];

                        if (x >= 0 && y >= 0 && x < grid.Length && y < grid[0].Length && grid[x][y] == 1)
                        {
                            freshCount--;
                            grid[x][y] = 2;
                            queue.Enqueue((x, y));
                        }
                    }
                }

                minutes++;
            }

            return freshCount == 0 ? minutes - 1 : -1;
        }
    }
}
