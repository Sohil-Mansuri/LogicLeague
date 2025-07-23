namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/partition-equal-subset-sum/
    /// </summary>
    internal class PartitionEqualSubsetSum
    {
        public static bool CanPartition(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            if (sum % 2 != 0) return false;

            int target = sum / 2;
            bool[] dp = new bool[target + 1];
            dp[0] = true;


            for (int index = 0; index < nums.Length; index++)
            {
                for (int j = target; j >= nums[index]; j--)
                {
                    if (dp[j - nums[index]]) dp[j] = true;
                }
            }

            return dp[target];
        }
    }
}
