namespace LogicLeague
{
    internal class MinimumWindowSubstring
    {
        public static string MinWindow(string s, string t)
        {
            if (string.IsNullOrEmpty(s) || s.Length < t.Length) return string.Empty;
            int minLength = int.MaxValue;
            int startIndex = -1;
            int required = t.Length;

            int count = 0;

            int left = 0; int right = 0;

            Dictionary<char, int> map = [];
            foreach (var item in t)
            {
                if (map.ContainsKey(item)) map[item]++;
                else map[item] = 1;
            }

            while (right < s.Length)
            {
                if (map.ContainsKey(s[right]))
                {
                    if (map[s[right]] > 0) count++;
                    map[s[right]]--;
                }


                while (count == required)
                {
                    if (right - left + 1 < minLength)
                    {
                        minLength = right - left + 1;
                        startIndex = left;
                    }

                    if (map.ContainsKey(s[left]))
                    {
                        map[s[left]]++;

                        if (map[s[left]] > 0) count--;
                    }

                    left++;
                }

                right++;
            }

            if (startIndex == -1) return string.Empty;

            return s.Substring(startIndex, minLength);
        }
    }
}
