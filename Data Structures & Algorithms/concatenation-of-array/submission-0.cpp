class Solution {
public:
    vector<int> getConcatenation(vector<int>& nums) {
        vector<int> sol;
        for(int j = 0; j < 2; j++){
            for(int i : nums ){
            sol.push_back(i);
        }
        }
        return sol;
    }
};