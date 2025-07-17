
namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/valid-palindrome/
    /// </summary>
    internal class ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            string alphaString = System.Text.RegularExpressions.Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();


            int left = 0;
            int right = alphaString.Length - 1;

            while (left < right)
            {
                if (alphaString[left++] != alphaString[right--])
                    return false;
            }

            return true;

        }
    }
}
