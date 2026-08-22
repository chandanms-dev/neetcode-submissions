public class Solution {
    public int MajorityElement(int[] nums) {
        int sol  = -1;
        int count = 0;
        for(int i = 0; i < nums.Length; i++){
            if(count == 0){
                sol = nums[i];
                count++;
            } else {
                if(nums[i] == sol) {
                    count++;
                } else {
                    count--;
                }
            }
        }
        return sol;
    }
}