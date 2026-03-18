namespace Algorithms.tbank_interview.Easy;
// https://leetcode.com/problems/middle-of-the-linked-list
public static class MiddleoftheLinkedList
{
    public static ListNode MiddleNode(ListNode head)
    {
        var current = head;
        var fast = head;
        while (fast != null && fast.next != null)
        {
            current = current.next;
            fast = fast.next.next;
        }

        return current;
    }
}