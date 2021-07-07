using System;
using System.Collections.Generic;
using Utils;
namespace PerfectPeak
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.perfectPeak(new List<int>() {1,2,3}));
        }

        public int perfectPeak(List<int> a)
        {
            int[] leftMax = GetMaxLeft(a);
            int[] rightMin = GetMinRight(a);
            for(int i = 1; i < a.Count - 1; i++)
            {
                if(a[i]>leftMax[i-1] && a[i] < rightMin[i+1])
                {
                    return 1;
                }
            }
            return 0;
        }

        private int[] GetMaxLeft(List<int> a)
        {
            int[] left = new int[a.Count];
            left[0] = a[0];
            for(int i = 1; i < a.Count; i++)
            {
                left[i] = Math.Max(a[i] ,left[i - 1]);
            }
            return left;
        }

        private int[] GetMinRight(List<int> a)
        {
            int[] right = new int[a.Count];
            right[a.Count - 1] = a[a.Count - 1];
            for(int i = a.Count - 2; i >= 0; i--)
            {
                right[i] = Math.Min(a[i], right[i + 1]);
            }
            return right;
        }
    }
}
