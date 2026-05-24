namespace LogicLeague.Simple
{
    public class StringAndCharacterExample
    {
        //Find First Non-Repeating Character in a String
        public static char FirstNonRepeatingCharacter(string input)
        {
            int[] count = new int[26];

            foreach (var ch in input)
            {
                count[ch - 'a']++;
            }

            foreach (var ch in input)
            {
                if (count[ch - 'a'] == 1)
                {
                    return ch;
                }
            }

            return '\0';
        }

        public static bool IsAnagram(string s1, string s2)
        {
            Dictionary<char, int> map = [];

            if (s1.Length != s2.Length)
                return false;

            foreach (var ch in s1)
            {
                map[ch] = map.GetValueOrDefault(ch) + 1;
            }


            foreach (var ch in s2)
            {
                if (map.ContainsKey(ch))
                {
                    map[ch]--;

                    if (map[ch] == 0)
                        map.Remove(ch);
                }
            }

            return map.Count == 0;

        }


        public static char FirstRepeatingCharacter(string input)
        {
            int[] count = new int[26];

            foreach (var ch in input)
            {
                count[ch - 'a']++;
            }

            foreach (var ch in input)
            {
                if (count[ch - 'a'] > 1)
                {
                    return ch;
                }
            }

            return '\0';
        }

        public static char[] FindDuplicateCharacter(string input)
        {
            int[] count = new int[26];

            foreach (var ch in input)
            {
                count[ch - 'a']++;
            }

            HashSet<char> result = [];

            foreach (var ch in input)
            {
                if (count[ch - 'a'] > 1)
                    result.Add(ch);
            }

            return result.ToArray();
        }
    }
}
