namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/jump-game/description/
    /// </summary>
    internal class JumpGame
    {
        //Semi optimized
        public static bool CanJump(int[] nums)
        {
            bool[] dp = new bool[nums.Length];

            dp[nums.Length - 1] = true;

            for (int i = nums.Length - 2; i >= 0; i--)
            {
                int steps = nums[i];
                if (steps == 0) continue;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (steps-- <= 0) break;

                    if (dp[j])
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[0];
        }

        public static bool CanJumpV2(int[] nums)
        {
            int finalIndex = nums.Length - 1;

            for (int index = nums.Length - 2; index >= 0; index--)
            {
                if (nums[index] + index >= finalIndex)
                {
                    finalIndex = index;
                }
            }

            return finalIndex == 0;
        }
    }
}
