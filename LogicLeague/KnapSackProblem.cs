namespace LogicLeague
{
    internal class KnapSackProblem
    {
        public static int Knapsack(int[] weights, int[] values, int capacity)
        {
            int[,] dp = new int[weights.Length + 1, capacity + 1];

            for (int i = 1; i <= weights.Length; i++)
            {
                for (int currentBagSize = 0; currentBagSize <= capacity; currentBagSize++)
                {
                    if (weights[i - 1] > currentBagSize)
                    {
                        dp[i, currentBagSize] = dp[i - 1, currentBagSize];
                    }
                    else
                    {
                        dp[i, currentBagSize] = Math.Max(dp[i - 1, currentBagSize], values[i - 1] + dp[i - 1, currentBagSize - weights[i - 1]]);
                    }
                }
            }

            return dp[weights.Length, capacity];
        }
    }
}
