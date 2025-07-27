namespace LogicLeague.Stack
{
    internal class MaxStack
    {
        private readonly Stack<int> _stack = [];
        private readonly Stack<int> _maxStack = [];

        public void Push(int value)
        {
            int max = _stack.Count == 0 ? value : Math.Max(value, _maxStack.Peek());

            _stack.Push(value);
            _maxStack.Push(max);
        }

        public int Pop()
        {
            _maxStack.Pop();
            return _stack.Pop();
        }

        public int Peek()
        {
            return _stack.Peek();
        }

        public int PeekMax()
        {
            return _maxStack.Peek();
        }

        public int PopMax()
        {
            int max = _maxStack.Peek();

            Stack<int> buffer = [];
            while (Peek() != max)
            {
                buffer.Push(Pop());
            }

            Pop();

            while (buffer.Count > 0)
            {
                Push(buffer.Pop());
            }

            return max;
        }
    }
}
