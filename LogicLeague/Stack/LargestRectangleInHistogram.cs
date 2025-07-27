namespace LogicLeague.Stack
{
    /// <summary>
    /// https://leetcode.com/problems/largest-rectangle-in-histogram/
    /// </summary>
    internal class LargestRectangleInHistogram
    {
        public static int LargestRectangleArea(int[] heights)
        {
            Stack<int> stack = [];

            int maxArea = 0;

            int rightMin;
            int leftMin;

            for (int index = 0; index < heights.Length; index++)
            {
                while (stack.Count > 0 && heights[stack.Peek()] > heights[index])
                {
                    var currentHeightIndex = stack.Pop();
                    leftMin = stack.Count == 0 ? -1 : stack.Peek();
                    rightMin = index;
                    int area = heights[currentHeightIndex] * (rightMin - leftMin - 1);

                    maxArea = Math.Max(maxArea, area);
                }
                 
                stack.Push(index);
            }

            while (stack.Count > 0)
            {
                var currentHeightIndex = stack.Pop();
                rightMin = heights.Length;
                leftMin = stack.Count == 0 ? -1 : stack.Peek();

                int area = heights[currentHeightIndex] * (rightMin - leftMin - 1);

                maxArea = Math.Max(maxArea, area);

            }

            return maxArea;
        }
    }
}
