public class Solution {
    public bool IsPalindrome(string s) {
        int lp = 0, rp = s.Length - 1;
        while(lp <= rp) {
            while(lp <= s.Length - 1 && !Char.IsLetterOrDigit(s[lp]) ){
                lp++;
            }
            while(rp >=0 && !Char.IsLetterOrDigit(s[rp])){
                rp--;
            }
                            
            if(lp <= s.Length -1 && rp >= 0){
                if(Char.ToLower(s[lp]) != Char.ToLower(s[rp])) return false;
            }
            lp++;
            rp--;
            
        }
        return true;
    }
}
