namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-linked-list-ii/description/
    /// </summary>
    internal class ReverseLinkedList2
    {
        public static ListNode ReverseBetween(ListNode head, int left, int right)
        {
            if (head == null || left == right) return head;

            ListNode dummy = new()
            {
                next = head
            };

            ListNode prev = dummy;
            for (int i = 1; i < left; i++)
            {
                prev = prev.next;
            }

            ListNode current = prev.next;
            ListNode revePrev = null;

            for (int i = left; i <= right; i++)
            {
                var next = current.next;
                current.next = revePrev;
                revePrev = current;
                current = next;
            }

            prev.next.next = current;
            prev.next = revePrev;

            return dummy.next;
        }
    }
}
