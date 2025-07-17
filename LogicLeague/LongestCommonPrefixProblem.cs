namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/longest-common-prefix/
    /// </summary>
    internal class LongestCommonPrefixProblem
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs is null || strs.Length == 0) return "";

            string prefix = strs[0];

            for (int index = 1; index < strs.Length; index++)
            {
                while (!strs[index].StartsWith(prefix))
                    prefix = prefix.Substring(0, prefix.Length - 1);

                if (string.IsNullOrEmpty(prefix)) return "";

            }

            return prefix;
        }
    }
}
