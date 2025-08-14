namespace LogicLeague
{
    internal class MaxHeap
    {
        private int[] _heap;

        private int _count = 0;

        public MaxHeap(int size)
        {
            _heap = new int[size];
        }

        public void Insert(int item)
        {
            if (_count == _heap.Length)
                throw new InvalidOperationException("heap is full");

            _heap[_count] = item;
            HeapifyUp(_count);
            _count++;
        }

        public int ExtractMax()
        {
            if (_count == 0)
                throw new InvalidOperationException("heap is empty");

            _count--;
            int max = _heap[0];
            _heap[0] = _heap[_count]; // move last to root
            HeapifyDown(0);
            return max;
        }

        public int Peek()
        {
            if (_count == 0)
                throw new InvalidOperationException("heap is empty");

            return _heap[0];
        }

        private void HeapifyDown(int index)
        {
            while (index < _count)
            {
                int leftIndex = 2 * index + 1;
                int rightIndex = 2 * index + 2;
                int largestIndex = index;

                if (leftIndex < _count && _heap[leftIndex] > _heap[largestIndex])
                    largestIndex = leftIndex;

                if (rightIndex < _count && _heap[rightIndex] > _heap[largestIndex])
                    largestIndex = rightIndex;


                if (largestIndex != index)
                {
                    (_heap[largestIndex], _heap[index]) = (_heap[index], _heap[largestIndex]);
                    index = largestIndex;
                }
                else
                {
                    break;
                }

            }

        }

        public void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parent = (index - 1) / 2;

                if (_heap[parent] < _heap[index])
                {
                    (_heap[parent], _heap[index]) = (_heap[index], _heap[parent]);
                    index = parent;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
