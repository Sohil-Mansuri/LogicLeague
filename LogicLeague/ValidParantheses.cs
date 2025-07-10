namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/valid-parentheses/description/
    /// </summary>
    internal class ValidParantheses
    {
        public static bool IsValid(string input)
        {
            if(string.IsNullOrEmpty(input)) return false;

            Stack<char> stack = [];

            foreach (char c in input)
            {
                if (c == '}')
                {
                    if (stack.Count > 0 && stack.Peek() == '{') stack.Pop();
                    else return false;
                }
                else if (c == ')')
                {
                    if (stack.Count > 0 && stack.Peek() == '(') stack.Pop();
                    else return false;
                }
                else if (c == ']')
                {
                    if (stack.Count > 0 && stack.Peek() == '[') stack.Pop();
                    else return false;
                }
                else
                {
                    stack.Push(c);
                }

            }

            return stack.Count == 0;
        }
    }
}
