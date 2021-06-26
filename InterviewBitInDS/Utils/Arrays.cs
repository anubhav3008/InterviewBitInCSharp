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
                    Console.Write(enumeration.Current + ",");
            }
            Console.WriteLine();
        }
    }
}
