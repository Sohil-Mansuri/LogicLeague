
namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/subsets/
    /// </summary>
    internal class SubSetsProblem
    {
        public static IList<IList<int>> Subsets(int[] nums)
        {
            if (nums.Length == 1) return [[], [nums[0]]];

            IList<IList<int>> result = [];

            FindSubSets(result, nums, 0, []);

            return result;
        }

        private static void FindSubSets(IList<IList<int>> result, int[] nums, int index, IList<int> current)
        {
            result.Add([.. current]);

            for (int i = index; i < nums.Length; i++)
            {
                current.Add(nums[i]);
                FindSubSets(result, nums, i + 1, current);
                current.Remove(nums[i]);
            }
        }
    }
}
