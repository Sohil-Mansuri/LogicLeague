namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/coin-change/
    /// </summary>
    internal class CoinChangeProblem
    {
        public static int CoinChange(int[] coins, int amount)
        {
            Span<int> amt = stackalloc int[amount + 1];
            amt[0] = 0;

            for (int i = 1; i <= amount; i++)
            {
                amt[i] = amount + 1;
            }


            for (int currentAmount = 1; currentAmount <= amount; currentAmount++)
            {
                for (int coinIndex = 0; coinIndex < coins.Length; coinIndex++)
                {
                    if (currentAmount >= coins[coinIndex])
                    {
                        amt[currentAmount] = Math.Min(amt[currentAmount], 1 + amt[currentAmount - coins[coinIndex]]);
                    }
                }
            }

            if (amt[amount] < amount + 1) return amt[amount];

            return -1;
        }
    }
}
