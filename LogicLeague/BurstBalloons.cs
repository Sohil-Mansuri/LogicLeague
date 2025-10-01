namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/burst-balloons/description/
    /// </summary>
    internal class BurstBalloons
    {
        public static int MaxCoins(int[] nums)
        {
            int n = nums.Length;
            int[] inputs = new int[n + 2];

            inputs[0] = 1;
            inputs[n + 1] = 1;
            for (int i = 1; i <= n; i++)
            {
                inputs[i] = nums[i - 1];
            }

            int[,] dp = new int[n + 2, n + 2];

            for (int i = n; i >= 1; i--)
            {
                for (int j = i; j <= n; j++)
                {
                    int maxi = 0;
                    for (int index = i; index <= j; index++)
                    {
                        int cost = inputs[i - 1] * inputs[index] * inputs[j + 1];
                        cost += dp[i, index - 1] + dp[index + 1, j];

                        maxi = Math.Max(maxi, cost);
                    }

                    dp[i, j] = maxi;
                }
            }

            return dp[1, n];
        }
    }
}
