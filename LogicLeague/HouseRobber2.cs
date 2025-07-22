using System;

namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/house-robber-ii/
    /// </summary>
    internal class HouseRobber2
    {
        public static int Rob(int[] nums)
        {
            if(nums.Length == 1) return nums[0];

            int rob1 = 0;
            int rob2 = 0;

            //part 1 : 1 to n-1
            for (int index = 0; index < nums.Length - 1; index++)
            {
                int current = Math.Max(rob1, nums[index] + rob2);
                rob2 = rob1;
                rob1 = current;
            }

            int max1 = rob1;

            rob1 = rob2 = 0;

            //part2 : 2 to n
            for (int index = 1; index < nums.Length; index++)
            {
                int current = Math.Max(rob1, nums[index] + rob2);
                rob2 = rob1;
                rob1 = current;
            }

            return Math.Max(max1, rob1);
        }
    }
}
