using System;
using Utils;

namespace RotateMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int[][] m = { new[]{ 1, 2 }, new[]{ 3, 4 } };
            Arrays.Print2D<int>(m);
            program.solve(m);
            Arrays.Print2D<int>(m);
        }

        public void solve(int[][] a)
        {

        }
    }
}
