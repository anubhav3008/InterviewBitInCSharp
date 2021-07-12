using System;
using System.Collections.Generic;
using Utils;
namespace HotelBookingPossible
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(new Program().hotel(new List<int>() {1, 3, 5}, new List<int>() {1, 6, 8}, 1));

        }

        public int hotel(List<int> A, List<int> B, int C)
        {
            A.Sort();
            B.Sort();
            int i = 0, j = 0, s = 0;
            while (i < A.Count && j< A.Count)
            {
                if (A[i] < B[j])
                {
                    s++;
                    i++;
                }
                else if (A[i] > B[j])
                {
                    s--;
                    j++;
                }
                else
                {
                    i++;
                    j++;
                }
                if (s > C)
                {
                    return 0;
                }
            }
            while (i < A.Count)
            {
                s++;
                i++;
            }
            while (j < A.Count)
            {
                s--;
                j++;
            }

            if (s > C)
            {
                return 0;
            }
            return 1;
        }
    }
}
