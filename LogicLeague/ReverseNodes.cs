namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-nodes-in-k-group/description/
    /// </summary>
    internal class ReverseNodes
    {
        public static ListNode ReverseKGroup(ListNode head, int k)
        {
            ListNode pointer = head;
            ListNode ktail = null;
            ListNode newHead = null;
            while (pointer != null)
            {
                int counter = 0;

                while (counter < k && pointer != null)
                {
                    pointer = pointer.next;
                    counter++;
                }

                if (counter == k)
                {
                    var revHead = ReverseList(head, k);

                    if (newHead == null) newHead = revHead;

                    if (ktail != null)
                        ktail.next = revHead;

                    ktail = head;
                    head = pointer;
                }
            }

            if (ktail != null)
                ktail.next = head;


            return newHead == null ? head : newHead;
        }


        private static ListNode ReverseList(ListNode head, int k)
        {
            ListNode previous = null;
            ListNode current = head;

            while (k > 0)
            {
                ListNode temp = current.next;
                current.next = previous;
                previous = current;
                current = temp;

                k--;
            }

            return previous;
        }
    }
}
