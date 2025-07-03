
namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/3sum/description/
    /// </summary>
    internal class ThreeSumProblem
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            var sortedNums = nums.OrderBy(x => x).ToList();
            IList<IList<int>> result = [];

            for (int index = 0; index < sortedNums.Count && sortedNums[index] <= 0; index++)
            {
                if (index > 0 && sortedNums[index] == sortedNums[index - 1]) continue;

                int left = index + 1;
                int right = sortedNums.Count - 1;
                int tempSum = 0;

                while (left < right)
                {
                    tempSum = sortedNums[index] + sortedNums[left] + sortedNums[right];
                    if (tempSum == 0)
                    {
                        result.Add([sortedNums[index], sortedNums[left], sortedNums[right]]);

                        while (left < right && sortedNums[left] == sortedNums[left + 1]) left++;
                        while (left < right && sortedNums[right] == sortedNums[right - 1]) right--;

                        left++;
                        right--;
                    }
                    else if (tempSum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }


            return result;
        }

        public static List<List<int>> ThreeSumV2(int[] nums)
        {

            var sortedInput = nums.Order();
            List<List<int>> result = [];

            for (int i = 0; i < nums.Length && nums[i] <= 0; i++)
            {
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    twoSum2(nums, i, result);
                }
            }

            return result;

        }

        private static void twoSum2(int[] nums, int i, List<List<int>> result)
        {
            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum < 0)
                {
                    ++left;
                }
                else if (sum > 0)
                {
                    --right;
                }
                else
                {
                    result.Add([nums[i], nums[left++], nums[right--]]);
                    while (left < right && nums[left] == nums[left - 1])
                    {
                        ++left;
                    }
                }
            }
        }
    }
}
