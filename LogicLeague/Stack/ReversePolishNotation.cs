namespace LogicLeague.Stack
{
    /// <summary>
    /// https://leetcode.com/problems/evaluate-reverse-polish-notation/
    /// </summary>
    internal class ReversePolishNotation
    {
        public static int EvalRPN(string[] tokens)
        {
            string[] operation = ["+", "-", "*", "/"];

            Stack<int> stack = new Stack<int>();

            foreach (string token in tokens)
            {
                if (operation.Contains(token))
                {
                    int b = stack.Pop();
                    int a = stack.Pop();

                    int result;

                    if (token == "+")
                        result = a + b;
                    else if (token == "-")
                        result = a - b;
                    else if (token == "*")
                        result = a * b;
                    else
                        result = a / b;

                    stack.Push(result);

                }
                else
                {
                    int value = Convert.ToInt32(token);
                    stack.Push(value);
                }
            }

            return stack.Pop();
        }
    }
}
