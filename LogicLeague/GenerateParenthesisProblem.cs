using System.Text;

namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/generate-parentheses/
    /// </summary>
    internal class GenerateParenthesisProblem
    {
        public static IList<string> GenerateParenthesis(int n)
        {
            IList<string> result = [];
            int open = 0; int close = 0;
            Backtrack(result, open, close, new StringBuilder(), n);
            return result;
        }

        private static void Backtrack(IList<string> result, int open, int close, StringBuilder current, int max)
        {
            if (current.Length == max * 2)
            {
                result.Add(current.ToString());
                return;
            }

            if (open < max)
            {
                current.Append('(');
                Backtrack(result, open + 1, close, current, max);
                current.Remove(current.Length - 1, 1);
            }

            if (close < open)
            {
                current.Append(')');
                Backtrack(result, open, close + 1, current, max);
                current.Remove(current.Length - 1, 1);
            }
        }
    }
}
