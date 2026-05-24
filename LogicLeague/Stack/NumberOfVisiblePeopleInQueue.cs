namespace LogicLeague.Stack
{
    public class NumberOfVisiblePeopleInQueue
    {
        /// <summary>
        /// https://leetcode.com/problems/number-of-visible-people-in-a-queue/description/
        /// </summary>
        /// <param name="heights"></param>
        /// <returns></returns>
        public static int[] CanSeePersonsCount(int[] heights)
        {
            int length = heights.Length;
            Stack<int> stack = [];

            int[] result = new int[length];

            for (int i = length - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && stack.Peek() < heights[i])
                {
                    stack.Pop();
                    result[i]++;
                }

                if (stack.Count > 0)
                {
                    result[i]++;
                }

                stack.Push(heights[i]);
            }

            return result;
        }
    }
}
