using System;
using System.Collections.Generic;
using Utils;

namespace SortArraysWithSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays.Print<int>(new Program().solve(new List<int>() { -6, -3, -1, 2, 4, 5}));
            Arrays.Print<int>(new Program().solve(new List<int>() { -1 }));
            Arrays.Print<int>(new Program().solve(new List<int>() { 0 }));
            Arrays.Print<int>(new Program().solve(new List<int>() { 1, 2 }));
            Arrays.Print<int>(new Program().solve(new List<int>() { -1, 0 }));
        }

        public List<int> solve(List<int> A)
        {
            int startingIndexOfNonNegativeNumber = A.Count;
            for(int k = 0; k < A.Count; k++)
            {
                if (A[k] >= 0)
                {
                    startingIndexOfNonNegativeNumber = k;
                    break;
                }
            }

            int start = 0, end = startingIndexOfNonNegativeNumber - 1;
            while(start < end)
            {
                int temp = A[start];
                A[start] = A[end];
                A[end] = temp;
                end--;
                start++;
            }

            List<int> ans = new List<int>(A.Count);

            int i = 0, j = startingIndexOfNonNegativeNumber;
            while(i < startingIndexOfNonNegativeNumber && j < A.Count)
            {
                if (-A[i] <= A[j])
                {
                    ans.Add(A[i] * A[i]);
                    i++;
                }
                else if (-A[i] > A[j])
                {
                    ans.Add(A[j] * A[j]);
                    j++;
                }
            }

            while (i < startingIndexOfNonNegativeNumber)
            {
                ans.Add(A[i] * A[i]);
                i++;
            }

            while (j < A.Count)
            {
                ans.Add(A[j] * A[j]);
                j++;
            }

            return ans;
        }
    }
}
