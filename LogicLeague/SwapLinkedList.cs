namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/swap-nodes-in-pairs/description/
    /// </summary>
    internal class SwapLinkedList
    {
        public static ListNode SwapPairs(ListNode head)
        {

            ListNode dummy = new()
            {
                next = head
            };

            var prev = dummy;

            while (prev.next?.next != null)
            {
                var first = prev.next;
                var second = prev.next.next;

                first.next = second.next;
                second.next = first;
                prev.next = second;

                prev = first;
            }


            return dummy.next;
        }
    }
}
