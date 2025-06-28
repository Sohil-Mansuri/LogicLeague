namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// </summary>
    internal class TwoSumProblem
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> keyValuePairs = [];

            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (keyValuePairs.ContainsKey(diff))
                {
                    return [keyValuePairs[diff], i];
                }

                keyValuePairs[nums[i]] = i;
            }

            return [];
        }
    }
}
