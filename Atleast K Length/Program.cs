using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atleast_K_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution S = new Solution();
            int[] nums = new int[] { 1, 0, 0, 0, 1, 0, 0, 1 };
            S.KLengthApart(nums, 2);
        }
        public class Solution
        {
            public bool KLengthApart(int[] nums, int k)
            {
                bool retval = false;
                int i = 0, j = 0;
                while (i < nums.Length && j < nums.Length)
                {
                    while (i < nums.Length && j < nums.Length && nums[i] == 0 && nums[j] == 0)
                    {
                        i++; j++;
                    }
                    j++;
                    while (i < nums.Length && j < nums.Length && nums[j] == 0)
                    {
                        j++;
                    }
                    if (i < nums.Length && j < nums.Length && j - i - 1 >= k && nums[j] == 1)
                    {
                        retval = true;
                        i = j;
                    }
                    else
                        return false;
                }
                return retval;

            }
        }
    }
}
