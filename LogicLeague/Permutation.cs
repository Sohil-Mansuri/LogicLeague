
namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/permutations/
    /// </summary>
    internal class Permutation
    {
        public static IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> result = [];
            HashSet<int> visited = [];
            Backtrack(result, nums, new List<int>(), visited);
            return result;
        }

        private static void Backtrack(IList<IList<int>> result, int[] nums, List<int> combination, HashSet<int> visited)
        {
            if (combination.Count == nums.Length)
            {
                result.Add([.. combination]);
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (visited.Contains(i)) continue;

                combination.Add(nums[i]);
                visited.Add(i);
                Backtrack(result, nums, combination, visited);
                combination.RemoveAt(combination.Count - 1);
                visited.Remove(i);
            }
        }

        public static IList<IList<int>> PermuteV2(int[] nums)
        {
            IList<IList<int>> result = [];
            bool[] visited = new bool[nums.Length];
            Backtrack(result, nums, new List<int>(), visited);
            return result;
        }

        private static void Backtrack(IList<IList<int>> result, int[] nums, List<int> combination, bool[] visited)
        {
            if (combination.Count == nums.Length)
            {
                result.Add([.. combination]);
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (visited[i]) continue;

                combination.Add(nums[i]);
                visited[i] = true;
                Backtrack(result, nums, combination, visited);
                combination.RemoveAt(combination.Count - 1);
                visited[i] = false;
            }
        }
    }
}
