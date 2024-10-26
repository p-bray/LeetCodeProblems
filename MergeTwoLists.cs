//https://leetcode.com/problems/merge-two-sorted-lists/description/








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

//dude idk. Too tired to think on this rn. 



public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        
        ListNode index1 = list1;
        ListNode index2 = list2;
        ListNode returnList = new ListNode();
        
        // while(index1 != null)
        // {
        //     ListNode current = index1;
        //     ListNode next = index1.next;
        //     while(index2 != null)
        //     {
        //         if(current.val <= compare.val)
        //         {
        //             previous.next = compare;
        //         }else
        //     }
        // }

        //just append the list2 to list1
        while(index1 != null)
        {
            Console.WriteLine(index1.val);
            if(index1.next is null)
            {
                index1.next = index2;
                break;
            }else
            {
                index1 = index1.next;
            }
        }

        while(index1 != null)
        {
            ListNode next1 = index1.next;
            while(next1 != null)
            {
                if(next1.val >= index1.val)
                {
                    next1 = next1.next;
                }else
                {   
                    index1.next = next1.next;
                    next1.next = index1;
                }
            }
            index1 = index1.next;
        }


        //idea: loop through list1. Check it agains each element of list2. if the current1 is less than current2
        // while(current1 != null)
        // {
        //     while(current2 != null)
        //     {
        //         Console.WriteLine(current2.val);
        //         current2 = current2.next;
        //     }
        //     Console.WriteLine(current1.val);
        //     current1 = current1.next;
        // }

        return list1;
    }
}