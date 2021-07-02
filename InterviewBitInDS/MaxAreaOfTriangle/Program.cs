using System;
using System.Collections.Generic;
using Utils;

namespace MaxAreaOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Program().solve(new List<string> { "rrrrr", "rrrrg", "rrrrr", "bbbbb" }));
            // Console.WriteLine(new Program().solve(new List<string> { "rrr", "rrr", "rrr" }));
            // Console.WriteLine(new Program().solve(new List<string> { "rrrr", "rgrg", "rrrr", "rbrr" }));
             Console.WriteLine(new Program().solve(new List<string> { "rbrrggggbbbrgrrbr", "bbrrgbrbrgbrrgbbg", "ggbrggrrgrrgbrrrg", "rrrbgggbbggrrbgbr", "bbggggrbrgggrrbgg", "rrrbbgbgrrbrrgrbg", "gbbbrgbggrgbbrbgg", "bgbgrgbrbrgbrgggr", "bgbggrrrbrrgbrgbb", "brbggbbrrbgbrrgrb", "ggbbgbbbgbrbbbgbg", "gbrrbgrbrbgrrrgbg", "bgbrbbgrgbgrrrbgr", "brrgggbbgrrbgrbbg", "bbbrrbbbrbggrrbbr", "rrrrbgrbgrrbbrbbr", "gbggggrrrbrbggbgg", "grbgbbgrggrrrgbbg", "grgggbggbrgrgrgrb", "ggrrgrbggbrbggrbr", "ggbbbrgrbgbrggrgb", "grgbggrbrrrgrbbbg", "bbrrbrrbgbrrggbgg", "rrgrrgbggbbbgbggr", "rgrbrbrbgrbrrrrgg", "rgrbrbgrgrggbbrgr", "brgrggrgrgbgrrggg", "grbggrrbbrrgrgbgg", "rgrbbrbrgggrgrrbg"  }));

        }

        public int solve(List<string> a)
        {
            int n = a.Count;
            int m = a[0].Length;
            int[] maxr = new int[m];
            int[] maxg = new int[m];
            int[] maxb = new int[m];

            int[] minr = new int[m];
            int[] ming = new int[m];
            int[] minb = new int[m];

            GetMaxArrays(a, n, m, maxr, maxg, maxb);
            GetMinArrays(a, n, m, minr, ming, minb);

            // Print<int>(maxr);
            // Print<int>(maxg);
            // Print<int>(maxb);

            // Print<int>(minr);
            // Print<int>(ming);
            // Print<int>(minb);

            int maxArea = int.MinValue;
            for(int i = 0; i < m; i++)
            {
                int leastr = int.MaxValue;
                int leastg = int.MaxValue;
                int leastb = int.MaxValue;
                for (int j = 0; j < n; j++)
                {
                    char c = a[j][i];
                    if(c == 'r')
                    {
                        leastr = Math.Min(j,leastr);
                    }
                    if(c == 'g')
                    {
                        leastg = Math.Min(j, leastg);
                    }
                    if (c == 'b')
                    {
                        leastb = Math.Min(j, leastb);
                    }
                    
                    if(c == 'r')
                    {
                        if (leastg != int.MaxValue)
                        {
                            var baseOfTriangle = j - leastg + 1;
                            var height = maxb[i] -i +1;
                            if (minb[i] != int.MaxValue)
                            {
                                height = Math.Max(height, i - minb[i] + 1);
                            }
                            var area = 0.5 * baseOfTriangle * height;
                            // Console.WriteLine(height + " " + baseOfTriangle + " " + area);
                            maxArea = Math.Max(maxArea, (int)Math.Ceiling(area));
                        }

                        if (leastb != int.MaxValue)
                        {
                            var baseOfTriangle = j - leastb + 1;
                            var height = maxg[i] - i + 1;
                            if (ming[i] != int.MaxValue)
                            {
                                height = Math.Max(height, i - ming[i] + 1);
                            }
                            var area = 0.5 * baseOfTriangle * height;
                            // Console.WriteLine(height + " " + baseOfTriangle + " " + area);
                            maxArea = Math.Max(maxArea, (int)Math.Ceiling(area));
                        }

                    }

                    if (c == 'g')
                    {
                        if (leastr != int.MaxValue)
                        {
                            var baseOfTriangle = j - leastr + 1;
                            var height = maxb[i] - i + 1;
                            if (minb[i] != int.MaxValue)
                            {
                                height = Math.Max(height, i - minb[i] + 1);
                            }
                            var area = 0.5 * baseOfTriangle * height;
                            // Console.WriteLine(height + " " + baseOfTriangle + " " + area);
                            maxArea = Math.Max(maxArea, (int)Math.Ceiling(area));
                        }

                        if (leastb != int.MaxValue)
                        {
                            var baseOfTriangle = j - leastb + 1;
                            var height = maxr[i] - i + 1;
                            if (minr[i] != int.MaxValue)
                            {
                                height = Math.Max(height, i - minr[i] + 1);
                            }
                            var area = 0.5 * baseOfTriangle * height;
                            // Console.WriteLine(height + " " + baseOfTriangle + " " + area);
                            maxArea = Math.Max(maxArea, (int)Math.Ceiling(area));
                        }

                    }

                    if (c == 'b')
                    {
                        if (leastg != int.MaxValue)
                        {
                            var baseOfTriangle = j - leastg + 1;
                            var height = maxr[i] - i + 1;
                            if (minr[i] != int.MaxValue)
                            {
                                height = Math.Max(height, i - minr[i] + 1);
                            }
                            var area = 0.5 * baseOfTriangle * height;
                            // Console.WriteLine(height + " " + baseOfTriangle + " " + area);
                            maxArea = Math.Max(maxArea, (int)Math.Ceiling(area));
                        }

                        if (leastr != int.MaxValue)
                        {
                            var baseOfTriangle = j - leastr + 1;
                            var height = maxg[i] - i + 1;
                            if (ming[i] != int.MaxValue)
                            {
                                height = Math.Max(height, i - ming[i] + 1);
                            }
                            var area = 0.5 * baseOfTriangle * height;
                            // Console.WriteLine(height + " " + baseOfTriangle + " " + area);
                            maxArea = Math.Max(maxArea, (int)Math.Ceiling(area));
                        }

                    }

                }

            }

            return Math.Max(0,maxArea);

        }

        private static void GetMaxArrays(List<string> a, int n, int m, int[] maxr, int[] maxg, int[] maxb)
        {
            for (int i = m - 1; i >= 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    char c = a[j][i];
                    ProcessForChar(m, maxr, i, c, 'r');
                    ProcessForChar(m, maxg, i, c, 'g');
                    ProcessForChar(m, maxb, i, c, 'b');
                }

            }
        }

        private static void ProcessForChar(int m, int[] maxc, int i, char c, char charToCompare)
        {
            if (c == charToCompare)
            {
                if (i < m - 1)
                {
                    maxc[i] = Math.Max(maxc[i], Math.Max(maxc[i + 1], i));
                }
                else
                {
                    maxc[i] = Math.Max(maxc[i], i);
                }
            }
            else
            {
                if (i < m - 1)
                {
                    maxc[i] = Math.Max(maxc[i], maxc[i + 1]);
                }
                else
                {
                    maxc[i] = Math.Max(maxc[i], -1);
                }
            }
        }

        private static void ProcessForCharMin(int m, int[] minc, int i, char c, char charToCompare)
        {
            if (c == charToCompare)
            {
                if (i > 0)
                {
                    minc[i] = Math.Min(minc[i], Math.Min(minc[i-1], i));
                }
                else
                {
                    minc[i] = Math.Min(minc[i], i);
                }
            }
            else
            {
                if (i > 0)
                {
                    minc[i] = Math.Min(minc[i], minc[i - 1]);
                }
                else
                {
                    minc[i] = Math.Min(minc[i], int.MaxValue);
                }
            }
        }

        private static void GetMinArrays(List<string> a, int n, int m, int[] minr, int[] ming, int[] minb)
        {
            FillArray(minr, int.MaxValue);
            FillArray(ming, int.MaxValue);
            FillArray(minb, int.MaxValue);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    char c = a[j][i];
                    ProcessForCharMin(m, minr, i, c, 'r');
                    ProcessForCharMin(m, ming, i, c, 'g');
                    ProcessForCharMin(m, minb, i, c, 'b');
                }

            }
        }

        private static void FillArray(int[] x, int val)
        {
            for(int i = 0; i < x.Length; i++)
            {
                x[i] = val;
            }
        }

        public static void Print<T>(IEnumerable<T> x)
        {
            var enumeration = x.GetEnumerator();
            while (enumeration.MoveNext())
            {
                Console.Write(enumeration.Current + "\t");
            }
            Console.WriteLine();
        }
    }
}
