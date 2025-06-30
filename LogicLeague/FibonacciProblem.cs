namespace LogicLeague
{
    internal class FibonacciProblem
    {
        //normal (with recursion) T(n) = O(2^n)
        public static int Fib(int number)
        {
            if (number <= 1) return number;

            return Fib(number - 1) + Fib(number - 2);
        }


        // Dynamic programming (Top down, Memorization) T(n) = O(n) = S(n)
        public static int FibV2(int number, Dictionary<int, int> memo)
        {
            if (memo.ContainsKey(number)) return memo[number];

            if (number <= 1) return number;

            memo[number] = FibV2(number - 1, memo) + FibV2(number - 2, memo);

            return memo[number];
        }

        //Dynamic programming (Botton-up, Tabulated) T(n) = O(n) = S(n)
        public static int FibV3(int number)
        {
            if (number <= 1) return number;

            var dp = new int[number + 1];

            dp[0] = 0; dp[1] = 1;

            for (int index = 2; index <= number; index++)
            {
                dp[index] = dp[index - 1] + dp[index - 2];
            }

            return dp[number];
        }

        // optimal using Bottom up DP, T(n) = O(n) and S(n) = O(1)
        public static int FibV4(int number)
        {
            if (number <= 1) return number;

            int previous1 = 1; int previous2 = 0;

            for (int index = 2; index <= number; index++)
            {
                int current = previous1 + previous2;

                previous2 = previous1;
                previous1 = current;
            }

            return previous1;
        }
    }
}
