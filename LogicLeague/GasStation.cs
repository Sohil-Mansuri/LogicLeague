namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/gas-station/description/
    /// </summary>
    internal class GasStation
    {
        public static int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int totalGas = 0;
            int totalCost = 0;
            int startingIndex = 0;
            int tank = 0;

            for (int i = 0; i < gas.Length; i++)
            {
                totalGas += gas[i];
                totalCost += cost[i];
                tank += gas[i] - cost[i];

                if (tank < 0)
                {
                    startingIndex = i + 1;
                    tank = 0;
                }
            }

            return totalGas < totalCost ? -1 : startingIndex;
        }


    }
}
