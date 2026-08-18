public class Solution {
    public void SortColors(int[] nums) {
        int l = 0,  r = nums.Length - 1;
        int scan = 0;
        while(scan <= r){
            if(nums[scan] == 0){
                int tmp = nums[l];
                nums[l] = nums[scan];
                nums[scan] = tmp;
                scan++;
                l++;
            }
            else if(nums[scan] == 2){
                int tmp = nums[r];
                nums[r] = nums[scan];
                nums[scan] = tmp;
                r--;
            } 
            else{
                scan++;
            }
        }
    }
}