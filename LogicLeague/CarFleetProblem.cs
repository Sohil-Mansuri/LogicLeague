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

        //using stack
        public static int CarFleetV2(int target, int[] position, int[] speed)
        {
            var carFleets = new CarFleet[position.Length];
            for (int i = 0; i < position.Length; i++)
            {
                carFleets[i] = new CarFleet
                {
                    Position = position[i],
                    TimeToTarget = (target - position[i]) * 1.0 / speed[i]
                };
            }

            carFleets = [.. carFleets.OrderByDescending(x => x.Position)];

            var stack = new Stack<double>();
            stack.Push(carFleets[0].TimeToTarget);
            for (int i = 1; i < carFleets.Length; i++)
            {
                if (stack.Count > 0 && carFleets[i].TimeToTarget > stack.Peek())
                {
                    stack.Push(carFleets[i].TimeToTarget);
                }
            }


            return stack.Count;
        }

        public static int CarFleetV3(int target, int[] position, int[] speed)
        {
            var cars = new List<(int position, double time)>();

            for (int i = 0; i < position.Length; i++)
            {
                double time = (target - position[i]) * 1.0 / speed[i];
                cars.Add((position[i], time));
            }

            cars.Sort((a, b) => b.position.CompareTo(a.position));

            int fleets = 0;
            double lastFleetTime = 0;

            foreach (var car in cars)
            {
                if (car.time > lastFleetTime)
                {
                    fleets++;
                    lastFleetTime = car.time;
                }
            }

            return fleets;
        }
    }

    public class CarFleet
    {
        public int Position { get; set; }
        public double TimeToTarget { get; set; }
    }
}
