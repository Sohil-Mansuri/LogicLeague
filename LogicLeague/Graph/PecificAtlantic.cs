using System.Text;

namespace LogicLeague.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/pacific-atlantic-water-flow/description/
    /// </summary>
    internal class PecificAtlantic
    {
        public static IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            int rows = heights.Length;
            int cols = heights[0].Length;
            IList<IList<int>> result = [];

            bool[,] pecific = new bool[rows, cols];
            bool[,] atlantic = new bool[rows, cols];

            for (int j = 0; j < cols; j++)
            {
                DFS(heights, pecific, 0, j, 0);
                DFS(heights, atlantic, rows - 1, j, 0);
            }


            for (int i = 0; i < rows; i++)
            {
                DFS(heights, pecific, i, 0, 0);
                DFS(heights, atlantic, i, cols - 1, 0);
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (pecific[i, j] && atlantic[i, j])
                        result.Add([i, j]);
                }
            }

            void DFS(int[][] heights, bool[,] visited, int row, int column, int previousHeight)
            {
                if (row < 0 || column < 0 || row >= rows || column >= cols) return;

                if (visited[row, column] || heights[row][column] < previousHeight) return;

                visited[row, column] = true;


                DFS(heights, visited, row + 1, column, heights[row][column]);
                DFS(heights, visited, row - 1, column, heights[row][column]);
                DFS(heights, visited, row, column + 1, heights[row][column]);
                DFS(heights, visited, row, column - 1, heights[row][column]);
            }

            return result;
        }
    }
}
