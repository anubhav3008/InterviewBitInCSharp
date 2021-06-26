using System;
using System.Collections.Generic;
using System.Linq;
using Utils;

namespace Minimum_Lights_to_Activate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Program().Solve(new List<int>() { 0, 0, 1, 1, 1, 0, 0, 1 }, 3));
            Console.WriteLine(new Program().Solve(new List<int>() { 0, 0, 0, 1, 0 }, 3));
            Console.WriteLine(new Program().Solve(new List<int>() { 1, 1, 1, 1 }, 3));

            Console.WriteLine(new Program().Solve(new List<int>() { 0, 1, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 1, 0, 1, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0 }, 12));
        }

        public int Solve(List<int> a, int b)
        {
            int count = 0;
            int n = a.Count;
            int[] leftCapacity = new int[n];
            int[] rightCapacity = new int[n];

            for(int j = 0; j < n; j++)
            {
                if (a[j] == 0)
                {
                    leftCapacity[j] = int.MinValue;
                    rightCapacity[j] = int.MaxValue;
                }
                else
                {
                    leftCapacity[j] = Math.Max(0, j - b + 1);
                    rightCapacity[j] = Math.Min(j + b - 1, n);
                }
            }


            int i = 0;
            while (i < n)
            {
                int right = Math.Min(i + b - 1, n - 1);
                int left = Math.Max(i - b + 1, 0);
                bool foundIndex = false;
                int current = right;
                while (current >= left)
                {
                  
                    if(current >= i)
                    {
                        if (leftCapacity[current] != int.MinValue && leftCapacity[current] <= i)
                        {
                            count++;
                            i = current + b;
                            foundIndex = true;
                            // Console.WriteLine($"found index on right= {current}");
                            break;
                        }
                        current--;
                    }

                    else
                    {
                        if (rightCapacity[current] !=int.MaxValue && rightCapacity[current] >= i)
                        {
                            // Console.WriteLine($"found index on left= {current} and i = {i}");
                            count++;
                            i = current + b;
                            foundIndex = true;
                            
                            break;
                        }
                        current--;
                    }
                }

                if (!foundIndex)
                {
                    return -1;
                }
            }
            // Arrays.Print<int>(a.AsEnumerable());
            // Arrays.Print<int>(leftCapacity.AsEnumerable());
            // Arrays.Print<int>(rightCapacity.AsEnumerable());
            return count;
        }
    }
}
