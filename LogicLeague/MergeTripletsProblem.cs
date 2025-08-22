namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/merge-triplets-to-form-target-triplet/description/
    /// </summary>
    internal class MergeTripletsProblem
    {
        public static bool MergeTriplets(int[][] triplets, int[] target)
        {
            int[] max = new int[3];

            foreach (var triplet in triplets)
            {
                if (triplet[0] <= target[0] && triplet[1] <= target[1] && triplet[2] <= target[2])
                {
                    max[0] = Math.Max(max[0], triplet[0]);
                    max[1] = Math.Max(max[1], triplet[1]);
                    max[2] = Math.Max(max[2], triplet[2]);
                }
            }

            return max[0] == target[0] && max[1] == target[1] && max[2] == target[2];
        }
    }
}
