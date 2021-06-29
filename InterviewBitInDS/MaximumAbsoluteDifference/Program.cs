using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAbsoluteDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.maxArr(new List<int>() { 1,3,-1}));
            Console.WriteLine(program.maxArr(new List<int>() { 2, 2, 2 }));

        }

        public int maxArr(List<int> a)
        {
            int[] sumArray = new int[a.Count];
            int[] minusArray = new int[a.Count];


            for(int i = 0; i < a.Count; i++)
            {
                sumArray[i] = a[i] + i;
                minusArray[i] = a[i] - i;
            }

            return Math.Max(FindMax(sumArray) - FindMin(sumArray), FindMax(minusArray) - FindMin(minusArray));
        }

        private int FindMax(int[] a)
        {
            return a.Max();
        }

        private int FindMin(int[] a)
        {
            return a.Min();
        }
    }
}
