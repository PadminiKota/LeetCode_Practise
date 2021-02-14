using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Serach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[6] { 5, 7, 7, 8, 8, 10 };
            Solution S = new Solution();
            S.SearchRange(nums, 6);
        }
        public class Solution
        {
            public int[] SearchRange(int[] nums, int target)
            {
                int[] output = new int[] { -1, -1 };
                if (nums.Length == 1 && nums[0] == target)
                {
                    output[0] = 0;
                    output[1] = 0;
                    return output;
                }
                output[0] = BinarySearch_Target_left(nums, 0, nums.Length, target);
                if (output[0] == nums.Length || output[0] == -1)
                    return output;
                output[1] = BinarySearch_Target_right(nums, output[0], nums.Length, target);
                return output;

           }

            private int BinarySearch_Target_left(int[] nums, int start, int end, int target)
            {
                int mid = 0;
                while (start < end)
                {
                    mid = start + (end - start) / 2;
                    if (nums[mid] >= target)
                    {
                        end = mid;
                    }
                    else if (nums[mid] < target)
                    {
                        start = mid + 1;
                    }
                }
                return start;
            }
            private int BinarySearch_Target_right(int[] nums, int start, int end, int target)
            {
                int mid = 0;
                while (start < end)
                {
                    mid = start + (end - start) / 2;
                    if (nums[mid] > target)
                    {
                        end = mid;
                    }
                    else if (nums[mid] <= target)
                    {
                        start = mid + 1;
                    }
                }
                return start-1;
            }
        }
        //public class Solution
        //{
        //    public int[] SearchRange(int[] nums, int target)
        //    {
        //        int start = 0, end = nums.Length, mid = 0;
        //        int[] output = new int[] { -1, -1 };
        //        if (nums.Length == 1 && nums[0] == target)
        //        {
        //            output[0] = 0;
        //            output[1] = 0;
        //            return output;
        //        }
        //        while (start < end)
        //        {
        //            mid = start + (end - start) / 2;
        //            if (nums[mid] == target)
        //            {

        //                if (mid - 1 >= start && nums[mid - 1] == target)
        //                {
        //                    output[0] = mid - 1;
        //                    output[1] = mid;
        //                }
        //                else if (mid + 1 < end && nums[mid + 1] == target)
        //                {
        //                    output[0] = mid;
        //                    output[1] = mid + 1;
        //                }
        //                else
        //                {
        //                    output[0] = mid;
        //                    output[1] = 0;
        //                }
        //                return output;
        //            }
        //            else if (nums[mid] < target)
        //            {
        //                start = mid + 1;
        //            }
        //            else if (nums[mid] > target)
        //            {
        //                end = mid - 1;
        //                if(end==0 & nums[end]==target)
        //                {
        //                    if(output[0]==-1 && output[1]==-1)
        //                    {
        //                        output[0] = 0;
        //                        output[1] = 1;
        //                    }
        //                }
        //            }
        //        }
        //        return output;

        //    }
        //}
    }
}
