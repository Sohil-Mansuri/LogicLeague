namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/climbing-stairs/description/
    /// </summary>
    public class ClimbingStairs
    {
        public static int ClimbStairs(int n)
        {
            if (n == 0 || n == 1) return 1;

            int last1 = 1;
            int last2 = 1;

            for (int index = 2; index <= n; index++)
            {
                int current = last1 + last2;
                last2 = last1;
                last1 = current;
            }

            return last1;
        }
    }
}
