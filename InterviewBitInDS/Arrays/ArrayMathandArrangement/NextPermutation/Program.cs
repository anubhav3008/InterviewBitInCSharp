using System;
using System.Collections;
using System.Collections.Generic;
using Utils;

namespace NextPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            List<int> vals = new List<int>() { 1,2};
            Arrays.Print<int>(vals);
            Arrays.Print<int> (program.nextPermutation(vals));
            Console.WriteLine();

            vals = new List<int>() { 1, 2, 3 };
            Arrays.Print<int>(vals);
            Arrays.Print<int>(program.nextPermutation(vals));
            Console.WriteLine();

            vals = new List<int>() { 1, 3, 2 };
            Arrays.Print<int>(vals);
            Arrays.Print<int>(program.nextPermutation(vals));
            Console.WriteLine();

            vals = new List<int>() { 1, 3, 4 ,2 };
            Arrays.Print<int>(vals);
            Arrays.Print<int>(program.nextPermutation(vals));
            Console.WriteLine();

            vals = new List<int>() { 1, 4, 2, 3 };
            Arrays.Print<int>(vals);
            Arrays.Print<int>(program.nextPermutation(vals));
            Console.WriteLine();

            vals = new List<int>() { 1 };
            Arrays.Print<int>(vals);
            Arrays.Print<int>(program.nextPermutation(vals));
            Console.WriteLine();

            vals = new List<int>() { 2, 1 };
            Arrays.Print<int>(vals);
            Arrays.Print<int>(program.nextPermutation(vals));
            Console.WriteLine();

        }


        public List<int> nextPermutation(List<int> a)
        {
            if(a.Count == 1)
            {
                return a;
            }

            int i = a.Count-2;
            while(i>= 0 && a[i] > a[i + 1])
            {
                i--;
            }

            if (i == -1)
            {
                a.Reverse();
                return a;
            }

            int min = int.MaxValue;
            int minIndex = -1;
            for(int j = i + 1; j < a.Count; j++)
            {
                if(a[j]> a[i])
                {
                    if(min> a[j])
                    {
                        min = a[j];
                        minIndex = j;
                    }
                }
            }

            if(minIndex == -1)
            {
                a.Sort();
                return a;
            }

            int temp = a[minIndex];
            a[minIndex] = a[i];
            a[i] = temp;
            if(i+1<a.Count && a.Count - i - 1 >= 0)
            {
                a.Sort(i + 1, a.Count - i - 1, Comparer<int>.Default);
            }
            return a; 

        }
    }
}
