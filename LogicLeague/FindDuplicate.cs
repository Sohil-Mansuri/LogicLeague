namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/contains-duplicate/
    /// </summary>
    internal class FindDuplicate
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> elements = [];

            foreach (var num in nums)
            {
                if (elements.Contains(num))
                    return true;

                elements.Add(num);
            }
           
            return false;
        }
    }
}
