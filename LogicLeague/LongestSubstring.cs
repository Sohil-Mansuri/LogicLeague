namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
    /// </summary>
    internal class LongestSubstring
    {
        /// <summary>
        /// using Sliding window and 2 pointers
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int LengthOfLongestSubstring(string input)
        {
            Dictionary<char, int> hashMap = [];

            int start = 0;
            int maxLength = 0;

            for (int end = 0; end < input.Length; end++)
            {
                if (hashMap.ContainsKey(input[end]))
                {
                    if (hashMap[input[end]] >= start)
                    {
                        start = hashMap[input[end]] + 1;
                    }
                }

                hashMap[input[end]] = end;
                maxLength = Math.Max(maxLength, end - start + 1);
            }

            return maxLength;
        }


        /// <summary>
        /// Using Span (Stack allocation)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int LengthOfLongestSubstringV2(string input)
        {
            Span<int> asciiArray = stackalloc int[256];

            for (int i = 0; i < asciiArray.Length; i++)
            {
                asciiArray[i] = -1;
            }

            int maxLength = 0;

            int start = 0;

            for (int end = 0; end < input.Length; end++)
            {
                var temp = (byte)input[end];

                if (asciiArray[temp] >= start)
                    start = asciiArray[temp] + 1;

                asciiArray[temp] = end;
                maxLength = Math.Max(maxLength, end - start + 1);
            }

            return maxLength;
        }

        //Using Hash
        public static int LengthOfLongestSubstringV3(string input)
        {
            int maxLength = 0;
            int left = 0;
            HashSet<char> hash = [];

            for (int right = 0; right < input.Length; right++)
            {
                while (hash.Contains(input[right]))
                {
                    hash.Remove(input[left]);
                    left++;
                }

                hash.Add(input[right]);

                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}
