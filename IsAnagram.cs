public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> dictS = new Dictionary<char, int>();
        Dictionary<char, int> dictT = new Dictionary<char, int>();

        char[] sS = s.ToCharArray();
        char[] sT = t.ToCharArray();

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
                if(dictS.ContainsKey(c) && dictT.ContainsKey(c)){
                    if(dictS[c] != dictT[c]){   
                        valid = false;
                        break;
                    }
                }else{
                    valid = false;
                    break;
                }
            }
        }else{
            valid = false;
        }

        return valid;
    }
}
