namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/powx-n/description/    
    /// </summary>
    internal class PowProblem
    {
        public static double MyPow(double x, int n)
        {
            long inputPower = n;
            if (inputPower == 0) return 1;

            if (inputPower < 0)
            {
                x = 1 / x;
                inputPower = -inputPower;
            }

            double currentProduct = x;
            double result = 1;
            while (inputPower > 0)
            {
                if (inputPower % 2 == 1)
                {
                    result *= currentProduct;
                }

                currentProduct *= currentProduct;
                inputPower = inputPower / 2;
            }

            return result;
        }
    }
}
