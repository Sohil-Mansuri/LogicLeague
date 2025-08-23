namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/merge-k-sorted-lists/
    /// </summary>
    internal class MergeKSortedLists
    {
        public static ListNode MergeKLists(ListNode[] lists)
        {
            var minHeap = new PriorityQueue<ListNode, int>();

            ListNode result = new();
            var dummy = result;

            for (int i = 0; i < lists.Length; i++)
            {
                var list = lists[i];

                while (list != null)
                {
                    minHeap.Enqueue(list, list.val);
                    list = list.next;
                }
            }

            while (minHeap.Count > 0)
            {
                dummy.next = new ListNode
                {
                    val = minHeap.Dequeue().val
                };

                dummy = dummy.next;
            }

            return result.next;
        }
    }
}
