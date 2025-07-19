namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/letter-combinations-of-a-phone-number/
    /// </summary>
    internal class LetterCombination
    {
        private static string[] map = ["", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"];

        public static IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits)) return [];

            IList<string> result = [];

            BackTrack(result, digits, "", 0);
            return result;

        }

        private static void BackTrack(IList<string> result, string digits, string combination, int index)
        {
            if (index == digits.Length)
            {
                result.Add(combination);
                return;
            }

            string letters = map[digits[index] - '0'];


            for (int i = 0; i < letters.Length; i++)
            {
                BackTrack(result, digits, combination + letters[i], index + 1);
            }
        }
    }
}
