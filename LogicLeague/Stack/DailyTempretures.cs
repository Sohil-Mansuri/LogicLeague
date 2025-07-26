namespace LogicLeague.Stack
{
    /// <summary>
    /// https://leetcode.com/problems/daily-temperatures/
    /// </summary>
    internal class DailyTempretures
    {
        public static int[] DailyTemperatures(int[] temperatures)
        {
            if (temperatures.Length == 1) return [0];

            int[] result = new int[temperatures.Length];

            Stack<int> stack = [];

            for (int i = 0; i < temperatures.Length; i++)
            {
                while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
                {
                    var topIndex = stack.Pop();
                    result[topIndex] = i - topIndex;
                }

                stack.Push(i);
            }

            return result;
        }
    }
}
