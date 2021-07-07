package java.javaCodes.src;

public class SpiralMatrix {

    public static void main(String[] args) {
        
    }

    public int[][] generateMatrix(int a) {

        int[][] ans =  new int[a][a];

        int num = 1;
        int left = 0, right  = a-1, top=0,bottom =  a-1;

        while(left <  right){

            for(int i =left;i<=right;i++){
                ans[top][i] = num;
                num++;
            }

            for(int i = top+1;i<=bottom;i++){
                ans[i][right] = num;
                num++;
            }

            for(int i= right -1; i>=left;i--){
                ans[bottom][i] = num;
                num++;
            }

            for(int i= bottom +1;i> top;i--){
                ans[i][left] = num;
                num++;

            }
            left ++;
            top ++;
            right--;
            bottom --;
        }



        return ans;


    } 
    
}
