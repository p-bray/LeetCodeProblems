using System.Collections;

public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        //create a new int[] array that is empty. then add the evens to  the array, rremoving them from the odd array. return th concatonated array. 
        List<int> evens = new List<int>();
        List<int> odds = new List<int>();
        // int[] evens = new int[]();

        for(int i = 0; i < nums.Count(); i++)
        {
            if(nums[i]%2 == 0)
            {
                evens.Add(nums[i]);
            }else
            {
                odds.Add(nums[i]);
            }
        }

        evens.AddRange(odds); 
        var sorted = evens.ToArray();
        return sorted;
    }
}