

namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/word-break/description/
    /// </summary>
    internal class WordBreakProblem
    {
        public static bool WordBreak(string s, IList<string> wordDict)
        {
            HashSet<string> words = [.. wordDict];

            Span<bool> dp = stackalloc bool[s.Length + 1];
            dp[0] = true;

            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (dp[j] && words.Contains(s.Substring(j, i - j)))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[s.Length];
        }
    }
}
