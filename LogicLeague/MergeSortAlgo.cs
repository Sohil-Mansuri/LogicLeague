namespace LogicLeague
{
    internal class MergeSortAlgo
    {
        public static int[] Sort(int[] nums)
        {
            MergeSort(ref nums, 0, nums.Length - 1);
            return nums;
        }

        private static void MergeSort(ref int[] nums, int low, int high)
        {
            if (low == high) return;

            int mid = (low + high) / 2;

            MergeSort(ref nums, low, mid);
            MergeSort(ref nums, mid + 1, high);
            Merge(ref nums, low, mid, high);
        }

        private static void Merge(ref int[] nums, int low, int mid, int high)
        {
            int left = low;
            int right = mid + 1;
            List<int> result = [];
            while (left <= mid && right <= high)
            {
                if (nums[left] <= nums[right])
                {
                    result.Add(nums[left]);
                    left++;
                }
                else
                {
                    result.Add(nums[right]);
                    right++;
                }
            }

            while (left <= mid)
            {
                result.Add(nums[left]);
                left++;
            }

            while (right <= high)
            {
                result.Add(nums[right]);
                right++;
            }

            //add all elements back to main array
            for (int i = low; i <= high; i++)
            {
                nums[i] = result[i - low];
            }
        }
    }
}
