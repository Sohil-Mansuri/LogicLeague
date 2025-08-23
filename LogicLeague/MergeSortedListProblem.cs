namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/merge-two-sorted-lists/
    /// </summary>
    internal class MergeSortedListProblem
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode result = new();
            ListNode dummy = result;

            while (list1 is not null && list2 is not null)
            {
                if (list1.val < list2.val)
                {
                    dummy.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    dummy.next = list2;
                    list2 = list2.next;
                }

                dummy = dummy.next;
            }

            if (list1 is not null)
                dummy.next = list1;

            if (list2 is not null)
                dummy.next = list2;

            return result.next;
        }
    }
}
