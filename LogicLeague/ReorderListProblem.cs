namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/reorder-list/
    /// </summary>
    internal class ReorderListProblem
    {
        public static void ReorderList(ListNode head)
        {
            ListNode slow = head, fast = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            //Reverse
            var current = slow;
            ListNode prev = null;
            while (current != null)
            {
                var next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            ListNode firstHead = head;
            ListNode secondHead = prev;
            while (secondHead.next != null)
            {
                var temp = firstHead.next;
                firstHead.next = secondHead;
                firstHead = temp;

                temp = secondHead.next;
                secondHead.next = firstHead;
                secondHead = temp;
            }
        }
    }
}
