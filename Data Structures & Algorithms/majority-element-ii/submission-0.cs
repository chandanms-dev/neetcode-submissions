public class Solution {
    public List<int> MajorityElement(int[] nums) {
        Dictionary<int,int> hm = new Dictionary<int,int>();
        List<int> sol = new List<int>();
        int th = nums.Length/3;
        for(int i = 0; i < nums.Length;i++){
            if(hm.ContainsKey(nums[i])){
                hm[nums[i]]++;
            } else {
                hm[nums[i]] = 1;
            }
            if(hm.Count > 2){
                foreach(var ky in hm.Keys.ToList()){
                    hm[ky]--;
                    if(hm[ky] == 0) hm.Remove(ky);
                }
            }
        }
        
        foreach(var ky in hm.Keys.ToList()){
            hm[ky] = 0;
        }

        foreach(var a in nums){
           if(hm.ContainsKey(a)){
            hm[a]++;
           }
        }
        foreach(var ky in hm.Keys.ToList()){
            if(hm[ky] > th) {
                sol.Add(ky);
            }
        }

        
        return sol;
    }
}