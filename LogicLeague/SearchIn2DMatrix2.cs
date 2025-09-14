namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/search-a-2d-matrix-ii/description/
    /// </summary>
    internal class SearchIn2DMatrix2
    {
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;

            int row = 0;
            int column = cols - 1;

            while (row < rows && column >= 0)
            {
                if (matrix[row][column] == target) return true;

                if (matrix[row][column] > target) column--;
                else row++;
            }

            return false;
        }
    }
}
