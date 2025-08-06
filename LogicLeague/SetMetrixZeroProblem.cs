namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/set-matrix-zeroes/
    /// </summary>
    internal class SetMetrixZeroProblem
    {
        public static int[][] SetZeroes(int[][] matrix)
        {
            HashSet<int> row = [];
            HashSet<int> column = [];
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        row.Add(i);
                        column.Add(j);
                    }
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (row.Contains(i) || column.Contains(j))
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            return matrix;
        }

        public static int[][] SetZeroesV2(int[][] matrix)
        {
            bool firstCol = false;
            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i][0] == 0)
                {
                    firstCol = true;
                    continue;
                }

                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }

            for (int i = 1; i < matrix.Length; i++)
            {
                for (int j = 1; j < matrix[0].Length; j++)
                {
                    if (matrix[i][0] == 0 || matrix[0][j] == 0)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            //first row
            if (matrix[0][0] == 0)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    matrix[0][j] = 0;
                }
            }

            if (firstCol)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    matrix[i][0] = 0;
                }
            }


            return matrix;
        }
    }
}
