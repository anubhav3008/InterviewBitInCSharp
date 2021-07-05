import java.util.ArrayList;
import java.util.Arrays;


public class MergeOverlapping {
    static class Interval {
        int start;
        int end;
        Interval() { start = 0; end = 0; }
        Interval(int s, int e) { start = s; end = e; }
    }

    public static void main(String[] args) {
        MergeOverlapping mergeOverlapping =  new MergeOverlapping();
        var merged = mergeOverlapping.merge(new ArrayList<>(Arrays.asList(
            new Interval(1,3), 
            new Interval(2, 6), 
            new Interval(8, 10), 
            new Interval(15, 18))));  
            
        for (Interval x1 : merged) {
            System.out.println(x1.start+ " "+ x1.end);
        }
        System.out.println();

        merged = mergeOverlapping.merge(new ArrayList<>(Arrays.asList(
            new Interval(1,3), 
            new Interval(2, 6)))); 
            
        for (Interval x1 : merged) {
            System.out.println(x1.start+ " "+ x1.end);
        }
        System.out.println();

        merged = mergeOverlapping.merge(new ArrayList<>(Arrays.asList(
            new Interval(1,2), 
            new Interval(3, 6)))); 
            
        for (Interval x1 : merged) {
            System.out.println(x1.start+ " "+ x1.end);
        }
        System.out.println();


        merged = mergeOverlapping.merge(new ArrayList<>(Arrays.asList(
            new Interval(1,10), 
            new Interval(2,9), 
            new Interval(3,8), 
            new Interval(4,7), 
            new Interval(5,6), 
            new Interval(6, 6)))); 
            
        for (Interval x1 : merged) {
            System.out.println(x1.start+ " "+ x1.end);
        }
        System.out.println();

    }

    public ArrayList<Interval> merge(ArrayList<Interval> intervals) {
        ArrayList<Interval> ans =  new ArrayList<>();
        int n = intervals.size();

        intervals.sort((a,b) -> {
            if(a.start == b.start){
                return a.end - b.end;
            }
            return a.start - b.start;
        });
        int min =  Math.min(intervals.get(0).end, intervals.get(0).start);
        int max =  Math.max(intervals.get(0).end, intervals.get(0).start);

        int i=0;
        while(i<n){
            Interval interval =  intervals.get(i);
            sortInterval(interval);
            if(isOverlapping(interval, min, max)){
                min = Math.min(min, interval.start);
                max = Math.max(max, interval.end);  
            }else{
                ans.add(new Interval(min, max));
                min = interval.start;
                max = interval.end;
            }
            if(i==n-1){
                ans.add(new Interval(min, max));
            }
            i++;
        }        
        return ans;
    }

    private void sortInterval(Interval interval){
        if(interval.start>interval.end){
            int temp = interval.start;
            interval.start = interval.end;
            interval.end = temp;
        }
    }

    // a2 :  min
    // b2: max
    private boolean isOverlapping(Interval interval, int a2, int b2){
        int a1 = Math.min(interval.start, interval.end);
        int b1 = Math.max(interval.end, interval.start);

        if(b1<a2 || a1>b2){
            return false;
        }
        return true;
    }
}
