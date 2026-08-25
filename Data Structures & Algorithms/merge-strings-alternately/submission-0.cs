public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int flen = word1.Length;
        int slen = word2.Length;
        StringBuilder sol = new StringBuilder();
        int lp = 0, rp = 0;
        while(lp < flen && rp < slen){
            sol.Append(word1[lp]);
            sol.Append(word2[rp]);
            lp++;
            rp++;
        }
        while(lp < flen){
            sol.Append(word1[lp]);
            lp++;
        }
        while(rp < slen){
            sol.Append(word2[rp]);
            rp++;
        }



        return sol.ToString();
    }
}