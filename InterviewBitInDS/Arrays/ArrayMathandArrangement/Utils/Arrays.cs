using System;
using System.Collections.Generic;
using System.Text;

namespace Utils
{
    public class Arrays
    {
        public static void Print<T>(IEnumerable<T> x){
            var enumeration = x.GetEnumerator();
            while (enumeration.MoveNext())
            {
                    Console.Write(enumeration.Current + "\t");
            }
            Console.WriteLine();
        }

        public static void Print2D<T>(IEnumerable<IEnumerable<T>> x)
        {
            var enumeration = x.GetEnumerator();
            while (enumeration.MoveNext())
            {
                var innerEnumeration = enumeration.Current.GetEnumerator();
                while (innerEnumeration.MoveNext())
                {
                    Console.Write(innerEnumeration.Current + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
