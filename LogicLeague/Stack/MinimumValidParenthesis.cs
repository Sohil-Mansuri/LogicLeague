using System.Text;

namespace LogicLeague.Stack
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-remove-to-make-valid-parentheses/description/
    /// </summary>
    internal class MinimumValidParenthesis
    {
        public static string MinRemoveToMakeValid(string s)
        {
            Stack<int> stack = [];
            HashSet<int> inValidIndices = [];

            for (int index = 0; index < s.Length; index++)
            {
                if (s[index] == '(')
                {
                    stack.Push(index);
                }
                else if (s[index] == ')')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        inValidIndices.Add(index);
                    }
                }
            }

            while (stack.Count > 0)
            {
                inValidIndices.Add(stack.Pop());
            }

            var result = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (inValidIndices.Contains(i)) continue;

                result.Append(s[i]);
            }

            return result.ToString();
        }
    }
}
