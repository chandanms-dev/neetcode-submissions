public class NumMatrix {
int[,] sm;
    public NumMatrix(int[][] matrix) {
        int row = matrix.Length;
        int col = matrix[0].Length;
        sm = new int[row+1,col+1];
        for(int i = 0; i < row; i++){
            int prefix = 0;
            for(int j = 0; j < col; j++){
                prefix+=matrix[i][j];
                sm[i+1,j+1] += prefix + sm[i,j+1];
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        return sm[row2+1,col2+1] - sm[row1,col2+1] - sm[row2+1,col1] + sm[row1,col1];
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */