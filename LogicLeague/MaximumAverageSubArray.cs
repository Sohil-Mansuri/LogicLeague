namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-average-subarray-i/
    /// </summary>
    internal class MaximumAverageSubArray
    {
        public static double FindMaxAverage(int[] nums, int k)
        {
            int left = 0;
            int sum = 0;
            double maxAverage = double.MinValue;

            for (int right = 0; right < nums.Length; right++)
            {
                sum += nums[right];
                if (right - left + 1 == k)
                {
                    double average = sum * 1.0 / k;
                    maxAverage = Math.Max(maxAverage, average);
                    sum -= nums[left++];
                }
            }
            

            return maxAverage;

        }

        public static double FindMaxAverageV2(int[] nums, int k)
        {
            int sum = 0;

            for (int i = 0; i < k; i++)
                sum += nums[i];

            double maxAverage = (double)sum / k;

            for (int i = k; i < nums.Length; i++)
            {
                sum += nums[i] - nums[i - k];
                maxAverage = Math.Max(maxAverage, (double)sum / k);
            }

            return maxAverage;
        }
    }
}
