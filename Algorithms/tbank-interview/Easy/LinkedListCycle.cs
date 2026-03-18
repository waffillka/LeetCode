namespace Algorithms.tbank_interview.Easy;
//https://leetcode.com/problems/linked-list-cycle/
public static class LinkedListCycle
{
    public static bool HasCycle(ListNode head)
    {
        if (head == null)
            return false;

        var current = head;
        var set = new HashSet<ListNode>();
        while (current != null)
        {
            if (!set.Add(current))
            {
                return true;
            }

            current = current.next;
        }

        return false;
    }
}