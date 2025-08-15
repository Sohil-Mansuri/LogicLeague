namespace LogicLeague
{
    internal class EmployeeFreeTimeProblem
    {
        public class Interval
        {
            public int start;
            public int end;
            public Interval() { start = 0; end = 0; }
            public Interval(int s, int e) { start = s; end = e; }
        }

        public static List<Interval> EmployeeFreeTime(List<List<Interval>> schedules)
        {
            var result = new List<Interval>();
            var minHeap = new PriorityQueue<Interval, int>();

            foreach (var schedule in schedules)
            {
                foreach (var interval in schedule)
                {
                    minHeap.Enqueue(interval, interval.start);
                }
            }

            var temp = new List<Interval>();
            Interval previous = minHeap.Dequeue();

            while (minHeap.Count > 0)
            {
                var current = minHeap.Dequeue();

                if (current.start <= previous.end)
                {
                    previous = new Interval
                    {
                        start = Math.Min(previous.start, current.start),
                        end = Math.Max(previous.end, current.end)
                    };
                }
                else
                {
                    temp.Add(previous);
                    previous = current;
                }
            }

            temp.Add(previous);

            for (int index = 0; index < temp.Count - 1; index++)
            {
                if (temp[index + 1].start > temp[index].end)
                {
                    result.Add(new Interval
                    {
                        start = temp[index].end,
                        end = temp[index + 1].start
                    });
                }
            }

            return result;
        }
    }
}
