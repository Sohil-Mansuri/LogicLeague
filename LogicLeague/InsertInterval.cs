
namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/insert-interval/description/
    /// </summary>
    internal class InsertInterval
    {
        public static int[][] Insert(int[][] intervals, int[] newInterval)
        {
            List<int[]> result = [];

            int i = 0;

            while (i < intervals.Length && intervals[i][1] < newInterval[0])
            {
                result.Add(intervals[i]);
                i++;
            }

            int[] newCombined = newInterval;
            while(i < intervals.Length && intervals[i][0] <= newCombined[1])
            {
                newCombined = [Math.Min(intervals[i][0], newCombined[0]), Math.Max(intervals[i][1], newCombined[1])];
                i++;
            }

            result.Add (newCombined);

            while(i < intervals.Length)
            {
                result.Add(intervals[i]);
                i++;
            }
            return [.. result];
        }

        public int[][] InsertV2(int[][] intervals, int[] newInterval)
        {
            List<int[]> result = new List<int[]>();
            if (intervals.Length == 0)
            {
                result.Add(newInterval);
                return result.ToArray();
            }

            int start = 0, end = 0;
            int low = 0, high = intervals.Length - 1;


            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (intervals[mid][0] <= newInterval[0])
                {
                    start = mid;
                    // try to find if we have a larger index with this condition
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            // if the second element of this pair is less than the first element of the new interval increment start by 1
            // or if the first element of this pair is greater than second element of the new interval, decrement start by 1
            if (newInterval[0] > intervals[start][1])
            {
                start++;
            }
            else if (newInterval[1] < intervals[start][0])
            {
                start--;
            }

            // now we have start, we will try to find where the second element of new interval should be
            low = end = start;
            high = intervals.Length - 1;
            while (low >= 0 && low <= high)
            {
                int mid = (low + high) / 2;
                if (intervals[mid][0] <= newInterval[1])
                {
                    end = mid;
                    // try to find if we have a larger index with this condition
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            // if the second element of this pair is less than the first element of the new interval increment start by 1
            // or if the first element of this pair is greater than second element of the new interval, decrement start by 1
            if (end >= 0 && end < intervals.Length && newInterval[0] > intervals[end][1])
            {
                end++;
            }
            else if (end >= 0 && end < intervals.Length && newInterval[1] < intervals[end][0])
            {
                end--;
            }

            for (int i = 0; i <= start - 1; i++)
            {
                // add elements before merge intervals
                result.Add(intervals[i]);
            }
            // add merged interval
            var item1 = newInterval[0];
            if (start >= 0 && start < intervals.Length && intervals[start][0] < newInterval[0])
            {
                item1 = intervals[start][0];
            }

            var item2 = newInterval[1];
            if (end >= 0 && end < intervals.Length && newInterval[1] <= intervals[end][1])
            {
                item2 = intervals[end][1];
            }

            result.Add([item1, item2]);

            for (int i = end + 1; i < intervals.Length; i++)
            {
                result.Add(intervals[i]);
            }

            return result.ToArray();
        }
    }
}
