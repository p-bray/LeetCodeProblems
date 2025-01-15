public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        bool dupe = false;
        foreach(int i in nums){
            if(!dict.ContainsKey(i)){
                dict.Add(i, 1);
            }else{
                dupe = true;
                break;
            }
        }
        return dupe;
    }
}
public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<string, int> dictS = new Dictionary<string, int>();
        Dictionary<string, int> dictT = new Dictionary<string, int>();

        string[] sS = s.ToArray();
        string[] sT = t.ToArray();

        bool valid = true;

        foreach(char c in sS){
            if(dictS.ContainsKey(c)){
                dictS[c]++;
            }else{
                dictS.Add(c, 1);
            }
        }        

        
        foreach(char c in sT){
            if(dictT.ContainsKey(c)){
                dictT[c]++;
            }else{
                dictT.Add(c, 1);
            }
        }    

        if(dictS.Count() == dictT.Count()){
            foreach(char c in sS){
                if(dictS[c] != dictT[c])
                    valid = false;
            }
        }

        return valid;
    }
}