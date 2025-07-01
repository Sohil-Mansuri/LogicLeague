namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/
    /// </summary>
    internal class TwoSumPart2
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            if (numbers.Length == 1 && numbers[0] == target)
            {
                return [1];
            }

            int left = 0;
            int right = numbers.Length - 1;
            int tempSum;
            while (left < right)
            {
                tempSum = numbers[left] + numbers[right];
                if (tempSum == target)
                    return [left + 1, right + 1];

                if (tempSum > target) right--;
                else left++;
            }


            return [];
        }
    }
}
