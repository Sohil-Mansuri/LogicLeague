namespace LogicLeague
{
    internal class FirstAndLastPosition
    {
        public static int[] SearchRange(int[] nums, int target)
        {
            var firstIndex = AdvanceBinarySearch(nums, target, true);

            if (firstIndex == -1) return [-1, -1];

            var lastIndex = AdvanceBinarySearch(nums, target, false);

            return [firstIndex, lastIndex];
        }


        private static int AdvanceBinarySearch(int[] nums, int target, bool isFirstPart)
        {
            int startIndex = 0; int endIndex = nums.Length - 1;

            while (startIndex <= endIndex)
            {
                int middleIndex = (startIndex + endIndex) / 2;

                if (nums[middleIndex] == target)
                {
                    if (isFirstPart)
                    {
                        if (middleIndex == startIndex || nums[middleIndex - 1] != target)
                            return middleIndex;
                        endIndex = middleIndex - 1;
                    }
                    else
                    {
                        if (middleIndex == endIndex || nums[middleIndex + 1] != target)
                            return middleIndex;

                        startIndex = middleIndex + 1;
                    }
                }
                else if (nums[middleIndex] < target)
                {
                    startIndex = middleIndex + 1;
                }
                else
                {
                    endIndex = middleIndex - 1;
                }
            }
            return -1;
        }
    }
}
