namespace LogicLeague.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/flood-fill/description/
    /// </summary>
    internal class FloodFillProblem
    {
        public static int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            var startingPixel = image[sr][sc];

            if (startingPixel == color)
                return image;

            BFS(image, sr, sc, color, startingPixel);
            return image;
        }

        private static void BFS(int[][] image, int row, int column, int color, int startingPixelColor)
        {
            int rows = image.Length;
            int cols = image[0].Length;
            image[row][column] = color;
            Queue<(int row, int column)> queue = [];
            queue.Enqueue((row, column));

            int[] rowDirection = [0, 1, 0, -1];
            int[] columnDirection = [1, 0, -1, 0];

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                for (int k = 0; k < rowDirection.Length; k++)
                {
                    var newRow = rowDirection[k] + current.row;
                    var newColumn = columnDirection[k] + current.column;

                    if (newRow >= 0 && newColumn >= 0 && newRow < rows && newColumn < cols 
                        && image[newRow][newColumn] == startingPixelColor)
                    {
                        image[newRow][newColumn] = color;
                        queue.Enqueue((newRow, newColumn));
                    }
                }
            }
        }

        private static void DFS(int[][] image, int row, int column, int color, int startingPixelColor)
        {
            if (row < 0 || column < 0 || row >= image.Length || column >= image[0].Length || image[row][column] != startingPixelColor)
                return;

            image[row][column] = color;

            DFS(image, row, column + 1, color, startingPixelColor);
            DFS(image, row, column - 1, color, startingPixelColor);
            DFS(image, row + 1, column, color, startingPixelColor);
            DFS(image, row - 1, column, color, startingPixelColor);
        }
    }
}
