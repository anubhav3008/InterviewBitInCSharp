package InterviewBitInDS.Arrays.SpaceRecycle;

import java.util.ArrayList;
import java.util.Arrays;

public class SetMatrixZeros{
    public static void main(String[] args) {
        SetMatrixZeros setMatrixZeros =  new SetMatrixZeros();
    }

    public void setZeroes(ArrayList<ArrayList<Integer>> a) {
        int m = a.size();
        int n = a.get(0).size();

        boolean[] rowZero = new boolean[m];
        boolean[] columnZero = new boolean[n];

        Arrays.fill(rowZero, false);
        Arrays.fill(columnZero, false);

        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(a.get(i).get(j)==0){
                    rowZero[i] = true;
                    columnZero[j] = true;
                }
            }
        }

        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(rowZero[i] || columnZero[j]){
                    a.get(i).set(j, 0);
                }
                else{
                    a.get(i).set(j, 1);
                }
            }
        }
        
	}



}