public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int lp = 0, rp = numbers.Length - 1;
        while(lp<= rp){
            if(numbers[lp] + numbers[rp] > target){
                rp--;
                continue;
            }
            if(numbers[lp] + numbers[rp] < target){
                lp++;
                continue;
            }
            return [lp+1,rp+1];
        }
        return [];
    }
}
