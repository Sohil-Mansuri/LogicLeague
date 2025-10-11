
namespace LogicLeague.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/01-matrix/
    /// </summary>
    public class ZeroOneMatrixProblem
    {
        public static int[][] UpdateMatrix(int[][] mat)
        {
            int rows = mat.Length;
            int cols = mat[0].Length;
            int[][] result = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                result[i] = new int[cols];
            }

            Queue<(int row, int column)> queue = [];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (mat[i][j] == 0)
                        queue.Enqueue((i, j));
                    else
                        result[i][j] = -1;
                }
            }

            int[] rowdirection = [0, -1, 0, 1];
            int[] columnDirection = [1, 0, -1, 0];
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                for (int k = 0; k < rowdirection.Length; k++)
                {
                    var newRow = current.row + rowdirection[k];
                    var newColumn = current.column + columnDirection[k];

                    if (newRow < 0 || newColumn < 0 || newRow >= rows || newColumn >= cols || result[newRow][newColumn] != -1)
                        continue;

                    result[newRow][newColumn] = result[current.row][current.column] + 1;
                    queue.Enqueue((newRow, newColumn));
                }
            }

            return result;
        }

    }
}
