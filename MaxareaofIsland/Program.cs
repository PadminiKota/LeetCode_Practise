using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxareaofIsland
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution S = new Solution();
            int[][] grid = new int[][]
            {
                new int[] {1, 1, 0, 0, 0 },
                 new int[] {1,1,0,0,0 },
                  new int[] {0,0,0,1,1 },
                   new int[] { 0,0,0,1,1},

            };
            S.MaxAreaOfIsland(grid);

     
        }
        public class Solution
        {
            public int MaxAreaOfIsland(int[][] grid)
            {
                int col_len = grid.Length;
                int row_len = grid[0].Length;
                int Max_area = 0;
                for (int i = 0; i < col_len; i++)
                {
                    for (int j = 0; j < row_len; j++)
                    {
                        if (grid[i][j] == 1)
                        {
                            int Area = DFS_Helper(grid, i, j);
                            Max_area = Math.Max(Max_area, Area);
                        }
                    }
                }
                return Max_area;

            }
            private int DFS_Helper(int[][] grid, int col, int row)
            {
                if (col >= grid.Length || col < 0 || row >= grid[0].Length || row < 0)
                    return 0;
                if (grid[col][row] == 0)
                    return 0;
                grid[col][row] =0;
                var adj_lst = new int[][]
                {
                new int[] { 0,1 },
                new int[] {0,-1 },
                new int[] { 1,0 },
                new int[] {-1,0 }};
                int retval = 0;
                foreach (var dir in adj_lst)
                {
                    int nexti = col+(int)dir.GetValue(0);
                    int nextj = row+(int)dir.GetValue(1);
                    retval = 1 + DFS_Helper(grid, nexti, nextj);
                }
                return retval;
            }
        }
    }
}
