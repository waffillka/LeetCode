namespace Algorithms;

public class DeleteDuplicates
{
    public static ListNode DeleteDuplicatesTask(ListNode head)
    {
        HashSet<int> set = new HashSet<int>();

        if (head == null)
        {
            return head;
        }

        set.Add(head.val);
        ListNode current = head;
        ListNode next = head.next;

        while (current.next != null)
        {
             next = current.next;
            if (set.Contains(next.val))
            {
                current.next = next.next;
            }
            else
            {
                set.Add(next.val);
                current = current.next;
            }
        }

        return head;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}