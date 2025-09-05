namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/contiguous-array/
    /// </summary>
    internal class ContiguousArrary
    {
        public static int FindMaxLength(int[] nums)
        {
            Dictionary<int, int> map = [];
            map[0] = -1;
            int count = 0, maxLength = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                count += nums[i] == 1 ? 1 : -1;

                if (map.ContainsKey(count))
                {
                    maxLength = Math.Max(maxLength, i - map[count]);
                }
                else
                {
                    map[count] = i;
                }
            }

            return maxLength;

        }
    }
}
