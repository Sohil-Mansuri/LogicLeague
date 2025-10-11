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


        //by level
        public static int OrangesRottingV2(int[][] grid)
        {
            if (grid == null || grid.Length == 0) return 0;

            int rows = grid.Length;
            int cols = grid[0].Length;

            int freshOranges = 0;
            Queue<(int row, int column, int minute)> queue = [];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == 1) freshOranges++;
                    else if (grid[i][j] == 2)
                    {
                        queue.Enqueue((i, j, 0));
                    }
                }
            }

            if (freshOranges == 0) return 0;

            int minutes = 0;
            int[] rowDirection = [0, 1, 0, -1];
            int[] colsDirection = [1, 0, -1, 0];
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                minutes = Math.Max(minutes, current.minute);

                for (int k = 0; k < rowDirection.Length; k++)
                {
                    var newRow = current.row + rowDirection[k];
                    var newColumn = current.column + colsDirection[k];

                    if (newRow >= 0 && newColumn >= 0 && newRow < rows && newColumn < cols && grid[newRow][newColumn] == 1)
                    {
                        freshOranges--;
                        grid[newRow][newColumn] = 2;
                        queue.Enqueue((newRow, newColumn, current.minute + 1));
                    }
                }
            }

            return freshOranges == 0 ? minutes : -1;
        }
    }
}
