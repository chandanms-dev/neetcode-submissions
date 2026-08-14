class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        unordered_map<int,int> hm;
        vector<int> sol;
        for(int i = 0; i < nums.size(); i++){
            if(hm.find(nums[i]) != hm.end()){
                if(i < hm[nums[i]]){
                    sol.push_back(i);
                    sol.push_back(hm[nums[i]]);
                } else {
                    sol.push_back(hm[nums[i]]);
                    sol.push_back(i);
                }
            } else {
                hm[target-nums[i]] = i;
            }
        }
        return sol;
    }
};
