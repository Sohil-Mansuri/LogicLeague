using System.Text;

namespace LogicLeague.Graph
{
    public class NumberOfDistinctIsland
    {
        private static readonly int[] rowDirection = [0, 1, 0, -1];
        private static readonly int[] columnDirection = [1, 0, -1, 0];

        public static int FindDistinctIsland(int[][] grid)
        {
            HashSet<string> uniqueIslands = [];

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        StringBuilder shape = new();
                        DFS(grid, i, j, shape, (i, j));
                        uniqueIslands.Add(shape.ToString());
                    }
                }
            }

            return uniqueIslands.Count;
        }

        private static void DFS(int[][] grid, 
            int row, 
            int column, 
            StringBuilder shape, 
            (int row, int column) origin)
        {
            grid[row][column] = 0;
            shape.Append($"{row - origin.row}{column - origin.column}#");

            for (int k = 0; k < rowDirection.Length; k++)
            {
                var newRow = row + rowDirection[k];
                var newColumn = column + columnDirection[k];

                if (newRow >= 0 && newColumn >= 0 && newRow < grid.Length && newColumn < grid[0].Length && grid[newRow][newColumn] == 1)
                {
                    DFS(grid, newRow, newColumn, shape, origin);
                }
            }
        }
    }
}
