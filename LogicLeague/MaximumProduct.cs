using System;

namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-product-subarray/
    /// </summary>
    internal class MaximumProduct
    {

        public static int MaxProduct(int[] nums)
        {
            int min = nums[0]; int max = nums[0];

            int result = nums[0];

            for (int index = 1; index < nums.Length; index++)
            {
                var tempMin = nums[index] * min;
                var tempMax = nums[index] * max;

                min = Math.Min(nums[index], Math.Min(tempMin, tempMax));
                max = Math.Max(nums[index], Math.Max(tempMin, tempMax));

                result = Math.Max(result, max);
            }

            return result;
        }
    }
}
