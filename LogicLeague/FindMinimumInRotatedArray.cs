namespace LogicLeague
{
    internal class FindMinimumInRotatedArray
    {
        /// <summary>
        /// https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindMin(int[] nums)
        {
            if (nums.Length == 1) return nums[0];

            int left = 0;
            int right = nums.Length - 1;
            int result = nums[0];

            while (left <= right)
            {
                if (nums[left] < nums[right])
                {
                    result = Math.Min(result, nums[left]);
                }
                else
                {
                    result = Math.Min(result, nums[right]);
                }

                int mid = (left + right) / 2;

                result = Math.Min(result, nums[mid]);

                if (nums[left] <= nums[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }
    }
}
