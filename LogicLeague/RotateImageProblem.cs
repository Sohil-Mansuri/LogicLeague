namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/rotate-image/description/
    /// </summary>
    internal class RotateImageProblem
    {
        public static int[][] Rotate(int[][] matrix)
        {
            Transpose(matrix);
            Reverse(matrix);
            return matrix;
        }

        public static int[][] Transpose(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    if (j >= i) continue;

                    (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
                }
            }

            return matrix;
        }

        public static int[][] Reverse(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                int left = 0, right = matrix.Length - 1;

                while (left < right)
                {
                    (matrix[i][left], matrix[i][right]) = (matrix[i][right], matrix[i][left]);
                    left++;
                    right--;
                }
            }

            return matrix;
        }
    }
}
