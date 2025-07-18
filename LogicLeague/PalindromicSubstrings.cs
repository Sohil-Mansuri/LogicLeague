namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/palindromic-substrings/description/
    /// </summary>
    internal class PalindromicSubstrings
    {
        public static int CountSubstrings(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            if (s.Length == 1) return 1;

            int count = 1;

            for (int index = 1; index < s.Length; index++)
            {
                //for odd
                int low = index;
                int high = index;

                while (s[low] == s[high])
                {
                    count++;

                    low--;
                    high++;

                    if (low == -1 || high == s.Length) break;
                }

                //for even
                low = index - 1;
                high = index;

                while (s[low] == s[high])
                {
                    count++;

                    low--;
                    high++;

                    if (low == -1 || high == s.Length) break;
                }
            }

            return count;
        }
    }
}
