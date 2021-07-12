using System;
using System.Collections.Generic;
using Utils;
namespace WaveArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays.Print<int>(new Program().wave(new List<int>() {1,2,2,2,3,4,5 }));
        }

        public List<int> wave(List<int> A)
        {
            A.Sort();
            int i = 0;
            while (i+1 < A.Count)
            {
                int temp = A[i];
                A[i] = A[i+1];
                A[i + 1] = temp;
                i = i + 2;
            }
            return A;
        }
    }
}
