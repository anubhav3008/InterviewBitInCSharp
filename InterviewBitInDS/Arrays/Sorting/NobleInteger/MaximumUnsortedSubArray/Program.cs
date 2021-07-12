using System;
using System.Collections.Generic;
using Utils;
namespace MaximumUnsortedSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays.Print<int>(new Program().subUnsort(new List<int>() { 1, 3, 2, 4 ,5 }));
            Arrays.Print<int>(new Program().subUnsort(new List<int>() { 1, 2, 3, 4, 5 }));
            Arrays.Print<int>(new Program().subUnsort(new List<int>() { 1, 1 }));
        }

        public List<int> subUnsort(List<int> A)
        {
            List<int> ans = new List<int>(2);
            int[] maxElementToLeft = FindMaxElementToLeft(A);
            int[] minElementToRight = FindMinElementToRight(A);
            int i = 0;
            int start;
            int end;
            while (i < A.Count && A[i] >= maxElementToLeft[i] && A[i] <= minElementToRight[i])
            {
                i++;
            }
            if (i == A.Count)
            {
                ans.Add(-1);
                return ans;
            }
            start = i;

            i = A.Count - 1;

            while (i >= 0 && A[i] >= maxElementToLeft[i] && A[i] <= minElementToRight[i])
            {
                i--;
            }
            end = i;

            ans.Add(start);
            ans.Add(end);

            return ans;
        }

        private int[] FindMaxElementToLeft(List<int> a)
        {
            int[] maxElementToLeft = new int[a.Count];
            maxElementToLeft[0] = int.MinValue;
            for (int i = 1; i < a.Count; i++)
            {
                maxElementToLeft[i] = Math.Max(maxElementToLeft[i - 1], a[i - 1]);
            }
            return maxElementToLeft;
        }


        private int[] FindMinElementToRight(List<int> a)
        {
            int[] minElementToRight = new int[a.Count];
            minElementToRight[a.Count-1] = int.MaxValue;
            for (int i = a.Count-2; i >= 0; i--)
            {
                minElementToRight[i] = Math.Min(minElementToRight[i + 1], a[i + 1]);
            }
            return minElementToRight;
        }
    }
}