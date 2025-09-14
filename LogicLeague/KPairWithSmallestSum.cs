namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/find-k-pairs-with-smallest-sums/
    /// </summary>
    internal class KPairWithSmallestSum
    {
        public static IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
        {
            var minHeap = new PriorityQueue<(int sum, int i, int j), int>();
            IList<IList<int>> result = [];

            for (int i = 0; i < Math.Min(nums1.Length, k); i++)
            {
                var sum = nums1[i] + nums2[0];
                minHeap.Enqueue((sum, i, 0), sum);
            }


            while (k > 0 && minHeap.Count > 0)
            {
                var (_, i, j) = minHeap.Dequeue();
                result.Add([nums1[i], nums2[j]]);
                k--;

                if (j + 1 < nums2.Length)
                {
                    j++;
                    int sum = nums1[i] + nums2[j];
                    minHeap.Enqueue((sum, i, j), sum);
                }
            }

            return result;

        }
    }
}
