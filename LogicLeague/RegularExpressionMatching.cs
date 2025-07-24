namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/regular-expression-matching/description/
    /// </summary>
    internal class RegularExpressionMatching
    {
        public static bool IsMatch(string s, string p)
        {
            if (p == "*") return true;

            bool[,] dp = new bool[s.Length + 1, p.Length + 1];
            dp[0, 0] = true;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] == '*')
                {
                    dp[0, i + 1] = dp[0, i - 1]; // look 2 steps back
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < p.Length; j++)
                {
                    if (p[j] == s[i] || p[j] == '.')
                    {
                        dp[i + 1, j + 1] = dp[i, j];
                    }

                    if (p[j] == '*')
                    {
                        if (p[j - 1] != s[i] && p[j-1] != '.')
                        {
                            dp[i + 1, j + 1] = dp[i + 1, j - 1];
                        }
                        else
                        {
                            dp[i + 1, j + 1] = (dp[i + 1, j] || dp[i + 1, j - 1] || dp[i, j + 1]);
                        }
                    }
                }

            }

            return dp[s.Length, p.Length];
        }
    }
}
