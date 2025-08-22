namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/partition-labels/
    /// </summary>
    internal class PartitionLabelsProblem
    {
        public static IList<int> PartitionLabels(string s)
        {
            if (s.Length == 1) return [1];

            IList<int> result = [];
            //we can use array also of size 26 letters
            Dictionary<char, int> lastIndexMap = [];

            for (int i = 0; i < s.Length; i++)
            {
                lastIndexMap[s[i]] = i;
            }

            int partitionLastIndex = 0, partitionStart = 0;

            for (int i = 0; i < s.Length; i++)
            {
                partitionLastIndex = Math.Max(partitionLastIndex, lastIndexMap[s[i]]);

                if (i == partitionLastIndex)
                {
                    result.Add(partitionLastIndex - partitionStart + 1);
                    partitionStart = i + 1;
                }
            }

            return result;
        }
    }
}