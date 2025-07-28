namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/largest-number/
    /// </summary>
    internal class LargetNumber
    {
        public static string LargestNumber(int[] nums)
        {
            if (nums.All(x => x == 0)) return "0";

            var stringNums = nums.Select(x => x.ToString()).ToArray();
            Array.Sort(stringNums, (a, b) =>
            {
                return (b + a).CompareTo(a + b);
            });


            return string.Concat(stringNums);
        }
    }

    public class CompareWithConcatination : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            double first = Convert.ToDouble(string.Concat($"{x}", $"{y}"));
            double second = Convert.ToDouble(string.Concat($"{y}", $"{x}"));

            return second.CompareTo(first);
        }
    }
}
