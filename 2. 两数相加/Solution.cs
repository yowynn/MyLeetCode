using System;
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

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

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode r = new ListNode();
        ListNode l = r;
        int c = 0;
        do
        {
            if (l1 != null)
            {
                c += l1.val;
                l1 = l1.next;
             }
            if (l2 != null)
            {
                c += l2.val;
                l2 = l2.next;
            }
            l.val = c % 10;
            c /= 10;
            if (l1 == null && l2 == null && c == 0)
                return r;
            l.next = new ListNode();
            l = l.next;
        }
        while (true);
    }

    public static void Main()
    {
        ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        new Solution().AddTwoNumbers(l1, l2);
    }
}
