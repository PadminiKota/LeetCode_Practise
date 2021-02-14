using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestSubarrayK
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 45, 32, 97, 60, 66 };
            Solution S = new Solution();
            S.LargestSubarray(nums,1);
        }
        public class Solution
        {
            public int[] LargestSubarray(int[] nums, int k)
            {
                if (nums.Length == 1 && k == 1)
                    return nums;
                int[] temp = new int[k];
                int i = 0, j = 0, m = 0;
                while (i < nums.Length - k && j < nums.Length)
                {
                    while (j < nums.Length - k && nums[j + 1] > nums[i])
                    {
                        j++;
                        i++;
                    }
                    while (m != k && temp[0]< nums[j])
                    {
                        temp[m] = nums[j];
                        m++;
                        j++;
                    }
                    if (nums.Length - j > k)
                    {
                        j = i + 1;
                        i=j;
                        m = 0;
                    }


                }

                return temp;
            }
        }
    }
}
