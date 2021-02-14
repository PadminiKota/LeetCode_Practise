using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution S = new Solution();
            int[] input = new int[] {2,4,5,3,2};
            S.MaxOperations(input, 3);
        }
        public class Solution
        {
            public int MaxOperations(int[] nums, int k)
            {
                int temp = 0, output = 0;
                Dictionary<int, int> dict = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (!dict.ContainsKey(nums[i]))
                    {
                        temp = k - nums[i];
                        if (temp > 0)
                        {
                            if (!dict.ContainsKey(temp))
                                dict.Add(temp, 1);
                            else
                                dict[temp]++;
                        }
                    }
                    else
                    {
                        dict[nums[i]]--;
                        if(dict[nums[i]] ==0)
                        dict.Remove(nums[i]);
                        output++;
                    }

                }
                return output;


            }
        }
    }
}
