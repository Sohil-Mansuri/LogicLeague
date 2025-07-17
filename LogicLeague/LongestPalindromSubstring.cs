namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/longest-palindromic-substring/
    /// </summary>
    internal class LongestPalindromSubstring
    {
        public static string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1) return s;

            string ans = string.Empty;

            for (int index = 1; index < s.Length; index++)
            {
                // for odd
                int low = index;
                int high = index;

                while (s[low] == s[high])
                {
                    low--;
                    high++;

                    if (low == -1 || high == s.Length) break;
                }

                string palindrom = s.Substring(low + 1, high - low - 1);
                if (palindrom.Length > ans.Length)
                    ans = palindrom;


                //for even 
                low = index - 1;
                high = index;

                while(s[low] == s[high])
                {
                    low--; high++;

                    if (low == -1 || high == s.Length) break;
                }

                palindrom = s.Substring(low + 1, high - low - 1);
                if (palindrom.Length > ans.Length)
                    ans = palindrom;
            }

            return ans;
        }
    }
}
