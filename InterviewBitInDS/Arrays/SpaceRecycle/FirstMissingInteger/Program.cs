using System;
using System.Collections.Generic;

namespace FirstMissingInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.firstMissingPositive(new List<int>() {-8, -7, -6}));
        }

        public int firstMissingPositive(List<int> s)
        {
            bool foundn = false;
            bool foundnplus1 = false;
            for(int i = 0; i < s.Count; i++)
            {
                if (s[i] == s.Count)
                {
                    foundn = true;
                }
                if(s[i]== s.Count + 1)
                {
                    foundnplus1 = true;
                }
                if (s[i]<=0 || s[i] > s.Count)
                {
                    s[i] = 0;
                }
            }

            for(int i = 0; i < s.Count; i++)
            {
                int num = s[i] % s.Count;
                if (s[num] < s.Count)
                {
                    s[num] = s[num] + s.Count;
                }
            }

            for (int i = 1; i < s.Count; i++)
            {
                if (s[i] < s.Count)
                {
                    return i;
                }
            }

            if (!foundn)
            {
                return s.Count;
            }
            if (!foundnplus1)
            {
                return s.Count + 1;
            }

            return s.Count + 2;

            

        }
    }
}
