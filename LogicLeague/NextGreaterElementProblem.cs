namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/next-greater-element-i/
    /// </summary>
    internal class NextGreaterElementProblem
    {
        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            Stack<int> stack = [];
            Dictionary<int, int> nextGreter = [];
            int[] result = new int[nums1.Length];

            foreach (var num in nums2)
            {
                while (stack.Count > 0 && num > stack.Peek())
                {
                    nextGreter[stack.Pop()] = num;
                }

                stack.Push(num);
            }

            while (stack.Count > 0)
            {
                nextGreter[stack.Pop()] = -1;
            }


            for (int i = 0; i < nums1.Length; i++)
            {
                result[i] = nextGreter[nums1[i]];
            }

            return result;
        }
    }

}
