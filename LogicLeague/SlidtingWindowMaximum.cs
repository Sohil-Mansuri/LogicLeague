namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/sliding-window-maximum/
    /// </summary>
    public class SlidtingWindowMaximum
    {
        public static int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (nums.Length == 1) return nums;

            List<int> result = [];

            LinkedList<int> deque = [];

            for (int i = 0; i < nums.Length; i++)
            {
                if (deque.Count > 0 && deque.First.Value <= i - k)
                    deque.RemoveFirst();

                while (deque.Count > 0 && nums[deque.Last.Value] < nums[i])
                    deque.RemoveLast();

                deque.AddLast(i);

                if (i >= k - 1)
                    result.Add(nums[deque.First.Value]);
            }


            return [.. result];
        }
    }
}
