namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/next-permutation/
    /// </summary>
    internal class NexuPermutation
    {
        public static int[] NextPermutation(int[] nums)
        {
            int rightIndex;
            for (rightIndex = nums.Length - 1; rightIndex > 0; rightIndex--)
            {
                if (nums[rightIndex] < nums[rightIndex - 1]) continue;

                var minValue = nums[rightIndex - 1];

                bool shouldBreak = false;
                for (int j = nums.Length - 1; j >= rightIndex; j--)
                {
                    if (nums[j] > minValue)
                    {
                        (nums[rightIndex - 1], nums[j]) = (nums[j], minValue);

                        shouldBreak = true;
                        break;
                    }
                }

                if (shouldBreak) break;
            }

            
            int lastIndex = nums.Length - 1;
            while(rightIndex < lastIndex)
            {
                (nums[rightIndex], nums[lastIndex]) = (nums[lastIndex--], nums[rightIndex++]);
            }

            return nums;
        }


    }
}
