public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] indices = new int[2] {1,2};
        Dictionary<int[], int> dict = new Dictionary<int[], int>();

        //Brute force for the indices that work    
        for(int x = 0; x < nums.Count(); x++){
            for(int y = 0; y < nums.Count(); y++){
                if(y != x){
                    if(nums[x] + nums[y] == target){
                        // dict.Add([x,y], x+y);
                    }
                }
            }
        }

        Find the smallest index size
        int indexSize = 10000;

        foreach(KeyValuePair<int[], int> kvp in dict){
            if(kvp.Value < indexSize){
                indexSize = kvp.Value;
            }else{
                // dict.Remove(kvp.Key);
            }
        }

        indices = dict[dict.Keys[0]];

        return indices;
    }
}
