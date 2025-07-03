namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/verifying-an-alien-dictionary/description/
    /// </summary>
    internal class AlienDictionary
    {
        public static bool IsAlienSorted(string[] words, string order)
        {
            if (words.Length == 0) return false;

            if (words.Length == 1) return true;

            Dictionary<char, int> wordsOrder = [];

            for (int index = 0; index < order.Length; index++)
            {
                wordsOrder[order[index]] = index;
            }

            for (int index = 0; index < words.Length - 1; index++)
            {
                string firstWord = words[index];
                string secondWord = words[index + 1];

                for (int wordIndex = 0; wordIndex < firstWord.Length; wordIndex++)
                {
                    if (wordIndex > secondWord.Length - 1) return false;
                    if (firstWord[wordIndex] == secondWord[wordIndex]) continue;
                    else if (wordsOrder[firstWord[wordIndex]] > wordsOrder[secondWord[wordIndex]])
                    {
                        return false;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return true;
        }
    }
}
