namespace LogicLeague
{
    internal class HighFiveProblem
    {
        public static int[][] HighFive(int[][] studentsMarks)
        {
            Dictionary<int, List<int>> hashMap = [];
            foreach (var student in studentsMarks)
            {
                if (!hashMap.ContainsKey(student[0]))
                    hashMap[student[0]] = [];

                hashMap[student[0]].Add(student[1]);
            }

            int[][] result = new int[hashMap.Count][];

            int index = 0;
            foreach (var student in hashMap)
            {
                var marks = student.Value;
                var minHeap = new PriorityQueue<int, int>();
                foreach (var mark in marks)
                {
                    minHeap.Enqueue(mark, mark);
                    if (minHeap.Count > 5)
                        minHeap.Dequeue();
                }

                var total = 0;
                while (minHeap.Count > 0)
                {
                    total += minHeap.Dequeue();
                }

                result[index++] = [student.Key, (total / 5)];
            }

            return result;
        }
    }
}
