import java.util.ArrayList;
import java.util.Arrays;



public class MergeIntervals{
    static class Interval {
        int start;
        int end;
        Interval() { start = 0; end = 0; }
        Interval(int s, int e) { start = s; end = e; }
    }
    public static void main(String[] args) {
        MergeIntervals mergeIntervals = new MergeIntervals();
        
        var merged = mergeIntervals.insert(new ArrayList<>(Arrays.asList(
            new Interval(1,2), 
            new Interval(3,5), 
            new Interval(6,7), 
            new Interval(8,10),  
            new Interval(12,16))),
            new Interval(4,9));   
        for (Interval x1 : merged) {
            System.out.println(x1.start+ " "+ x1.end);
        }
        System.out.println();


        merged = mergeIntervals.insert(new ArrayList<>(Arrays.asList(
            new Interval(1,3),
            new Interval(6,9))),
            new Interval(2,5));   
        for (Interval x1 : merged) {
            System.out.println(x1.start+ " "+ x1.end);
        }
        System.out.println();


        merged = mergeIntervals.insert(new ArrayList<>(Arrays.asList(
            new Interval(1,2),
            new Interval(4,6))),
            new Interval(10,11));   
        for (Interval x1 : merged) {
            System.out.println(x1.start+ " "+ x1.end);
        }
        System.out.println();

        merged = mergeIntervals.insert(new ArrayList<>(Arrays.asList(
            new Interval(1,2),
            new Interval(4,6))),
            new Interval(4,6));   
        for (Interval x1 : merged) {
            System.out.println(x1.start+ " "+ x1.end);
        }
        System.out.println();

        merged = mergeIntervals.insert(new ArrayList<>(Arrays.asList(
            new Interval(1,2),
            new Interval(4,6))),
            new Interval(1,6));   
        for (Interval x1 : merged) {
            System.out.println(x1.start+ " "+ x1.end);
        }
        System.out.println();

        merged = mergeIntervals.insert(new ArrayList<>(Arrays.asList(
            new Interval(2,3),
            new Interval(4,6))),
            new Interval(1,8));   
        for (Interval x1 : merged) {
            System.out.println(x1.start+ " "+ x1.end);
        }
        System.out.println();




    }

    public ArrayList<Interval> insert(ArrayList<Interval> intervals, Interval newInterval) {
        if(intervals == null){
            intervals = new ArrayList<Interval>(1);
            intervals.add(newInterval);
            return intervals;
        }
        
        if(intervals.size() ==0){
            intervals.add(newInterval);
            return intervals;
        }
        if(newInterval.start > intervals.get(intervals.size()-1).end){
            intervals.add(newInterval);
            return intervals;
        }
        if(newInterval.end < intervals.get(0).start){
            intervals.add(0, newInterval);
            return intervals;
        }
        ArrayList<Interval> ans =  new ArrayList<>();
        int i =0;
        for(i=0;i< intervals.size();i++){
            if(intervals.get(i).start>newInterval.end){
                break;
            }
            else if(intervals.get(i).end <newInterval.start){
                ans.add(intervals.get(i));
            }
            else break;
        }
        Interval intervalToAdd =  new Interval();
        intervalToAdd.start = Math.min(newInterval.start, intervals.get(i).start);
        while(i< intervals.size() && intervals.get(i).end <= newInterval.end){
            intervalToAdd.end = Math.max(intervals.get(i).end, newInterval.end);
            i++;
        }

        if(i<intervals.size() && intervals.get(i).start<=newInterval.end){
            intervalToAdd.end =  Math.max(intervals.get(i).end, newInterval.end);
            i++;
        }
        if(intervalToAdd.end == 0){
            intervalToAdd.end = newInterval.end;
        }
    
        ans.add(intervalToAdd);

        while(i< intervals.size()){
            ans.add(intervals.get(i));
            i++;
        }
        return ans;
    }
}