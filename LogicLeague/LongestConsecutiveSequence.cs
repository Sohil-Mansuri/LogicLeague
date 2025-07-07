namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/longest-consecutive-sequence/description/
    /// </summary>
    internal class LongestConsecutiveSequence
    {
        public static int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0) return 0;

            HashSet<int> elements = [];

            HashSet<int> visited = [];
            int curretMaxLenght;

            int maximumLenth = 1;

            foreach (int num in nums)
            {
                elements.Add(num);
            }

            for (int index = 0; index < nums.Length; index++)
            {
                if (visited.Contains(nums[index])) continue;
                else
                    visited.Add(nums[index]);
                if (elements.Contains(nums[index] - 1)) continue;
                else
                {
                    curretMaxLenght = 1;
                    int currentElement = nums[index];
                    int increment = 1;
                    while (elements.Contains(currentElement + increment))
                    {
                        curretMaxLenght++;
                        increment++;
                    }

                    maximumLenth = Math.Max(curretMaxLenght, maximumLenth);
                }
            }

            return maximumLenth;

        }
    }
}
