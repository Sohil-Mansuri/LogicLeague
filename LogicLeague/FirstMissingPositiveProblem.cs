namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/first-missing-positive/description/
    /// </summary>
    internal class FirstMissingPositiveProblem
    {
        public static int FirstMissingPositive(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                while (nums[i] > 0 && nums[i] <= nums.Length && nums[nums[i] - 1] != nums[i])
                {
                    int temp = nums[i];
                    nums[i] = nums[temp - 1];
                    nums[temp - 1] = temp;
                }
            }


            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1) return i + 1;
            }

            return nums.Length + 1;
        }
    }
}
