namespace Algorithms.tbank_interview.Easy;

//https://leetcode.com/problems/remove-duplicates-from-sorted-list/

public static class RemoveDuplicatesfromSortedList
{
    public static ListNode RemoveDuplicatesfromSortedList_2Gen(ListNode? head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        if (head.val == head.next.val)
        {
            head.next = head.next.next;

            return RemoveDuplicatesfromSortedList_2Gen(head);
        }

        head.next = RemoveDuplicatesfromSortedList_2Gen(head.next);
        return head;
    }

    public static ListNode RemoveDuplicatesfromSortedList_3Gen(ListNode? head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        var current = head;
        var next = head.next;
        
        while (current != null && current.next != null)
        {
            next = current.next;
            if (next.val == current.val)
            {
                current.next = next.next;
            }
            else
            {
                current = current.next;
            }
        }

        return head;
    }

    public static void Test()
    {
    }
}