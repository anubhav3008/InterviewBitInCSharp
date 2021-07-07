using System;
using System.Collections.Generic;
using Utils;

namespace AntiDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            List<List<int>> a = new List<List<int>>() {
                new List<int>() { 1, 2, 3 },
                new List<int>() { 4, 5, 6 },
                new List<int>() { 7, 8, 9 } };
            Arrays.Print2D<int>(program.diagonal(a));

            a = new List<List<int>>() {
                new List<int>() { 1, 2 },
                new List<int>() { 3, 4 } };
            Arrays.Print2D<int>(program.diagonal(a));

            a = new List<List<int>>() {
                new List<int>() { 1 } };
            Arrays.Print2D<int>(program.diagonal(a));

        }

        public List<List<int>> diagonal(List<List<int>> a)
        {
            List<List<int>> ans = new List<List<int>>();
            int n = a.Count;
            int left = 0;
            while (left < n)
            {
                int i = 0;
                int j = left;
                List<int> row = new List<int>();
                while(i<n && j >= 0)
                {
                    row.Add(a[i][j]);
                    i++;
                    j--;
                }
                left++;
                ans.Add(row);
            }

            int top = 1;
            while (top < n)
            {
                int i = top;
                int j = n - 1;
                List<int> row = new List<int>();
                while (i<n && j >= 0)
                {
                    row.Add(a[i][j]);
                    i++;
                    j--;
                }
                top++;
                ans.Add(row);
            }

            return ans;
        }
    }
}
