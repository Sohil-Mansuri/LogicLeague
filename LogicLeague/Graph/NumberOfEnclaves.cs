
namespace LogicLeague.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-enclaves/description/
    /// </summary>
    internal class NumberOfEnclaves
    {
        private static int[] rowDirection = [0, -1, 1, 0];
        private static int[] columnDirection = [1, 0, 0, -1];

        public static int NumEnclaves(int[][] grid)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;
            for (int j = 0; j < cols; j++)
            {
                DFS(grid, 0, j);
                DFS(grid, rows - 1, j);
            }

            for (int i = 0; i < rows; i++)
            {
                DFS(grid, i, 0);
                DFS(grid, i, cols - 1);
            }

            int totalEnclaves = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == 1) totalEnclaves++;
                }
            }

            return totalEnclaves;
        }

        private static void DFS(int[][] grid, int row, int column)
        {
            if (row < 0 || column < 0 || row >= grid.Length || column >= grid[0].Length || grid[row][column] != 1)
                return;

            grid[row][column] = 0;

            DFS(grid, row + 1, column);
            DFS(grid, row - 1, column);
            DFS(grid, row, column + 1);
            DFS(grid, row, column - 1);

        }

        public static void DFSV2(int[][] grid, int row, int column)
        {
            if (row < 0 || column < 0 || row >= grid.Length || column >= grid[0].Length || grid[row][column] != 1)
                return;

            grid[row][column] = 0;


            for (int k = 0; k < rowDirection.Length; k++)
            {
                DFS(grid, row + rowDirection[k], column + columnDirection[k]);
            }
        }
    }
}
