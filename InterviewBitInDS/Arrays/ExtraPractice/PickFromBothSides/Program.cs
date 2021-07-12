using System;
using System.Collections.Generic;

namespace PickFromBothSides
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine(program.solve(new List<int>() { 5, -2, 3, 1, 2 }, 3));
            Console.WriteLine(program.solve(new List<int>() { 1, 2 }, 1));
        }

        public int solve(List<int> A, int B)
        {
            int[] leftSumIncludingTheIndex = new int[B];
            for(int i = 0; i < B; i++)
            {
                if (i == 0)
                {
                    leftSumIncludingTheIndex[i] = A[i];
                }
                else
                {
                    leftSumIncludingTheIndex[i] = leftSumIncludingTheIndex[i - 1] + A[i];
                }
            }


            int[] rightSumIncludingIndex = new int[B];

            for(int i = A.Count - 1, rightMostVal = B - 1 ; rightMostVal >= 0; i--, rightMostVal--)
            {
                if (i == A.Count - 1)
                {
                    rightSumIncludingIndex[rightMostVal] = A[i];
                }
                else
                {
                    rightSumIncludingIndex[rightMostVal] = rightSumIncludingIndex[rightMostVal + 1] + A[i];
                }
            }

            int maxSum = int.MinValue;
            for(int i = 0 ; i < B - 1; i++)
            {
                maxSum = Math.Max(leftSumIncludingTheIndex[i] + rightSumIncludingIndex[i + 1], maxSum);
            }
            maxSum = Math.Max(maxSum, leftSumIncludingTheIndex[B - 1]);
            maxSum = Math.Max(maxSum, rightSumIncludingIndex[0]);

            return maxSum;
        }
    }
}
