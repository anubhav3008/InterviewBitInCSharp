using System;
using System.Collections.Generic;

namespace MaxSumContiguousSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.maxSubArray(new List<int>() { 1, 2, 3, 4, -10 }));
            Console.WriteLine(p.maxSubArray(new List<int>() { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
            Console.WriteLine(p.maxSubArray(new List<int>() { -220,500 }));
        }

        public int maxSubArray(List<int> a)
        {
            bool allNegative = true;
            for(int i = 0; i < a.Count; i++)
            {
                if (a[i] >= 0)
                {
                    allNegative = false;
                    break;
                }

            }

            if (allNegative)
            {
                int max = int.MinValue;
                for (int i = 0; i < a.Count; i++)
                {
                    max = Math.Max(a[i], max);
                }
                return max;
            }


            int sum = 0;
            int maxSum = 0;

            for(int i = 0; i < a.Count; i++)
            {
                sum = sum + a[i];
                if(sum < 0)
                {
                    sum = 0;
                }
                maxSum = Math.Max(maxSum, sum);
            }

            return maxSum;
        }

    }
}
