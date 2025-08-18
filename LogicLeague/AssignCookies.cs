namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/assign-cookies/description/
    /// </summary>

    internal class AssignCookies
    {
        public static int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);
            int count = 0;
            int cookieIndex = 0, childIndex = 0;

            while (cookieIndex < s.Length && childIndex < g.Length)
            {
                if (s[cookieIndex] >= g[childIndex])
                {
                    count++;
                    childIndex++;
                }

                cookieIndex++;
            }

            return count;
        }
    }
}
