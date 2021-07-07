using System;
using System.Collections.Generic;
using Utils;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Arrays.Print2D<int>(program.solve(1));
            Arrays.Print2D<int>(program.solve(2));
            Arrays.Print2D<int>(program.solve(3));
            Arrays.Print2D<int>(program.solve(4));
            Arrays.Print2D<int>(program.solve(5));

        }

        public List<List<int>> solve(int n)
        {
            List<List<int>> ans = new List<List<int>>(n);
            for (int i = 0; i < n; i++)
            {
                List<int> jthRow = new List<int>();

                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        jthRow.Add(1);
                    }
                    else
                    {
                        jthRow.Add(ans[i - 1][j] + ans[i - 1][j - 1]);
                    }
                }
                ans.Add(jthRow);
            }
            return ans;
        }
    }
}
