namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/remove-nth-node-from-end-of-list/
    /// </summary>
    internal class RemoveNthLastNode
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new()
            {
                next = head
            };

            ListNode back = dummy, front = dummy;
            for (int i = 0; i <= n; i++)
            {
                front = front.next;
            }

            while (front is not null)
            {
                front = front.next;
                back = back.next;
            }

            back.next = back?.next?.next;

            return dummy.next;
        }
    }
}
