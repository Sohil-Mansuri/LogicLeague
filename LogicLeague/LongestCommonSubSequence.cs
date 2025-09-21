namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/longest-common-subsequence/
    /// LCS
    /// </summary>
    internal class LongestCommonSubSequence
    {
        public static int LongestCommonSubsequence(string text1, string text2)
        {
            int m = text1.Length;
            int n = text2.Length;

            int[,] result = new int[m + 1, n + 1];

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (text1[i - 1] == text2[j - 1]) result[i, j] = 1 + result[i - 1, j - 1];
                    else result[i, j] = Math.Max(result[i, j - 1], result[i - 1, j]);
                }
            }

            return result[m, n];
        }
    }
}
