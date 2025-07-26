namespace LogicLeague.Stack
{
    internal class StackImplementation
    {
        private List<int> _stack = [];

        public void Push(int element)
        {
            _stack.Add(element);
        }


        public int Pop()
        {
            if (_stack.Count > 0)
            {
                var topElement = _stack[^1];
                _stack.Remove(topElement);
                return topElement;
            }

            return -1;
        }


        public int Peek()
        {
            if (_stack.Count > 0)
            {
                return _stack[^1];
            }

            return -1;
        }

    }
}
