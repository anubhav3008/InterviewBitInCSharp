using System;
using System.Collections.Generic;

namespace MaxDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Program().maximumGap(new List<int>() { 3, 5, 4, 2}));
            Console.WriteLine(new Program().maximumGap(new List<int>() { 1, 5, 4, 2 }));
            Console.WriteLine(new Program().maximumGap(new List<int>() { 1 }));
            Console.WriteLine(new Program().maximumGap(new List<int>() { 1, 2 }));
            Console.WriteLine(new Program().maximumGap(new List<int>() { 2, 1 }));
            Console.WriteLine(new Program().maximumGap(new List<int>() { 2, 2 }));
            Console.WriteLine(new Program().maximumGap(new List<int>() { 1, 5, 4, 1 }));

        }

        public int maximumGap(List<int> A)
        {
            int maxGap = -1;
            Dictionary<int, int> minIndex = GetMinimumIndexes(A);
            Dictionary<int, int> maxIndex = GetMaximumIndexes(A);
            A.Sort();

            int[] maxIndexAtIndex = new int[A.Count];
            for(int i = 0; i < A.Count; i++)
            {
                maxIndexAtIndex[i] = maxIndex[A[i]];
            }

            SetMaxValuesFromRight(maxIndexAtIndex);

            for(int i = 0; i < A.Count - 1; i++)
            {
                int indexValue = minIndex[A[i]];
                int rightValueGreaterThan = maxIndexAtIndex[i + 1];
                maxGap = Math.Max(maxGap, rightValueGreaterThan - indexValue);
            }

            return maxGap;

        }

        private void SetMaxValuesFromRight(int[] a)
        {
            for(int i = a.Length - 2; i >= 0; i--)
            {
                a[i] = Math.Max(a[i], a[i + 1]);
            }
        }

        private Dictionary<int, int> GetMinimumIndexes(List<int> a)
        {
            Dictionary<int, int> minIndex = new Dictionary<int, int>();
            for(int i = 0; i < a.Count; i++)
            {
                if (!minIndex.ContainsKey(a[i])){
                    minIndex.Add(a[i], i);
                }
            }
            return minIndex;
        }


        private Dictionary<int, int> GetMaximumIndexes(List<int> a)
        {
            Dictionary<int, int> maxIndexs = new Dictionary<int, int>();
            for (int i =a.Count -1; i >= 0; i--)
            {
                if (!maxIndexs.ContainsKey(a[i]))
                {
                    maxIndexs.Add(a[i], i);
                }
            }
            return maxIndexs;
        }

    }
}
