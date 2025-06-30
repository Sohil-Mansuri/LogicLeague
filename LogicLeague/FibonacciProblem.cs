namespace LogicLeague
{
    internal class FibonacciProblem
    {
        //normal (with recursion)
        public static int Fib(int number)
        {
            if (number <= 1) return number;

            return Fib(number - 1) + Fib(number - 2);
        }


        // Dynamic programming (Top down, Memorization)
        public static int FibV2(int number, Dictionary<int, int> memo)
        {
            if (memo.ContainsKey(number)) return memo[number];

            if (number <= 1) return number;

            memo[number] = FibV2(number - 1, memo) + FibV2(number - 2, memo);

            return memo[number];
        }

        //Dynamic programming (Botton-up, Tabulated)
        public static int FibV3(int number)
        {
            var dp = new int[number + 1];

            dp[0] = 0; dp[1] = 1;

            for (int index = 2; index <= number; index++)
            {
                dp[index] = dp[index - 1] + dp[index - 2];
            }

            return dp[number];
        }
    }
}
