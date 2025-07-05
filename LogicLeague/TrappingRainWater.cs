namespace LogicLeague
{
    internal class TrappingRainWater
    {
        public static int Trap(int[] height)
        {
            int left = 0; int right = height.Length - 1;

            int leftMax = height[left];
            int rightMax = height[right];
            int totalWater = 0;
            while (left < right)
            {
                if (height[left] < height[right])
                {
                    leftMax = Math.Max(leftMax, height[left]);

                    int diff = leftMax - height[left];
                    if (diff > 0) totalWater += diff;

                    left++;
                }
                else
                {
                    rightMax = Math.Max(rightMax, height[right]);

                    int diff = rightMax - height[right];

                    if (diff > 0) totalWater += diff;

                    right--;
                }
            }

            return totalWater;
        }
    }
}
