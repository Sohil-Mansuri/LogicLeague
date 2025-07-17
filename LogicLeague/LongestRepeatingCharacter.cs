namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/longest-repeating-character-replacement/description/
    /// </summary>
    internal class LongestRepeatingCharacter
    {
        public static int CharacterReplacement(string s, int k)
        {
            Span<int> elements = stackalloc int[26];
            int maxLength = 0;
            int left = 0;

            int maxOccurrence = 0;
            for (int right = 0; right < s.Length; right++)
            {
                maxOccurrence = Math.Max(maxOccurrence, ++elements[s[right] - 'A']);
                if (right - left + 1 - maxOccurrence > k)
                {
                    elements[s[left] - 'A']--;
                    left++;
                }
                else
                {
                    maxLength = Math.Max(maxLength, right - left + 1);
                }
            }

            return maxLength;
        }
    }
}
