public class Solution {
    public void ReverseString(char[] s) {
        int lp = 0, rp = s.Length - 1;
        while(lp <= rp){
            char tmp = s[lp];
            s[lp] = s[rp];
            s[rp] = tmp;
            lp++;
            rp--;
        }
        return;
    }
}