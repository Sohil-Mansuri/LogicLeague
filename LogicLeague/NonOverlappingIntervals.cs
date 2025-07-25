namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/non-overlapping-intervals/
    /// </summary>
    internal class NonOverlappingIntervals
    {
        public static int EraseOverlapIntervals(int[][] intervals)
        {
            int remove = 0;
            if (intervals.Length <= 1) return remove;

            var sorted = intervals.OrderBy(x => x[0]).ToArray();
            int prev = 0;

            for (int currentIndex = 1; currentIndex < sorted.Length; currentIndex++)
            {
                if (sorted[prev][1] > sorted[currentIndex][0])
                {
                    if (sorted[prev][1] > sorted[currentIndex][1])
                    {
                        prev = currentIndex;
                    }
                    remove++;
                }
                else
                {
                    prev = currentIndex;
                }
            }

            return remove;
        }
    }
}
