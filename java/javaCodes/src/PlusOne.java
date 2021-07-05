import java.util.ArrayList;
import java.util.Arrays;

public class PlusOne {
    public static void main(String[] args) throws Exception {
        PlusOne app =  new PlusOne();
        app.print(app.plusOne(new ArrayList<Integer>(Arrays.asList(1,2,3))));
        app.print(app.plusOne(new ArrayList<Integer>(Arrays.asList(9))));
        app.print(app.plusOne(new ArrayList<Integer>(Arrays.asList(7,8,9))));
        app.print(app.plusOne(new ArrayList<Integer>(Arrays.asList(9,9))));
        app.print(app.plusOne(new ArrayList<Integer>(Arrays.asList(0,1,2,3))));
        app.print(app.plusOne(new ArrayList<Integer>(Arrays.asList(0,0,1,2,3))));
        app.print(app.plusOne(new ArrayList<Integer>(Arrays.asList(0))));
        app.print(app.plusOne(new ArrayList<Integer>(Arrays.asList(0,0,0))));

    }

    public ArrayList<Integer> plusOne(ArrayList<Integer> A) {
		int n =  A.size();
		int i =  n-1;
        int msb = findMsb(A);
        if(msb == -1){
            return new ArrayList<Integer>(Arrays.asList(1));
        }

        boolean flag = false;
        while(i>=msb){
            A.set(i, A.get(i)+1);
            if(A.get(i)<10){
                flag = true;
                break;
            }
            A.set(i, A.get(i)%10);
            i--;
        }

        ArrayList<Integer> ans =  new ArrayList<>();
        if(!flag){
            ans.add(1);
        }
      
        ans.addAll(A.subList(msb, n));
        return ans;
    }


    private int findMsb(ArrayList<Integer> a){
        int i=0;
        while(i<a.size() && a.get(i)==0){
            i++;
        }
        if(i==a.size()){
            return -1;
        }
        return i;
    }

    private void print(ArrayList<Integer> a){
        for(int i=0;i<a.size();i++){
            System.out.print(a.get(i)+ " ");
        }
        System.out.println();
    }
}
