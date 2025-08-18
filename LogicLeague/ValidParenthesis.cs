namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/valid-parenthesis-string/
    /// </summary>
    internal class ValidParenthesis
    {
        public static bool CheckValidString(string s)
        {
            int minOpen = 0, maxOpen = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    minOpen++;
                    maxOpen++;
                }
                else if (s[i] == ')')
                {
                    minOpen--;
                    maxOpen--;
                }
                else
                {
                    minOpen--;
                    maxOpen++;
                }

                if (maxOpen < 0) return false;

                minOpen = Math.Max(minOpen, 0);
            }


            return minOpen == 0;
        }
    }
}
