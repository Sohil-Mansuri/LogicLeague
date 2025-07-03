namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/container-with-most-water
    /// </summary>
    internal class ContainerWaterProblem
    {
        public static int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;

            int maxArea = 0;
            while (left < right)
            {
                int tempArea = Math.Min(height[left], height[right]) * (right - left);
                maxArea = Math.Max(maxArea, tempArea);

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return maxArea;
        }
    }
}
