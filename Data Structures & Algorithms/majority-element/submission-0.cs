public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> hm = new Dictionary<int,int>();
        int majorityElement = nums[0], majorityfreq = 0;
        for(int i = 0; i < nums.Length;i++){
            if(!hm.ContainsKey(nums[i])) hm[nums[i]] = 1;
            hm[nums[i]]++;
            if(hm[nums[i]] > majorityfreq ){
                majorityElement = nums[i];
                majorityfreq= hm[nums[i]];
            }
        }
        return majorityElement;
    }
}