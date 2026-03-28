namespace Algorithms.tbank_interview.Real_T;

//https://leetcode.com/problems/add-two-numbers/
public static class AddTwoNumbers
{
    private static ListNode AddTwoNumbers_gen(ListNode l1, ListNode l2)
    {
        var head = new ListNode(0);
        var current = head;
        var temp = 0;
        while (l1 != null || l2 != null)
        {
            if (l1 != null && l2 != null)
            {
                temp = l1.val + l2.val + temp;
                l1 = l1.next;
                l2 = l2.next;
            }
            else if (l1 != null)
            {
                temp = l1.val + temp;
                l1 = l1.next;
            }
            else
            {
                temp = l2.val + temp;
                l2 = l2.next;
            }

            if (temp > 9)
            {
                temp %= 10;
                current.next = new ListNode(temp);
                temp = 1;
            }
            else
            {
                current.next = new ListNode(temp);
                temp = 0;
            }

            current = current.next;
        }

        if (temp > 0)
        {
            current.next = new ListNode(temp);
        }

        return head.next;
    }

    public static void Test()
    {
        var result = AddTwoNumbers_gen(new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))))),
            new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))))));
        Console.WriteLine(result);
    }
}