public class Solution {
    public int[] SortArray(int[] nums) {
        MergeSort(nums,0,nums.Length - 1);
        return nums;
    }
    public void MergeSort(int[] nums,int lp, int rp){
        if(lp >= rp) return;
        int[] trr = new int[rp - lp + 1];
        int mp = lp + (rp - lp)/2;
        MergeSort(nums,lp,mp);
        MergeSort(nums,mp+1,rp);
        int li = lp, ri = mp + 1, k = 0;
        while(li <= mp && ri <= rp){
                if(nums[li] < nums[ri]){
                trr[k] = nums[li];
                k++;
                li++;
            } else {
                trr[k] = nums[ri];
                k++;
                ri++;
            }
            };
            while(li <= mp){
                    trr[k] = nums[li];
                    k++;
                    li++;
            };
        while(ri <= rp){
                    trr[k] = nums[ri];
                    k++;
                    ri++;
            };
        int p = 0;
        for(int i = lp; i <= rp; i++){
            nums[i] = trr[p];
            p++;
        }
        return;
    }
}