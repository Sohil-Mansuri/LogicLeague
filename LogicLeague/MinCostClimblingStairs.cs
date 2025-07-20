namespace LogicLeague
{
    internal class MinCostClimblingStairs
    {
        public static int MinCostClimbingStairs(int[] cost)
        {
            int lastCost = cost[1];
            int secondLastCost = cost[0];

            for (int index = 2; index < cost.Length; index++)
            {
                int current = Math.Min(cost[index] + lastCost, cost[index] + secondLastCost);
                secondLastCost = lastCost;
                lastCost = current;
            }

            return Math.Min(lastCost, secondLastCost);
        }
    }
}
