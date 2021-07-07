using System;
using System.Collections.Generic;
using Utils;

namespace KthRowOfPascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            for(int i = 1; i <= 10; i++)
            {
                Arrays.Print<int>(program.getRow(i));
            }
        }

        public List<int> getRow(int k)
        {
            k++;
            List<int> previous = new List<int>(k);
            List<int> current = new List<int>(k);
            setAll(previous, k);
            setAll(current, k);

            for(int i = 0; i < k; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    if(j==0 || j == i)
                    {
                        current[j]=1;
                    }
                    else
                    {
                        current[j] = previous[j] + previous[j - 1];
                    }
                }
                List<int> temp = previous;
                previous = current;
                current = temp;
                setAll(current, 0);
               
            }
            return previous;
        }

        private void setAll(List<int> a, int k)
        {
            for (int i = 0; i < k; i++)
            {
                a.Add(0);
            }
        }
    }
}
