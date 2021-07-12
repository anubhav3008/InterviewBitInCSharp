using System;
using System.Collections.Generic;
using Utils;
namespace Concentric2D
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays.Print2D<int>(new Program().prettyPrint(1));
        }

        public List<List<int>> prettyPrint(int a)
        {
            List<List<int>> ans = new List<List<int>>();
            InnitializeList(ans, a * 2 - 1);
            int top = 0, bottom = 2 * a - 2, left = 0, right = 2 * a - 2;
            int start = a;

            while (left <= right)
            {
                for (int i = left; i <= right; i++)
                {
                    ans[top][i] = start;
                    ans[bottom][i] = start;
                }

                for (int i = top; i <= bottom; i++)
                {
                    ans[i][right] = start;
                    ans[i][left] = start;
                }
                left++;
                right--;
                top++;
                bottom--;
                start--;
            }
            return ans;
        }

        private void InnitializeList(List<List<int>> ans, int size)
        {
            for(int i = 0; i < size; i++)
            {
                List<int> row = new List<int>(size);
                for(int j = 0; j < size; j++)
                {
                    row.Add(0);
                }
                ans.Add(row);
            }
        }
    }
}
