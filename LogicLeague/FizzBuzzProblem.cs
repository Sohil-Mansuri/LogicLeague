
namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/fizz-buzz/
    /// </summary>
    internal class FizzBuzzProblem
    {
        private const string FizzText = "Fizz";
        private const string FizzBuzzText = "FizzBuzz";
        private const string BuzzText = "Buzz";

        public static IList<string> FizzBuzz(int n)
        {
            IList<string> result = [];

            for (int index = 1; index <= n; index++)
            {
                if (index % 15 == 0) result.Add(FizzBuzzText);
                else if (index % 3 == 0) result.Add(FizzText);
                else if (index % 5 == 0) result.Add(BuzzText);
                else result.Add(index.ToString());
            }

            return result;
        }
    }
}
