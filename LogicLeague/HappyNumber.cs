namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/happy-number/
    /// </summary>
    internal class HappyNumber
    {
        public static bool IsHappy(int n)
        {
            if (n == 1) return true;

            int slowRunner = n;
            int fastRunner = GetSquareSum(n);

            while (fastRunner != 1 && slowRunner != fastRunner)
            {
                slowRunner = GetSquareSum(slowRunner);
                fastRunner = GetSquareSum(GetSquareSum(fastRunner));
            }

            return fastRunner == 1;
        }


        private static int GetSquareSum(int n)
        {
            int divident = n;
            int squareSum = 0;
            while (divident > 0)
            {
                int remainder = divident % 10;
                squareSum += remainder * remainder;
                divident = divident / 10;
            }

            return squareSum;
        }
    }
}
