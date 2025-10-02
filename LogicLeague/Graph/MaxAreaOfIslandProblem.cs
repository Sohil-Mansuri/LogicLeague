namespace LogicLeague.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/max-area-of-island/description/
    /// </summary>
    public class MaxAreaOfIslandProblem
    {
        public static int MaxAreaOfIsland(int[][] grid)
        {
            int maxArea = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        var area = DFS(grid, i, j);
                        maxArea = Math.Max(maxArea, area);
                    }
                }
            }

            return maxArea;
        }

        private static int DFS(int[][] grid, int row, int column)
        {
            if (row < 0 || column < 0 || row >= grid.Length || column >= grid[0].Length || grid[row][column] != 1)
                return 0;

            grid[row][column] = 0;
            int area = 1;

            area += DFS(grid, row + 1, column);
            area += DFS(grid, row - 1, column);
            area += DFS(grid, row, column + 1);
            area += DFS(grid, row, column - 1);

            return area;
        }
    }
}
