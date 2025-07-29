namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/majority-element/
    /// </summary>
    internal class MajorityElementProblem
    {
        public static int MajorityElement(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            Dictionary<int, int> map = [];

            for (int index = 0; index < nums.Length; index++)
            {
                if (map.ContainsKey(nums[index])) map[nums[index]]++;
                else
                {
                    map[nums[index]] = 1;
                }
            }

            KeyValuePair<int, int> tuple = new KeyValuePair<int, int>(10, -1);
            foreach (var current in map)
            {
                if (tuple.Value < current.Value)
                {
                    tuple = current;
                }
            }

            return map.Aggregate((a, b) => a.Value > b.Value ? a : b).Key;
            //return tuple.Key;
        }
    }
}
