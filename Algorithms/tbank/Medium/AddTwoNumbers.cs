namespace Algorithms.Medium;

public static class AddTwoNumbers
{
    public static ListNode AddTwoNumbersTask1(ListNode? l1, ListNode l2)
    {
        int carry = 0;
        int result = 0;
        ListNode head = new ListNode();
        ListNode current = head;

        while (l1 != null || l2 != null)
        {
            result = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + carry;
            carry = result / 10;
            result = (result >= 10) ? result % 10 : result;
            current.next = new ListNode(result);
            current = current.next;
            l1 = l1?.next;
            l2 = l2?.next;
        }

        if (carry != 0)
        {
            current.next = new ListNode(carry);
        }

        return head.next;
    }

    public static ListNode AddTwoNumbersTask(ListNode? l1, ListNode l2)
    {
        var val1 = l1.val;
        var val2 = l2.val;
        var sum = val1 + val2;
        var add = (int)sum / 10;
        var result = new ListNode(sum > 9 ? sum % 10 : sum);
        var current = result;


        while (l1.next != null || l2.next != null)
        {
            if (l1.next != null)
            {
                l1 = l1.next;
                val1 = l1.val;
            }
            else
            {
                val1 = 0;
            }

            if (l2.next != null)
            {
                l2 = l2.next;
                val2 = l2.val;
            }
            else
            {
                val2 = 0;
            }

            sum = val1 + val2 + add;
            add = (int)sum / 10;


            current.next = new ListNode(sum > 9 ? sum % 10 : sum);
            current = current.next;
        }

        if (add > 0)
        {
            current.next = new ListNode(add);
        }

        return result;
    }
}