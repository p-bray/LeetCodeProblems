public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int[] placeholder = new int[nums.Count()];
        //loop through, checking each place in nums against 
        int currentVal = 0;
        int phIndex = 0;
        for(int i = 0;  i < nums.Count(); i++)
        {
            if(currentVal != nums[i])
            {
                Console.WriteLine("in Loop");
                Console.WriteLine(currentVal);
                Console.WriteLine(placeholder[phIndex]);
                currentVal = nums[i];
                placeholder[phIndex] = currentVal;
                phIndex ++;
                Console.WriteLine(currentVal);
                Console.WriteLine(placeholder[phIndex]);
            }else
            {
                Console.WriteLine("found dupe");
            }
        }
        nums = placeholder;
        return phIndex + 1;
    }
}