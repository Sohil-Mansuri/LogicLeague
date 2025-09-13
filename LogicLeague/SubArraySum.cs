namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/subarray-sum-equals-k/description/
    /// </summary>
    internal class SubArraySum
    {
        public static int SubarraySum(int[] nums, int k)
        {
            int count = 0, prefixSum = 0;
            Dictionary<int, int> prefixSumCount = [];

            prefixSumCount[0] = 1;

            foreach (var num in nums)
            {
                prefixSum += num;

                if (prefixSumCount.ContainsKey(prefixSum - k))
                {
                    count += prefixSumCount[prefixSum - k];
                }

                if (!prefixSumCount.ContainsKey(prefixSum))
                    prefixSumCount[prefixSum] = 0;

                prefixSumCount[prefixSum]++;
            }


            return count;
        }
    }
}
