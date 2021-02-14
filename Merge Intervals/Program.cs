using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] input = new int[][]
            {
                new int[] {1,4},
                 new int[] {4,6},
                //new int[] {8,10},
                // new int[] {15,18},

            };
            Solution S = new Solution();
            S.Merge(input);
        }
        public class Solution
        {
            public class Pair
            {
                public int start;
                public int end;
                public Pair(int a, int b)
                {
                    this.start = a;
                    this.end = b;
                }
            }
            public int[][] Merge(int[][] intervals)
            {
                List<Pair> output = new List<Pair>();
                intervals = intervals.OrderBy(x => x[0]).ToArray();
                int i = 1;
                int start = intervals[0][0];
                int end = intervals[0][1];
                Pair intial_record = new Pair(start, end);
                output.Add(intial_record);
                while (i < intervals.Length)
                {
                    int x_compare = output[output.Count - 1].start;
                    int y_compare = output[output.Count - 1].end;
                    if (intervals[i][0] >= x_compare && intervals[i][0] <= y_compare)
                    {
                        int x = x_compare;
                        int y = 0;
                        if (intervals[i][1] > y_compare)
                            y = intervals[i][1];
                        else
                            y = y_compare;
                        output[output.Count - 1].start = x_compare;
                        output[output.Count - 1].end = y;
                        i = i + 1;
                    }
                    else
                    {
                        int x1 = intervals[i][0];
                        int y1 = intervals[i][1];
                        Pair p1 = new Pair(x1, y1);
                        output.Add(p1);
                        i++;
                    }


                }
                int[][] result = new int[output.Count][];
                for (int k = 0; k < output.Count; k++)
                {
                    result[k] = new int[2];
                    result[k][0] = output[k].start;
                    result[k][1] = output[k].end;
                }

                return result;

            }
        }
    }
}
