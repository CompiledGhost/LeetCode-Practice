namespace LeetCode.Problems.Easy;

public static class MiddleOfTheLinkedList
{
    public static ListNode Run(ListNode head)
    {
        // First Solution - "Count then Walk"
        // var count = 0;
        // var current = head;
        // while (current != null)
        // {
        //     count++;
        //     current = current.Next;
        // }
        //
        // var middle = count / 2;
        // current = head;
        // for (var i = 0; i < middle; i++)
        //     current = current.Next;
        //
        // return current;

        // Second Solution - Two Pointer
        var slow = head;
        var fast = head;

        while (fast is { Next: not null })
        {
            slow = slow.Next;
            fast = fast.Next.Next;
        }
        
        return slow;
    }
    
    public static ListNode Head => new(1,
        new ListNode(2,
            new ListNode(3,
                new ListNode(4,
                        new ListNode(5,
                            new ListNode(6))))));
}

public class ListNode(int val = 0, ListNode next = null!)
{
     public readonly int Val = val;
     public readonly ListNode Next = next;
}