public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<string,int> hm = new Dictionary<string,int>();
        for(int i = 0; i < 9; i++){
            for(int j = 0; j < 9; j++){
                if(board[i][j] != '.'){
                    StringBuilder sig = new StringBuilder();
                sig.Append((i/3));
                sig.Append( (j/3));
                sig.Append("#");
                sig.Append(board[i][j]);
                if(hm.ContainsKey(sig.ToString())) return false;
                hm[sig.ToString()] = 1;
                sig.Clear();
                sig.Append(i);
                sig.Append("R");
                sig.Append(board[i][j]);

                if(hm.ContainsKey(sig.ToString())) return false;
                hm[sig.ToString()] = 1;
                sig.Clear();
                 sig.Append(j);
                sig.Append("C");
                sig.Append(board[i][j]);
                if(hm.ContainsKey(sig.ToString())) return false;
                hm[sig.ToString()] = 1;
                }
            }
        }
        return true;
    }
    }
