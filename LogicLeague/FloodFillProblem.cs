
namespace LogicLeague
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

            DFS(image, sr, sc, color, image[sr][sc]);
            return image;
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
