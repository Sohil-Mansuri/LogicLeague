namespace LogicLeague.CodingPatterns._1.TwoPointers
{
    /// <summary>
    /// https://leetcode.com/problems/move-zeroes/
    /// </summary>
    internal class MoveZeros
    {

        public static int[] MoveZeroesV2(int[] nums)
        {
            int left = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                if (nums[right] != 0)
                {
                    (nums[left], nums[right]) = (nums[right], nums[left]);
                    left++;
                }
            }

            return nums;
        }


        public static int[] MoveZeroes(int[] nums)
        {
            if (nums is null || nums.Length == 0) return nums;

            if (nums.Length == 1) return nums;

            int left = 0;
            int right = 0;

            while (right < nums.Length)
            {
                if (nums[left] != 0)
                {
                    left++;
                }
                else if (nums[right] != 0)
                {
                    nums[left++] = nums[right];
                    nums[right] = 0;
                }

                right++;
            }

            return nums;
        }
    }
}
