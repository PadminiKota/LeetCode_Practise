using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotatedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution S = new Solution();
            int[] input = new int[] { 4, 5, 6, 7, 8, 1, 2, 3 };
            S.Search(input, 8);
        }
        public class Solution
        {
            public int Search(int[] nums, int target)
            {
                if (nums[0] == target)
                    return 0;
                int L = 0, H = nums.Length - 1;
                int M = 0;
                while (L <=H)
                {
                    M = L + (H - L) / 2;
                    if (nums[M] == target)
                        return M;
                    else if (nums[M] >= target)
                    {
                        if (target >= nums[L] && target <= nums[M])
                            H = M - 1;
                        else
                            L = M + 1;
                    }
                    else
                    {
                        if (target <= nums[H] && target >= nums[M])
                            L = M + 1;
                        else
                            H = M - 1;
                    }
                }
                return -1;
            }

        }



    }
}
