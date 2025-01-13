namespace LeetCode.Problems.Problem876;

public class ListNode {
     public int val;
     public ListNode? next;
     public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
     }

     public ListNode(int[] nums)
     {
         if (nums == null || nums.Length == 0)
         {
             throw new ArgumentException("Array must not be null or empty.");
         }

         val = nums[0];
         ListNode currentNode = this;

         for (int i = 1; i < nums.Length; i++)
         {
             currentNode.next = new ListNode(nums[i]);
             currentNode = currentNode.next;
         }
     }

     public int[] ReturnAllValues()
     {
         List<int> values = new();
         ListNode current = this;

         while (current.next != null)
         {
             values.Add(current.val);
             current = current.next;
         }
         
         values.Add(current.val);

         return values.ToArray();
     }
}