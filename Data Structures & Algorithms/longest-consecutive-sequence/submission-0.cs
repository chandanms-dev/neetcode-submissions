public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> sol  = new HashSet<int>();
        int ans = 0;
        for(int i = 0; i < nums.Length; i++){
            sol.Add(nums[i]);
        }

        for(int i = 0; i < nums.Length; i++){
            int len = 0;
            int el = nums[i];
            if(!sol.Contains(nums[i] -1)){
                while(sol.Contains(el)){
                    len++;
                    el++;
                }
            }
            if(len > ans) ans = len;
        }
        return ans;
    }
}
