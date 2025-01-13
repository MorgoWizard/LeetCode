namespace LeetCode.Problems.Problem876;

public class Problem876MiddleOfTheLinkedList
{
    public ListNode MiddleNode(ListNode head) {
        ListNode slowIndex = head, fastIndex = head;
        while (fastIndex is { next: not null })
        {
            slowIndex = slowIndex.next;
            fastIndex = fastIndex.next.next;
        }
        return slowIndex;
    }
}