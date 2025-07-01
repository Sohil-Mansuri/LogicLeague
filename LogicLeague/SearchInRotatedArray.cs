namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/search-in-rotated-sorted-array/
    /// </summary>
    internal class SearchInRotatedArray
    {
        public static int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                if (nums[left] == target) return left;

                if (nums[right] == target) return right;

                int middle = (left + right) / 2;

                if (target == nums[middle]) return middle;

                if (nums[left] < nums[middle])
                {
                    if (target < nums[left] || target > nums[middle])
                    {
                        left = middle + 1;
                    }
                    else
                    {
                        right = middle - 1;
                    }
                }
                else
                {
                    if (target < nums[middle] || target > nums[right])
                    {
                        right = middle - 1;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }
            }


            return -1;

        }
    }
}
