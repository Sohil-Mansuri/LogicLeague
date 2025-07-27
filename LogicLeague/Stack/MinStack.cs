namespace LogicLeague.Stack
{
    /// <summary>
    /// https://leetcode.com/problems/min-stack/
    /// </summary>
    public class MinStack
    {
        private readonly Stack<StackNode> stack;

        public MinStack()
        {
            stack = new Stack<StackNode>();
        }

        public void Push(int val)
        {
            if (stack.Count == 0)
            {
                var newNode = new StackNode
                {
                    Value = val,
                    Min = val
                };

                stack.Push(newNode);
            }
            else
            {
                var top = stack.Peek();

                var newNode = new StackNode
                {
                    Value = val,
                    Min = Math.Min(top.Min, val),
                };

                stack.Push(newNode);
            }
        }

        public void Pop()
        {
            if (stack.Count > 0) stack.Pop();
        }

        public int Top()
        {
            return stack.Peek().Value;
        }

        public int GetMin()
        {
            if (stack.Count > 0)
            {
                return stack.Peek().Min;
            }

            return 0;
        }
    }

    public class StackNode
    {
        public int Value { get; set; }
        public int Min { get; set; }
    }
}
