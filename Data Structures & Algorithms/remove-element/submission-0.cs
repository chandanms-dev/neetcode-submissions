public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int wp = 0;
        for(int i = 0; i < nums.Length;i++){
            if(nums[i] != val){
                nums[wp] = nums[i];
                wp++;
            }
        }
        return wp;
    }
}