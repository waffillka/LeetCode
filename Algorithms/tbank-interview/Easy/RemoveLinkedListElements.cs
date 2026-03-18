namespace Algorithms.tbank_interview.Easy;

public static class RemoveLinkedListElements
{
    private static ListNode RemoveElements(ListNode head, int val)
    {
        var dummy = new ListNode(-1, head);
        var current = dummy;
        var prev = head;

        while (current != null)
        {
            if (current.val == val)
            {
                prev.next = current.next;
            }
            else
            {
                prev = current;
            }

            current = current.next;
        }

        return dummy.next;
    }

    public static void Test()
    {
        var result = RemoveElements(new ListNode()
        {
            val = 7,
            next = new ListNode()
            {
                val = 7,
                next = new ListNode()
                {
                    val = 7,
                    next = new ListNode()
                    {
                        val = 7,
                        next = new ListNode(7)
                    }
                }
            }
        }, 7);
        Console.WriteLine(result);
    }
}