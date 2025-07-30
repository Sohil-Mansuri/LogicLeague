namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/koko-eating-bananas/description/
    /// </summary>
    internal class KokoEatingBanana
    {
        public static int MinEatingSpeed(int[] piles, int hour)
        {
            int left = 1;
            int right = piles[0];
            for (int i = 1; i < piles.Length; i++)
            {
                right = Math.Max(right, piles[i]);
            }


            while (left < right)
            {
                int mid = (left + right) / 2;

                if (CanFinish(mid, piles, hour))
                    right = mid;
                else
                    left = mid + 1;
            }

            return left;
        }

        private static bool CanFinish(int speed, int[] piles, int maxHour)
        {
            double hours = 0;

            for (int i = 0; i < piles.Length; i++)
            {
                hours += Math.Ceiling((double)piles[i] / speed);
            }

            return hours <= maxHour;
        }
    }
}
