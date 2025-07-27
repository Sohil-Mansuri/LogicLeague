namespace LogicLeague.Stack
{
    /// <summary>
    /// https://leetcode.com/problems/longest-valid-parentheses/
    /// </summary>
    internal class LongestValidParenthesesProblem
    {
        public static int LongestValidParentheses(string s)
        {
            int maxCount = 0;

            if (string.IsNullOrEmpty(s)) return maxCount;

            int starting = -1;
            Stack<int> stack = [];

            for (int index = 0; index < s.Length; index++)
            {
                if (s[index] == '(') stack.Push(index);
                else
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                        if (stack.Count == 0)
                        {
                            int count = index - starting;
                            maxCount = Math.Max(maxCount, count);
                        }
                        else
                        {
                            int count = index - stack.Peek();
                            maxCount = Math.Max(maxCount, count);
                        }
                    }
                    else
                    {
                        starting = index;
                    }
                }
            }

            return maxCount;
        }
    }
}
