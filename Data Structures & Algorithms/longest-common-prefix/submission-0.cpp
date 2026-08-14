class Solution {
public:
    string longestCommonPrefix(vector<string>& strs) {
        int minStrLen = INT_MAX;
        for(string i : strs){
            if( i == ""){
                return "";
            }
            if(i.size()  < minStrLen){
                minStrLen = i.size();
            }
        }
        string longestPrefix = "";
        string comp, comp2 = "";
        for(int i = 0; i < minStrLen; i++){
            comp = strs[0][i];
            for(int j = 0; j < strs.size();j++){
                comp2 = strs[j][i];
                cout<<comp2 <<" "<<comp<<"\n";
                if( comp2 != comp ){
                    return longestPrefix;
                }
            }
            longestPrefix+=comp;

        }
        return longestPrefix;

    }
};