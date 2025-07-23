namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/longest-increasing-subsequence/
    /// </summary>
    internal class LongesMaximumSubSequence
    {
        // T(n) = O(n^2)
        public static int LengthOfLIS(int[] nums)
        {
            int[] dp = new int[nums.Length];
            dp[0] = 1;

            int max = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                dp[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }

                max = Math.Max(max, dp[i]);
            }

            return max;
        }

        //using patience sort T(n) = O(nlogn)
        public static int LengthOfLISV2(int[] nums)
        {
            List<int> dp = [];

            dp.Add(nums[0]);

            for (int index = 1; index < nums.Length; index++)
            {
                if (nums[index] > dp[dp.Count - 1])
                    dp.Add(nums[index]);
                else
                {
                    int j = BinerySearch(dp, nums[index]);
                    dp[j] = nums[index];
                }
            }

            return dp.Count;
        }

        private static int BinerySearch(List<int> dp, int target)
        {
            int left = 0;
            int right = dp.Count - 1;

            while (left < right)
            {
                int mid = (left + right) / 2;

                if (target == dp.ElementAt(mid))
                {
                    return mid;
                }
                else if (dp[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            return left;
        }
    }
}
