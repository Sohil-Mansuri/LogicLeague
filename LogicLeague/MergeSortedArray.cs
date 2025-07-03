namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/merge-sorted-array/
    /// </summary>
    internal class MergeSortedArray
    {
        /// <summary>
        /// T(n) = O(n) and S(n) = O(1)
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        public static int[] Merge(int[] nums1, int[] nums2)
        {
            List<int> result = [];

            int left = 0; int right = 0;

            while (left < nums1.Length)
            {
                if (nums1[left] < nums2[right])
                {
                    result.Add(nums1[left]);
                    left++;
                }
                else
                {
                    result.Add(nums2[right]);
                    right++;
                }

                if (right == nums2.Length)
                {
                    while (left < nums1.Length)
                    {
                        result.Add(nums1[left]);
                        left++;
                    }
                }

                if (left == nums1.Length)
                {
                    while (right < nums2.Length)
                    {
                        result.Add(nums2[right]);
                        right++;
                    }
                }
            }

            return result.ToArray();
        }

        //https://leetcode.com/problems/merge-sorted-array/
        //T(n) = O(n) and S(n) = O(1)
        public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (m == 0 && n == 0) return [];

            if (n == 0) return nums1;

            int right = nums1.Length - 1;
            m--; n--;
            while (n >= 0)
            {
                if (m < 0)
                {
                    while (n >= 0)
                    {
                        nums1[right--] = nums2[n--];
                    }

                    break;
                }

                if (nums1[m] <= nums2[n])
                {
                    nums1[right--] = nums2[n--];
                }
                else
                {
                    nums1[right--] = nums1[m--];
                }
            }

            return nums1;
        }

    }
}
