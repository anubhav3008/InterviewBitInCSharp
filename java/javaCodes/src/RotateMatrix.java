package java.javaCodes.src;

import java.util.ArrayList;
import java.util.Arrays;

public class RotateMatrix {

    public static void main(String a[]) {
        var p = new RotateMatrix();

        ArrayList<ArrayList<Integer>> x ;

        x =  new ArrayList<>();
        x.add(new ArrayList<>(Arrays.asList(1,2)));
        x.add(new ArrayList<>(Arrays.asList(3,4)));       
        p.print(x);
        p.rotate(x);
        System.out.println();
        p.print(x);
        System.out.println();

        x =  new ArrayList<>();
        x.add(new ArrayList<>(Arrays.asList(1,2,3)));
        x.add(new ArrayList<>(Arrays.asList(4,5,6)));  
        x.add(new ArrayList<>(Arrays.asList(7,8,9)));       
        p.print(x);
        p.rotate(x);
        System.out.println();
        p.print(x);
        System.out.println();


        x =  new ArrayList<>();
        x.add(new ArrayList<>(Arrays.asList(1)));
        p.print(x);
        p.rotate(x);
        System.out.println();
        p.print(x);
        System.out.println();

        x =  new ArrayList<>();
        x.add(new ArrayList<>(Arrays.asList(1,2,3,4)));
        x.add(new ArrayList<>(Arrays.asList(5,6,7,8)));  
        x.add(new ArrayList<>(Arrays.asList(9,10,11,12)));
        x.add(new ArrayList<>(Arrays.asList(13,14,15,16)));       
        p.print(x);
        p.rotate(x);
        System.out.println();
        p.print(x);
        System.out.println();


    }

    public void rotate(ArrayList<ArrayList<Integer>> a) {
        int left = 0;
        int right = a.size() -1;
        int top = 0;
        int bottom = a.size() -1;
        while(left<right){

            int i = 0;
            while(left + i<right){

                int temp = a.get(top).get(left+i);
                a.get(top).set(left+i, a.get(bottom-i).get(left));
                a.get(bottom-i).set(left, a.get(bottom).get(right-i));             
                a.get(bottom).set(right-i, a.get(top+i).get(right));
                a.get(top+i).set(right, temp);

                i++;
            }
            left ++;
            right --;
            top ++;
            bottom--;

        }
	}

    private void print(ArrayList<ArrayList<Integer>> a){
        for (ArrayList<Integer> arrayList : a) {

            for (Integer arrayList2 : arrayList) {
                System.out.print(arrayList2+"\t");
                
            }
            System.out.println();
            
        }
    }
}
