
namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-partitioning/
    /// </summary>
    internal class PalindromePartition
    {
        public static IList<IList<string>> Partition(string input)
        {
            IList<IList<string>> result = [];

            Backtrack(result, input, [], 0);

            return result;
        }

        private static void Backtrack(IList<IList<string>> result, string s, List<string> combination, int start)
        {
            if (start == s.Length)
            {
                result.Add([.. combination]);
                return;
            }

            for (int end = start; end < s.Length; end++)
            {
                if (IsValid(s, start, end))
                {
                    combination.Add(s.Substring(start, end - start + 1));
                    Backtrack(result, s, combination, end + 1);
                    combination.RemoveAt(combination.Count - 1);
                }
            }
        }

        private static bool IsValid(string s, int left, int right)
        {
            while (left < right)
            {
                if (s[left] != s[right]) return false;
                left++;
                right--;
            }

            return true;
        }
    }
}
