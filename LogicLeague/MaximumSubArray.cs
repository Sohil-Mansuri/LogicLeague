namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-subarray/
    /// </summary>
    internal class MaximumSubArray
    {
        public static int MaxSubArray(int[] nums)
        {
            int currentSum = 0;
            int maxSum = nums[0];

            for (int index = 0; index < nums.Length; index++)
            {
                if (currentSum < 0) currentSum = 0;
                
                currentSum += nums[index];
                maxSum = Math.Max(maxSum, currentSum);
            }


            return maxSum;
        }
    }
}
