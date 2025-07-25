namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/middle-of-the-linked-list/
    /// </summary>
    internal class MiddleOfLinkedList
    {
        public static ListNode MiddleNode(ListNode head)
        {
            var slow = head;
            var fast = head;

            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }
    }
}
