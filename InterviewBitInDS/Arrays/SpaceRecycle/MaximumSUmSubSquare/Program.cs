using System;
using System.Collections.Generic;
using Utils;
namespace MaximumSUmSubSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            List<List<int>> a = new List<List<int>>() {
                new List<int>() { 1, 1, 1, 1, 1 },
                new List<int>() { 2, 2, 2, 2, 2 },
                new List<int>() { 3, 8, 6, 7, 3 },
                new List<int>() { 4, 4, 4, 4, 4 },
                new List<int>() { 5, 5, 5, 5, 5 } };
            Console.WriteLine(program.solve(a, 3));

            a = new List<List<int>>() {
                new List<int>() { 2, 2 },
                new List<int>() { 2, 2 } };
            Console.WriteLine(program.solve(a, 2));
        }

        public int solve(List<List<int>> A, int B)
        {
            int[][] leftSumMatrix = GetLeftSumMatrix(A);
            int maxSum = int.MinValue;
            for(int i = 0; i + B  <= A.Count; i++)
            {
                for(int j = 0; j + B <= A.Count; j++)
                {
                    int top = i;
                    int s = 0;
                    int limit = top + B;
                    while(top < limit)
                    {
                        s = s + (leftSumMatrix[top][j + B -1] - leftSumMatrix[top][j] + A[top][j]);
                        top++;
                    }
                    maxSum = Math.Max(maxSum, s);
                }
            }
            return maxSum;
        }


        private int[][] GetLeftSumMatrix(List<List<int>> a)
        {
            int[][] x = new int[a.Count][];
            for(int i = 0; i < a.Count; i++)
            {
                x[i] = new int[a.Count];
                for(int j = 0; j < a.Count; j++)
                {
                    if (j == 0)
                    {
                        x[i][j] = a[i][j];                       
                    }
                    else
                    {
                        x[i][j] = x[i][j - 1] + a[i][j];
                    }
                }
            }
            return x;
        }
    }
}
