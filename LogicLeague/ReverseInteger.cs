using System.Text;

namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-integer/
    /// </summary>
    internal class ReverseInteger
    {
        public static int Reverse(int num)
        {
            int result = 0;

            while (num != 0)
            {
                int digit = num % 10;
                num /= 10;

                if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > 7))
                    return 0;
                if (result < int.MinValue / 10 || (result == int.MinValue / 10 && digit < -8))
                    return 0;

                result = result * 10 + digit;
            }

            return result;
        }
    }
}
