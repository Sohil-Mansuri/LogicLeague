
namespace LogicLeague.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/cheapest-flights-within-k-stops/
    /// </summary>
    internal class CheapestFlightWithKStops
    {
        public static int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
        {
            int[] cost = new int[n];

            Array.Fill(cost, int.MaxValue);

            cost[src] = 0;
            for (int i = 0; i <= k; i++)
            {
                int[] temp = Clone(cost);

                foreach (var flight in flights)
                {
                    var source = flight[0];
                    var destination = flight[1];
                    var price = flight[2];

                    if (cost[source] == int.MaxValue) continue;

                    if (cost[source] + price < temp[destination])
                        temp[destination] = cost[source] + price;
                }

                cost = temp;
            }

            return cost[dst] == int.MaxValue ? -1 : cost[dst];
        }

        private static int[] Clone(int[] array)
        {
            int[] cloneed = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                cloneed[i] = array[i];
            }

            return cloneed;
        }
    }
}
