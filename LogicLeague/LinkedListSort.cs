

namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/sort-list/description/
    /// </summary>
    internal class LinkedListSort
    {
        public static ListNode SortList(ListNode head)
        {
            if (head?.next is not null)
                head = MergeSortList(head);

            return head;
        }

        private static ListNode MergeSortList(ListNode head)
        {
            if (head?.next == null) return head;

            var mid = FindMid(head);

            var left = head;
            var right = mid.next;
            mid.next = null;

            left = MergeSortList(left);
            right = MergeSortList(right);

            return MergeList(left, right);

        }

        public static ListNode MergeList(ListNode left, ListNode right)
        {
            ListNode dummy = new();
            var temp = dummy;

            while (left != null && right != null)
            {
                if (left.val < right.val)
                {
                    temp.next = left;
                    temp = left;
                    left = left.next;
                }
                else
                {
                    temp.next = right;
                    temp = right;
                    right = right.next;
                }
            }

            if (left != null) temp.next = left;
            else temp.next = right;

            return dummy.next;
        }

        public static ListNode FindMid(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }
    }
}
