namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    /// </summary>
    internal class RemoveDuplicatesProblem
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int currentIndex = 0;

            int nextIndex = currentIndex + 1;

            while (nextIndex < nums.Length)
            {
                if (nums[currentIndex] == nums[nextIndex])
                {
                    while (nextIndex < nums.Length && nums[currentIndex] == nums[nextIndex])
                    {
                        nextIndex++;
                    }

                    if (nextIndex < nums.Length)
                    {
                        nums[currentIndex + 1] = nums[nextIndex];
                        currentIndex++;
                    }
                }
                else
                {
                    nextIndex++;
                    currentIndex++;
                }

            }

            return currentIndex + 1;
        }


        // better solution
        public static int RemoveDuplicatesV2(int[] nums)
        {
            int currentIndex = 1;

            for (int index = 1; index < nums.Length; index++)
            {
                if (nums[index] != nums[index - 1])
                {
                    nums[currentIndex] = nums[index];
                    currentIndex++;
                }
            }

            return currentIndex;
        }
    }
}
