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
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        
        ListNode current = new ListNode();
        
        current.val = list1.val;
        current.next = list1.next;
        // next1.val = current.val;
        // next1.next = current.next;
        // ListNode next1 = current.next;
        while(current != null)
        {
            Console.WriteLine(current.val);
            // current = next1;
            // next1 = current.next;
        }
        // Console.WriteLine(list1.val);\
        return current;
    }
}