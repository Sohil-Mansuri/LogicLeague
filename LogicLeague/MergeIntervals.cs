namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/merge-intervals/
    /// </summary>
    internal class MergeIntervals
    {
        public static int[][] Merge(int[][] intervals)
        {
            if (intervals.Length <= 1) return intervals;

            var sortedInputs = intervals.OrderBy(x => x[0]).ToArray();

            List<int[]> results = [];

            int[] newEntry = [sortedInputs[0][0], sortedInputs[0][1]];

            for (int i = 1; i < sortedInputs.Length; i++)
            {
                if (sortedInputs[i][0] <= newEntry[1])
                {
                    newEntry[1] = Math.Max(newEntry[1], sortedInputs[i][1]);
                }
                else
                {
                    results.Add(newEntry);
                    newEntry = [sortedInputs[i][0], sortedInputs[i][1]];
                }
            }

            results.Add(newEntry);


            return [.. results];
        }
    }
}
