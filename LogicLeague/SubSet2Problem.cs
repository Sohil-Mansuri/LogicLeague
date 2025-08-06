namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/subsets-ii/description/
    /// </summary>
    internal class SubSet2Problem
    {
        public static IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            Array.Sort(nums);
            var result = new List<IList<int>>();

            Backtrack(result, nums, [], 0);
            return result;
        }

        private static void Backtrack(List<IList<int>> result, int[] nums, List<int> combination, int index)
        {
            result.Add([.. combination]);

            for (int i = index; i < nums.Length; i++)
            {
                if (i > index && nums[i] == nums[i - 1]) continue;

                combination.Add(nums[i]);
                Backtrack(result, nums, combination, i + 1);
                combination.RemoveAt(combination.Count - 1);
            }
        }
    }
}
