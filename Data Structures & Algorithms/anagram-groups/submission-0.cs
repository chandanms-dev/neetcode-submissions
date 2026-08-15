public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> sol = new List<List<string>>();
        Dictionary<string,int> hm = new Dictionary<string,int>();
        foreach(var i in strs){
        int[] k = new int[26];
        StringBuilder kb = new StringBuilder();
        foreach(var  j in i){
            k[j - 'a']++;
        }
        foreach(int m in k){
            kb.Append(m+"#");
        }
        string lup = kb.ToString();
        if(hm.ContainsKey(lup)){
            sol[hm[lup]].Add(i);
        } else {
            List<string> a = new List<string>();
            a.Add(i);
            sol.Add(a);
            hm[lup] = sol.Count - 1;
        }
        }
        return sol;
    }
}
