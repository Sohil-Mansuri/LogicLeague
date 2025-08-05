namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/plus-one/
    /// </summary>
    internal class PlusOneProblem
    {
        public static int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }

                digits[i] = 0;
            }

            var newArray = new int[digits.Length + 1];
            newArray[0] = 1;
            return newArray;
        }
    }
}
