public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder op = new StringBuilder();
        foreach(string s in strs){
            int len = s.Length;
            op.Append(len);
            op.Append("#");
            op.Append(s);
        }
        Console.WriteLine(op.ToString());

        return op.ToString();
    }

    public List<string> Decode(string s) {
        int ptr = 0;
        List<string> sol  = new List<string>();
        while(ptr < s.Length){
            StringBuilder sl = new StringBuilder();
            while(s[ptr] != '#'){
                sl.Append(s[ptr]);
                ptr++;
            }

            int len = int.Parse(sl.ToString());
            ptr++;
            StringBuilder sb = new StringBuilder();
            while(len > 0){
                sb.Append(s[ptr]);
                ptr++;
                len--;
            }
            sol.Add(sb.ToString());
        }
        return sol;
   }
}
