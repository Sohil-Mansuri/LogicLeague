namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/house-robber/description/
    /// </summary>
    internal class HouseRobber
    {
        public static int Rob(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;

            if (nums.Length == 1) return nums[0];

            int[] dp = new int[nums.Length];

            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);


            for (int index = 2; index < nums.Length; index++)
            {
                dp[index] = Math.Max(dp[index - 1], nums[index] + dp[index - 2]);
            }

            return dp[nums.Length - 1];
        }

        public static int RobV2(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;

            if (nums.Length == 1) return nums[0];


            int secondMax = nums[0];
            int firstMax = Math.Max(nums[0], nums[1]);


            for (int index = 2; index < nums.Length; index++)
            {
                int current = Math.Max(firstMax, nums[index] + secondMax);
                secondMax = firstMax;
                firstMax = current;
            }

            return firstMax;
        }
    }
}
