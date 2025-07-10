using System;

namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/contains-duplicate/
    /// </summary>
    internal class FindDuplicate
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> elements = [];

            foreach (var num in nums)
            {
                if (elements.Contains(num))
                    return true;

                elements.Add(num);
            }

            return false;
        }


        /// <summary>
        /// https://leetcode.com/problems/contains-duplicate-ii/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        /// This one is faster because we are not removing here, just lookup and update
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> elements = [];

            for (int i = 0; i < nums.Length; i++)
            {
                if (elements.ContainsKey(nums[i]))
                {
                    if (Math.Abs(i - elements[nums[i]]) <= k)
                    {
                        return true;
                    }

                    elements[nums[i]] = i;
                }
                else
                {
                    elements[nums[i]] = i;
                }
            }


            return false;
        }

        // Sliding window concept
        public static bool ContainsNearbyDuplicateV2(int[] nums, int k)
        {
            HashSet<int> elements = new(k);

            for (int index = 0; index < nums.Length; index++)
            {
                if (elements.Contains(nums[index])) return true;

                elements.Add(nums[index]);

                if (elements.Count > k)
                    elements.Remove(nums[index - k]);
            }

            return false;
        }
    }
}
