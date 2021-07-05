using System;
using System.Collections.Generic;
using Utils;

namespace Flip
{
    class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();
            Arrays.Print<int>(program.flip("010"));
            Arrays.Print<int>(program.flip("111"));
            Arrays.Print<int>(program.flip("0000"));
            Arrays.Print<int>(program.flip("100101"));
            Arrays.Print<int>(program.flip("0100"));


        }


        public List<int> flip(string a)
        {
            List<int> ans = new List<int>(2);
            if (a.Length == 0 || !a.Contains('0'))
            {
                return ans;
            }

            int[] array = new int[a.Length];
            for(int k = 0; k < a.Length; k++)
            {
                if (a[k] == '0')
                {
                    array[k] = 1;
                }
                else
                {
                    array[k] = -1;
                }
            }

            // Arrays.Print<int>(array);

            int i = 0, j = 0;
            int maxSum = -1;
            while(i< array.Length && j< array.Length)
            {
                int sum = int.MaxValue;
                while(sum >= 0 && i < array.Length && j < array.Length)
                {
                    if(sum == int.MaxValue)
                    {
                        sum = 0;
                    }
                    sum = sum + array[j];
                    if(sum > maxSum)
                    {
                        maxSum = sum;
                        ans.Clear();
                        ans.Add(i+1);
                        ans.Add(j+1);
                    }
                    if(sum >= 0)
                    {
                        j++;
                    }
                    
                }
                i = j + 1;
                j = i;
            }

            return ans;
        }


        public List<int> flip2(string A)
        {
            List<int> result = new List<int>();
            int maxSum = -1;
            int currentSum = -1;
            int startIndex = -1;
            for (int index = 0; index < A.Length; index++)
            {
                int value = A[index] == '0' ? 1 : -1;
                if (currentSum >= 0)
                {
                    currentSum += value;
                }
                else
                {
                    startIndex = index;
                    currentSum = value;
                }
                if (maxSum < currentSum)
                {
                    result.Clear();
                    result.Add(startIndex + 1);
                    result.Add(index + 1);
                    maxSum = currentSum;
                }
            }
            return result;
        }
    }
}
