using System;
using System.Collections.Generic;
using System.Linq;
using Utils;

namespace FlipArray
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Solve(new List<int>() { 15, 10, 6 });
        }

        public int Solve(List<int> a)
        {
            return GetMinSum(a, 0, a.Count - 1);
        }

        private int GetMinSum(List<int> a, int left, int right)
        {
            if (left > right || left < 0 || right>=a.Count)
            {
                return 0;
            }

            Arrays.Print<int>(a);
            Console.WriteLine(GetSumOfArray(a));

            for (int i = left; i <= right; i++)
            {
                
                a[i] = -a[i];
                GetMinSum(a, left, i - 1);
                GetMinSum(a, i+1, right);
                a[i] = -a[i];
            }
            return 0;
        }


        private int GetSumOfArray(List<int> a)
        {
            return a.Sum();
        }
    }
}
