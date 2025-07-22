
namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/combination-sum/
    /// </summary>
    internal class CombinationSumProblem
    {
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> result = [];
            IList<int> combination = [];

            BackTrack(target, result, combination, candidates, 0);
            return result;
        }

        private static void BackTrack(int target, IList<IList<int>> result, IList<int> combination, int[] candidates, int start)
        {
            if (target == 0)
            {
                result.Add([.. combination]);
                return;
            }
            else if (target < 0)
            {
                return;
            }


            for (int index = start; index < candidates.Length; index++)
            {
                combination.Add(candidates[index]);
                BackTrack(target - candidates[index], result, combination, candidates, index);
                combination.RemoveAt(combination.Count - 1);
            }
        }
    }
}
