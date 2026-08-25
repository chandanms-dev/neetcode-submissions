public class Solution {
    public bool ValidPalindrome(string s) {
        int lp = 0, rp = s.Length - 1;
        while(lp <= rp){
            if(s[lp] != s[rp]){
                 return IsPalindrome(s,lp) || IsPalindrome(s,rp);
            }

            lp++;
            rp--;

        }
        return true;
    }

    public bool IsPalindrome(string s, int skipindex){
        int lp = 0, rp = s.Length - 1;
        while(lp <= rp){
            if(lp == skipindex){
                lp++;
                continue;
            }
            if(rp == skipindex){
                rp--;
                continue;
            }
            if(s[lp] != s[rp])return false;
            lp++;
            rp--;
        }
        return true;
    }
}