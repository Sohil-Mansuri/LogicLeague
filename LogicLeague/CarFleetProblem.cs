namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/car-fleet/description/
    /// </summary>
    internal class CarFleetProblem
    {
        public static int CarFleet(int target, int[] position, int[] speed)
        {
            int size = position.Length;
            CarFleet[] carFleets = new CarFleet[position.Length];
            for (int i = 0; i < size; i++)
            {
                carFleets[i] = new CarFleet
                {
                    Position = position[i],
                    TimeToTarget = (target - position[i]) * 1.0 / speed[i]
                };
            }

            carFleets = [.. carFleets.OrderBy(x => x.Position)];

            int ans = 1;
            for (int i = size - 1; i >= 1; i--)
            {
                if (carFleets[i].TimeToTarget >= carFleets[i - 1].TimeToTarget)
                {
                    carFleets[i - 1] = carFleets[i];
                }
                else
                {
                    ans++;
                }
            }

            return ans;
        }
    }

    public class CarFleet
    {
        public int Position { get; set; }
        public double TimeToTarget { get; set; }
    }
}
