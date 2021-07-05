using System;
using System.Collections.Generic;
using System.Text;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.largestNumber(new List<int>() { 3, 30, 34, 5, 9 }));
            Console.WriteLine(p.largestNumber(new List<int>() {0,0,0 }));
        }

        public string largestNumber(List<int> A)
        {
            A.Sort(compare);
            StringBuilder sb = new StringBuilder();
            int i = 0;
            while (i< A.Count && A[i] == 0)
            {
                i++;
            }
            
            for(; i < A.Count; i++)
            {
                sb.Append(A[i]);
            }
            return sb.Length == 0 ? "0" : sb.ToString();
        }

        private int compare(int a, int b)
        {
            String number1 = a + "" + b;
            String number2 = b + "" + a;

            int i = 0;
            while(i< number1.Length)
            {
                var num1 = Char.GetNumericValue(number1[i]);
                var num2 = Char.GetNumericValue(number2[i]);

                if(num1 > num2)
                {
                    return -1;
                }
                if(num2 > num1)
                {
                    return 1;
                }
                i++;
            }

            return 0;
        }
    }
}
