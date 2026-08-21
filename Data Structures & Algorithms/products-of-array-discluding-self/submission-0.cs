public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] sol = new int[nums.Length];
        Array.Fill(sol,1);
        int prod = 1;
        for(int i = 0; i < nums.Length; i++){
            sol[i] = prod;
            prod = prod * nums[i];
        }
        prod = 1;
        for(int j = nums.Length - 1; j >= 0; j--){
            sol[j] = sol[j] * prod;
            prod = prod * nums[j]; 
        }
        return sol;
    }
}
