namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/longest-consecutive-sequence/description/
    /// </summary>
    internal class LongestConsecutiveSequence
    {
        public static int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0) return 0;

            HashSet<int> hash = [];
            int curretMaxLenght;
            int maximumLenth = 1;

            foreach (int num in nums)
            {
                hash.Add(num);
            }

            foreach (var item in hash)
            {
                if (hash.Contains(item - 1)) continue;
                else
                {
                    curretMaxLenght = 1;
                    while(hash.Contains(item + curretMaxLenght))
                        curretMaxLenght++;

                    maximumLenth = Math.Max(maximumLenth, curretMaxLenght);
                }
            }

            return maximumLenth;
        }
    }
}
