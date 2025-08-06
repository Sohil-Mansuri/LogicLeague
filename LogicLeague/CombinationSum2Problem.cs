
namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/combination-sum-ii/description/
    /// </summary>
    internal class CombinationSum2Problem
    {
        public static IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            IList<IList<int>> result = [];
            Array.Sort(candidates);
            Backtrack(result, candidates, [], target, 0);

            return result;
        }

        private static void Backtrack(IList<IList<int>> result, int[] candidates, List<int> combination, int target, int index)
        {
            if (target == 0)
            {
                result.Add([.. combination]);
                return;
            }

            for (int i = index; i < candidates.Length; i++)
            {
                if (i > index && candidates[i] == candidates[i - 1]) continue;

                if (target - candidates[i] < 0) break;

                combination.Add(candidates[i]);
                Backtrack(result, candidates, combination, target - candidates[i], i + 1);
                combination.RemoveAt(combination.Count - 1);
            }
        }
    }
}
