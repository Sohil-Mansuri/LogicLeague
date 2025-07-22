namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/unique-paths/description/
    /// </summary>
    internal class UniquePathsProblem
    {
        public static int UniquePaths(int m, int n)
        {
            int[,] paths = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        paths[i, j] = 1;
                    }
                    else
                    {
                        paths[i, j] = paths[i - 1, j] + paths[i, j - 1];
                    }
                }
            }

            return paths[m - 1, n - 1];
        }
    }
}
