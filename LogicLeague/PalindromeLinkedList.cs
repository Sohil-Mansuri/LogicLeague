namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-linked-list/description/
    /// </summary>
    internal class PalindromeLinkedList
    {
        public static bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null) return true;

            var current = head;

            Stack<int> stack = [];
            while (current != null)
            {
                stack.Push(current.val);
                current = current.next;
            }

            current = head;

            while (current != null)
            {
                var element = stack.Pop();

                if (element != current.val) return false;
                current = current.next;
            }

            return stack.Count == 0;
        }

        public static bool IsPalindromeV2(ListNode head)
        {
            if (head == null || head.next == null) return true;

            ListNode slow = head;
            ListNode fast = head;

            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            var otherHalfHead = Reverse(slow.next);

            ListNode firstHead = head;
            ListNode secondHead = otherHalfHead;

            while (secondHead != null)
            {
                if (firstHead.val != secondHead.val)
                {
                    Reverse(otherHalfHead);
                    return false;
                }

                secondHead = secondHead.next;
                firstHead = firstHead.next;
            }


            Reverse(otherHalfHead);
            return true;
        }

        private static ListNode Reverse(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;

            while (current != null)
            {
                var nextNode = current.next;
                current.next = prev;
                prev = current;
                current = nextNode;
            }

            return prev!;
        }
    }


    public class ListNode
    {
        public int val;

        public ListNode next;

        public ListNode()
        {
            
        }

        public static ListNode CreateList(int[] elements)
        {
            ListNode head = new() { val = elements[0] };
            ListNode current = head;

            for (int i = 1; i < elements.Length; i++)
            {
                current.next = new ListNode { val = elements[i] };
                current = current.next;
            }

            return head;
        }


        public static ListNode Reverse(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;

            while (current != null)
            {
                var nextNode = current.next;
                current.next = prev;
                prev = current;
                current = nextNode;
            }

            return prev!;
        }

        public static ListNode ReverseV2(ListNode head)
        {
            if (head == null || head.next == null) return head;


            var reverNewHead = ReverseV2(head.next);
            head.next.next = head;
            head.next = null;

            return reverNewHead;
        }
    }

}
