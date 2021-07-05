using System;
using System.Collections.Generic;
using System.Linq;
using Utils;

namespace Partitions
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.solve(5, new List<int>() { 1, 2, 3, 0, 3 }));
            Console.WriteLine(p.solve(4, new List<int>() { 0, 1, -1, 0 }));
        }



        public int solve(int a, List<int> b)
        {
            if (a < 3)
            {
                return 0;
            }

            int sum = 0;
            for (int i = 0; i < a; i++)
            {
                sum += b[i];
            }

            
            if(sum % 3 != 0)
            {
                return 0;
            }
            int[] leftSum = GetLeftSum(a, b);
            int[] rightSum = GetRightSum(a, b);
            int[] count = GetCountOfDevideBy3FromRight(a, rightSum, sum);

            Arrays.Print<int>(b);
            Arrays.Print<int>(leftSum);
            Arrays.Print<int>(rightSum);
            Arrays.Print<int>(count);
            int c = 0;
            for(int i = 0; i < a-2; i++)
            {
                if (leftSum[i] == sum / 3)
                {
                    c = c + count[i + 2];
                }
            }
            return c;
        }


        private int[] GetLeftSum(int a, List<int> b)
        {
            int[] leftSum = new int[a];
            leftSum[0] = b[0];
            for(int i = 1; i < a; i++)
            {
                leftSum[i] = leftSum[i - 1] + b[i];
            }

            return leftSum;
        }


        private int[] GetRightSum(int a, List<int> b)
        {
            int[] rightSum = new int[a];
            rightSum[a-1] = b[a-1];
            for (int i = a-2; i >= 0; i--)
            {
                rightSum[i] = rightSum[i + 1] + b[i];
            }

            return rightSum;
        }


        private int[] GetCountOfDevideBy3FromRight(int a,int[] b, int sum)
        {
            int[] count = new int[a];
            if(b[a-1] == sum / 3)
            {
                count[a - 1] = 1;
            }

            for(int i = a - 2; i >= 0; i--)
            {
                if(b[i] == sum / 3)
                {
                    count[i] = count[i + 1] + 1;
                }
                else
                {
                    count[i] = count[i + 1];
                }
            }

            return count;

        }

        private void modlus3(List<int> a)
        {
            for(int i = 0; i < a.Count; i++)
            {
                a[i] = a[i] % 3;
            }

        }

    }
}
