namespace Algorithms.tbank_interview.Easy;

public static class ReverseLinkedList
{
    private static ListNode ReverseList(ListNode head)
    {
        if (head == null)
        {
            return null;
        }

        var current = head;
        ListNode next = null;
        while (current.next != null)
        {
            next = current.next;
            current.next = next.next;
            next.next = head;
            head = next;
        }

        return head;
    }

    public static void Test()
    {
        var result = ReverseList(new ListNode()
        {
            val = 1,
            next = new ListNode()
            {
                val = 2,
                next = new ListNode()
                {
                    val = 3,
                    next = new ListNode()
                    {
                        val = 4,
                        next = new ListNode(7)
                    }
                }
            }
        });
        Console.WriteLine(result);
    }
}