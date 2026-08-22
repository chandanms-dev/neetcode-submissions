public class Solution {
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int,int> hm = new Dictionary<int,int>();
        int sum = 0;
        int sol = 0;
        foreach(int a in nums){
            sum+=a;
            int tmp = sum - k;
            if(tmp == 0)sol++;
            if(hm.ContainsKey(tmp)){
                sol+=hm[tmp];
            } 

                if(hm.ContainsKey(sum)) {
                    hm[sum]++;
                } else {
                    hm[sum] = 1;
                }

        }

        return sol;
    }
}