using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotatedArray_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution S = new Solution();
            int[] input = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            S.Search(input, 2);
        }
        public class Solution
        {
            public int Search(int[] nums, int target)
            {
                if (nums[0] == target)
                    return 0;
                int L = 0, H = nums.Length - 1;
                int output = -1;
                while (L < H)
                {
                    int M = L + (H - L) / 2;
                    if (nums[M] == target)
                        return nums[M];
                    if (nums[M] > target && nums[M] > nums[L])
                    {
                        L = M + 1;
                    }
                    else
                    {
                        H = M;
                    }

                }

                return output;
            }
        }

    }
}
