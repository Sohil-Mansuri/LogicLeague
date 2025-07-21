
namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/decode-ways/
    /// </summary>
    internal class DecodeWays
    {
        public static int NumDecodings(string s)
        {
            if (s == null) return 0;
            int[] decodeWays = new int[s.Length + 1];
            decodeWays[0] = 1;

            decodeWays[1] = s[0] == '0' ? 0 : 1;

            for (int index = 2; index <= s.Length; index++)
            {
                var singleDigit = Convert.ToInt32(s.Substring(index - 1, 1));
                var doubleDigit = Convert.ToInt32(s.Substring(index - 2, 2));

                if (singleDigit >= 1)
                    decodeWays[index] = decodeWays[index - 1];

                if (doubleDigit >= 10 && doubleDigit <= 26)
                    decodeWays[index] += decodeWays[index - 2];

            }

            return decodeWays[s.Length];
        }

        public static int NumDecodingsV2(string s)
        {
            if (s == null) return 0;

            int firstLast = s[0] == '0' ? 0 : 1;
            int secondLast = 1;

            for (int index = 2; index <= s.Length; index++)
            {
                var singleDigit = Convert.ToInt32(s.Substring(index - 1, 1));
                var doubleDigit = Convert.ToInt32(s.Substring(index - 2, 2));

                int current = 0;
                if (singleDigit >= 1)
                    current = firstLast;

                if (doubleDigit >= 10 && doubleDigit <= 26)
                    current += secondLast;

                secondLast = firstLast;
                firstLast = current;

            }

            return firstLast;
        }
    }
}
