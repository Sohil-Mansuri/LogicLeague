namespace LogicLeague.Graph
{
    internal class NumberOfIsland
    {
        public static int NumIslands(char[][] grid)
        {
            int maximumIsland = 0;
            if (grid.Length == 0) return 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        maximumIsland++;
                        Backtrack(grid, i, j);
                    }
                }
            }

            return maximumIsland;
        }

        private static void Backtrack(char[][] grid, int row, int column)
        {
            int[] rowDirection = [0, -1, 0, 1];
            int[] colDirection = [1, 0, -1, 0];

            grid[row][column] = '0';

            for (int k = 0; k < rowDirection.Length; k++)
            {
                int newRow = row + rowDirection[k];
                int newColumn = column + colDirection[k];

                if (newRow < 0 || newColumn < 0 || newRow >= grid.Length || newColumn >= grid[0].Length) continue;

                if (grid[newRow][newColumn] == '1')
                    Backtrack(grid, newRow, newColumn);
            }
        }


        public static int NumIslandsV2(char[][] grid)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;

            int noOfIsland = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        noOfIsland++;
                        DFS(i, j);
                    }
                }
            }

            void DFS(int row, int column)
            {
                if (row < 0 || column < 0 || row >= rows || column >= cols || grid[row][column] == '0')
                    return;

                grid[row][column] = '0';

                DFS(row + 1, column);
                DFS(row - 1, column);
                DFS(row, column + 1);
                DFS(row, column - 1);
            }

            return noOfIsland;
        }
    }
}
