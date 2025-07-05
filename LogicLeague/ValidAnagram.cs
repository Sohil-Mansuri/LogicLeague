namespace LogicLeague
{
    internal class ValidAnagram
    {
        public static bool IsAnagram(string original, string changed)
        {
            if (original.Length != changed.Length) return false;

            Dictionary<char, int> charFrequency = [];

            foreach (char c in original)
            {
                if (charFrequency.ContainsKey(c)) charFrequency[c]++;
                else charFrequency.Add(c, 1);
            }

            foreach (char c in changed)
            {
                if (charFrequency.ContainsKey(c))
                {
                    if (charFrequency[c] == 1) charFrequency.Remove(c);
                    else charFrequency[c]--;
                }
            }

            return charFrequency.Count == 0;
        }

        //
        public static bool IsAnagramV2(string original, string changed)
        {
            if (original.Length != changed.Length) return false;

            Span<int> elements = stackalloc int[26];


            for (int index = 0; index < original.Length; index++)
            {
                elements[original[index] - 'a']++;
                elements[changed[index] - 'a']--;

            }

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] != 0)
                    return false;
            }

            return true;
        }
    }
}
