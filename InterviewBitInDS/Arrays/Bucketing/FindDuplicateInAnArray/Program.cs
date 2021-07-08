using System;
using System.Collections.Generic;

namespace FindDuplicateInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Program().repeatedNumber(new List<int> { 3, 4, 1, 4, 1 }));
        }

        public int repeatedNumber(List<int> a)
        {
            bool[] numberFound = new bool[a.Count];
            for(int i = 0; i < a.Count; i++)
            {
                if (numberFound[a[i]])
                {
                    return a[i];
                }
                numberFound[a[i]] = true;
            }

            return -1;
        }
    }
}
