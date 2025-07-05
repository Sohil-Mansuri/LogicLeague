namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/median-of-two-sorted-arrays/
    /// </summary>
    internal class MedianOfSortedArrary
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length) return FindMedianSortedArrays(nums2, nums1);

            int low = 0; int high = nums1.Length;

            int totalElements = nums1.Length + nums2.Length;
            int left = (totalElements + 1) / 2;

            while (low <= high)
            {
                int mid1 = (low + high) / 2;
                int mid2 = left - mid1;
                int l1 = mid1 - 1 >= 0 ? nums1[mid1 - 1] : int.MinValue;
                int l2 = mid2 - 1 >= 0 ? nums2[mid2 - 1] : int.MinValue;

                int r1 = mid1 < nums1.Length ? nums1[mid1] : int.MaxValue;
                int r2 = mid2 < nums2.Length ? nums2[mid2] : int.MaxValue;
                if (l1 <= r2 && l2 <= r1)
                {
                    if (totalElements % 2 != 0) return Math.Max(l1, l2);
                    else
                    {
                        return (double)(Math.Max(l1, l2) + Math.Min(r1, r2)) / 2.0;
                    }
                }
                else if (l1 > r2) high = mid1 - 1;
                else low = mid1 + 1;
            }

            return 0;
        }
    }
}
