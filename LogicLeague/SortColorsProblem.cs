namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/sort-colors/https://leetcode.com/problems/sort-colors/
    /// </summary>
    internal class SortColorsProblem
    {
        public static int[] SortColors(int[] nums)
        {
            int low = 0;
            int currnet = 0;
            int high = nums.Length - 1;

            while (currnet <= high)
            {
                if (nums[currnet] == 0)
                {
                    (nums[low], nums[currnet]) = (nums[currnet], nums[low]);
                    low++;
                    currnet++;
                }
                else if (nums[currnet] == 2)
                {
                    (nums[high], nums[currnet]) = (nums[currnet], nums[high]);
                    high--;
                }
                else
                {
                    currnet++;
                }
            }

            return nums;
        }


    }
}
