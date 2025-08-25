namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/roman-to-integer/
    /// </summary>
    internal class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            Dictionary<string, int> map = new()
            {
                {"I", 1 }, {"V", 5}, {"X", 10}, {"L", 50}, {"C", 100}, {"D", 500}, {"M", 1000},
                {"IV", 4 }, {"IX", 9}, {"XL", 40}, {"XC", 90}, {"CD", 400}, {"CM", 900}
            };

            if (s.Length == 1) return map[s[0].ToString()];

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var key = i == s.Length - 1 ? s[i].ToString() : s.Substring(i, 2);
                if (map.ContainsKey(key))
                {
                    result += map[key.ToString()];
                    i++;
                }
                else
                {
                    result += map[key[0].ToString()];
                }
            }

            return result;
        }

        // XIV = 10 -1 + 5 = 14
        public static int RomanToIntV2(string s)
        {
            Dictionary<char, int> map = new()
                {
                    {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
                    {'C', 100}, {'D', 500}, {'M', 1000}
                };

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int value = map[s[i]];

                // Look ahead: if the next numeral is larger, subtract current
                if (i + 1 < s.Length && map[s[i]] < map[s[i + 1]])
                    result -= value;
                else
                    result += value;
            }

            return result;
        }
    }
}
