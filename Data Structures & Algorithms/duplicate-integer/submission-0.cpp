class Solution {
public:
    bool hasDuplicate(vector<int>& nums) {
        sort(nums.begin(),nums.end());
        int el = INT_MIN;
        for(int i : nums){
            if(i == el) return true;
            el = i;
        }

        return false;
    }
};