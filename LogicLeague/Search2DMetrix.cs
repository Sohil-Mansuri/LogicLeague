namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/search-a-2d-matrix/
    /// </summary>
    internal class Search2DMetrix
    {
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int left = 0;
            int n = matrix.Length;
            int m = matrix[0].Length;
            int right = m * n - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int midValue = matrix[mid / m][mid % m];

                if (midValue == target) return true;
                else if (midValue > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return false;
        }
    }
}
