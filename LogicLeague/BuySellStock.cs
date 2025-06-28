namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    /// </summary>
    internal class BuySellStock
    {
        /// <summary>
        /// Buy when price is low, sell when price is high
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public static int MaxProfit(int[] prices)
        {
            int buyPrice = prices[0];
            int profit = 0;

            foreach (var price in prices)
            {
                if (buyPrice > price)
                {
                    buyPrice = price;
                }
                else
                {
                    profit = Math.Max(profit, price - buyPrice);
                }
            }


            return profit;
        }
    }
}
