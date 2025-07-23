namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/race-car/
    /// </summary>
    internal class RaceCarProblemV2
    {
        public static int Racecar(int target)
        {
            // DP array to store the minimum steps to reach each target
            int[] dp = new int[target + 1];

            // Fill all as -1 (unvisited), except index 0
            for (int i = 1; i <= target; i++)
            {
                dp[i] = -1;
            }

            return GetMinSteps(target, dp);
        }

        private static int GetMinSteps(int target, int[] dp)
        {
            // If already solved, return the cached answer
            if (dp[target] != -1)
                return dp[target];

            int minSteps = int.MaxValue;

            // Try all positions j = (1 << steps) - 1 → after doing `steps` accelerates
            for (int forwardSteps = 1; ; forwardSteps++)
            {
                int forwardPos = (1 << forwardSteps) - 1;

                if (forwardPos > 2 * target) break; // stop if too far

                if (forwardPos == target)
                {
                    // Exact hit with just forwardSteps
                    minSteps = forwardSteps;
                    break;
                }
                else if (forwardPos > target)
                {
                    // Overshoot and reverse back
                    int steps = forwardSteps + 1 + GetMinSteps(forwardPos - target, dp);
                    minSteps = Math.Min(minSteps, steps);
                }
                else
                {
                    // Try reversing before reaching target
                    for (int backSteps = 0; backSteps < forwardSteps; backSteps++)
                    {
                        int backPos = (1 << backSteps) - 1;
                        int remaining = target - (forwardPos - backPos);
                        if (remaining < 0) continue;

                        int steps = forwardSteps + 1 + backSteps + 1 + GetMinSteps(remaining, dp);
                        minSteps = Math.Min(minSteps, steps);
                    }
                }
            }

            dp[target] = minSteps;
            return minSteps;
        }
    }
}
