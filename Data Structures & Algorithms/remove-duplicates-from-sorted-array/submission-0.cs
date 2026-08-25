public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int uq = 0, luq = nums[0], li = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == luq){
                li++;
            } else {
                uq++;
                nums[uq] = nums[i];
                luq = nums[i];
            }
        }
        return uq+1;
    }
}