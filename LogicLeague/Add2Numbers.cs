namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/add-two-numbers/
    /// </summary>
    internal class Add2Numbers
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var list1 = l1;
            var list2 = l2;

            var result = new ListNode();
            var temp = result;

            int carry = 0;
            while (list1 is not null || list2 is not null)
            {
                int sum = carry;

                if (list1 is not null)
                {
                    sum += list1.val;
                    list1 = list1.next;
                }

                if (list2 is not null)
                {
                    sum += list2.val;
                    list2 = list2.next;
                }

                carry = sum / 10;
                sum = sum % 10;

                var newNode = new ListNode
                {
                    val = sum
                };

                temp.next = newNode;
                temp = temp.next;
            }

            if (carry == 1)
            {
                temp.next = new ListNode
                {
                    val = carry
                };
            }

            return result.next;
        }

        public static ListNode ReverseList(ListNode head)
        {
            ListNode current = head;
            ListNode prev = null;

            while (current != null)
            {
                var nextNode = current.next;
                current.next = prev;
                prev = current;
                current = nextNode;
            }

            return prev;
        }
    }
}
