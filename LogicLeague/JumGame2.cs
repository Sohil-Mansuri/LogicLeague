namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/jump-game-ii/description/
    /// </summary>
    internal class JumGame2
    {
        public static int Jump(int[] nums)
        {
            int jump = 0;
            int currentMaxIndex = 0;
            int currentEnd = 0;

            for (int index = 0; index < nums.Length - 1; index++)
            {
                currentMaxIndex = Math.Max(currentMaxIndex, nums[index] + index);

                if (index == currentEnd)
                {
                    jump++;
                    currentEnd = currentMaxIndex;
                }
            }

            return jump;
        }
    }
}
