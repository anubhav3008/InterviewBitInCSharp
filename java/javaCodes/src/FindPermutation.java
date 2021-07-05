import java.util.ArrayList;

public class FindPermutation {

    public static void main(String[] args) {
        FindPermutation findPermutation = new FindPermutation();
        System.out.println(findPermutation.findPerm("ID",3));
    }

    public ArrayList<Integer> findPerm(final String A, int B) {
        int n = B;        
        ArrayList<Integer> ans =  new ArrayList<>(n);
        if(n==0){
         return ans;   
        }
        ans.add(1);
        int min = 1;
        int max = 1;
        for(int i=0;i<n-1;i++){
            char c = A.charAt(i);
            if(c=='I'){
                ans.add(max+1);
                max++;
            }
            else if(c=='D'){
                ans.add(min-1);
                min--;
            }
        }
        if(min<=0){
            for(int i=0;i<n;i++){
                ans.set(i, ans.get(i)+1-min);
            }
        }
        return ans;
    }
    
}
