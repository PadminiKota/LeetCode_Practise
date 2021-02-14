using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] input = new int[3][]{
                   new int[] {3,3,1,1},
                     new int[] {2,2,1,2},
                    new int[] {1,1,1,2}
                   };
            Solution S = new Solution();
            S.DiagonalSort(input);
        }
        public class Solution
        {
            public int[][] DiagonalSort(int[][] mat)
            {
                int i = 0, k = 0;
                int col_count = mat.GetLength(0);
                int row_count = mat.Length;
                List<int> diagonal = new List<int>();
                for (int j = 0; j < row_count; j++)
                {
                    i = j; k = 0;
                    while (i < row_count && k < col_count)
                    {
                        diagonal.Add(mat[i][k]);
                        i++;
                        k++;

                    }
                    mat = digonal_sort(mat, diagonal, j, 0);
                    diagonal.Clear();
                }

                for (int j = 1; j < col_count; j++)
                {
                    k = j; i = 0;
                    while (i < row_count && k <=col_count)
                    {
                        diagonal.Add(mat[i][k]);
                        i++;
                        k++;
                    }
                    mat = digonal_sort(mat, diagonal, 0, j);
                    diagonal.Clear();

                }
                return mat;
            }
            private int[][] digonal_sort(int[][] input, List<int> diagonal, int m, int n)
            {
                List<int> sort_List = diagonal.OrderBy(x => x).ToList();
                while (sort_List.Count != 0)
                {
                    input[m][n] = sort_List[0];
                    sort_List.RemoveAt(0);
                    m++;
                    n++;
                }
                return input;

            }
        }
    }
}
