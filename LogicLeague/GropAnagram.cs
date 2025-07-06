using System.Text;

namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/group-anagrams/
    /// </summary>
    internal class GropAnagram
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> stringPares = [];
            Span<int> elementsFrequency = stackalloc int[26];

            for (int index = 0; index < strs.Length; index++)
            {
                elementsFrequency.Clear();

                foreach (var element in strs[index])
                {
                    elementsFrequency[element - 'a']++;
                }

                StringBuilder keyString = new StringBuilder();

                foreach (var element in elementsFrequency)
                {
                    keyString.Append('#');
                    keyString.Append(element);
                }

                if (stringPares.TryGetValue(keyString.ToString(), out var value))
                {
                    value.Add(strs[index]);
                }
                else
                {
                    stringPares.Add(keyString.ToString(), [strs[index]]);
                }
            }

            return stringPares.Values.ToList();

        }
    }
}
