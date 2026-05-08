namespace LogicLeague.Matrix
{
    /// <summary>
    /// https://leetcode.com/problems/spiral-matrix/
    /// </summary>
    internal class SpriralMatrix
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> result = [];

            var directions = new (int dx, int dy)[]
            {
                (0, 1), // right
                (1, 0), // down
                (0, -1), // left
                (-1, 0) // up
            };

            int directionIndex = 0;

            int rows = matrix.Length;
            int cols = matrix[0].Length;

            int x = 0, y = 0;

            for (int i = 0; i < rows * cols; i++)
            {
                result.Add(matrix[x][y]);
                matrix[x][y] = int.MinValue; // Mark as visited
                int nextX = x + directions[directionIndex].dx;
                int nextY = y + directions[directionIndex].dy;
                if (nextX < 0 || nextX >= rows || nextY < 0 || nextY >= cols || matrix[nextX][nextY] == int.MinValue)
                {
                    directionIndex = (directionIndex + 1) % 4; // Change direction
                    nextX = x + directions[directionIndex].dx;
                    nextY = y + directions[directionIndex].dy;
                }
                x = nextX;
                y = nextY;
            }

            return result;
        }

    }
}
