namespace LogicLeague.CodingPatterns._2.SlidingWindow
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-average-subarray-i/
    /// </summary>
    internal class MaximumAverageSubarray
    {
        public static double FindMaxAverage(int[] nums, int k)
        {

            int sum = 0;

            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }

            double maxSum = sum;

            for (int i = k; i < nums.Length; i++)
            {
                sum += nums[i];
                sum -= nums[i - k];

                maxSum = Math.Max(maxSum, sum);
            }

            return (double)maxSum / k;

        }
    }
}
