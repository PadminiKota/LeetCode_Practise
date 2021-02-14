using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] {0};
            int[] nums2 = new int[] {1};
            Solution S = new Solution();
            S.Merge(nums1,0,nums2,1);
          //  S.ContainsDuplicate(nums);
           // int x = 321;
          //  string s=x.ToString();

        }
        public class Solution
        {
            public void Merge(int[] nums1, int m, int[] nums2, int n)
            {
                int k = m + n;
                while (n != 0 & m!=0)
                {
                    if (nums2[n - 1] > nums1[m - 1])
                    {
                        nums1[k - 1] = nums2[n - 1];
                        k--;
                        n--;
                    }
                    else if (nums2[n - 1] < nums1[m - 1])
                    {
                        nums1[k - 1] = nums1[m - 1];
                        m--;
                        k--;
                    }
                    else if (nums2[n - 1] == nums1[m - 1])
                    {
                        nums1[k - 1] = nums1[n - 1];
                        k--; n--;
                    }
                }
                if (m == 0 && n > 0)
                {
                    m = n;
                }


            }
        }
        public class Solution10
        {
            public bool IsAnagram(string s, string t)
            {
                Dictionary<string, int> dict = new Dictionary<string, int>();
                int cnt = 0;
                if (s.Length > t.Length)
                {
                    string temp = s;
                    s = t;
                    t = temp;
                }
                for (int i = 0; i < s.Length; i++)
                {
                    if (!dict.ContainsKey(s[i].ToString()))
                        dict.Add(s[i].ToString(), 1);
                    else
                    {
                        cnt = dict[s[i].ToString()];
                        cnt++;
                        dict[s[i].ToString()] = cnt;
                        cnt = 0;
                    }

                }
                for (int j = 0; j < t.Length; j++)
                {
                    if (!dict.ContainsKey(t[j].ToString()))
                        return false;
                    else
                    {
                        cnt = dict[t[j].ToString()];
                        if (cnt > 0)
                        {
                            cnt--;
                            dict[t[j].ToString()] = cnt;
                        }
                        else
                            dict.Remove(t[j].ToString());
                    }
                }
                return true;
            }
        }
        public class Solution7
        {
            public int[] Intersect(int[] nums1, int[] nums2)
            {
                Array.Sort(nums1);
                Array.Sort(nums2);
                List<int> output = new List<int>();
                for (int i = 0; i < nums1.Length; i++)
                {
                    for (int j = 0; j < nums2.Length; j++)
                    {
                        if (nums1[i] == nums2[j])
                        {
                            output.Add(nums1[i]);
                            i++; j++;
                        }
                        else if (nums1[i] > nums2[j])
                            j++;
                        else if (nums1[i] < nums2[j])
                            i++;
                    }
                }

                return output.ToArray();
            }
        }
        public class Solution5
        {
            public void Rotate(int[] nums, int k)
            {
                Dictionary<int, int> dict = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (!dict.ContainsValue(nums[i]))
                    {
                        dict.Add(((i + k) % nums.Length), nums[i]);
                    }
                }
                foreach (var item in dict)
                {
                    nums[item.Key] = item.Value;
                }

            }
        }
        public class Solution3
        {
            public int[] PlusOne(int[] digits)
            {
                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    if (digits[i] == 9)
                        digits[i] = 0;
                    else
                        digits[i]++;
                    return digits;
                }
                int n = digits.Length;
                digits = new int[n + 1];
                digits[0] = 1;
                return digits;
            }
        }
        //public class Solution
        //{
        //    public int FirstUniqChar(string s)
        //    {
        //        Dictionary<string, int> dict = new Dictionary<string, int>();
        //        int Index = int.MaxValue;
        //        for (int i = 0; i < s.Length; i++)
        //        {
        //            if (!dict.ContainsKey(s[i].ToString()))
        //                dict.Add(s[i].ToString(), i);
        //            else
        //                dict.Remove(s[i].ToString());
        //        }
        //        if (dict.Count <= 0)
        //            return -1;
        //        foreach (var item in dict.Keys)
        //        {
        //            Index = Math.Min(Index, dict[item]);
        //        }
        //        return Index;
        //    }
        //}
        //public class Solution
        //{
        //    public bool ContainsDuplicate(int[] nums)
        //    {
        //        Array.Sort(nums);
        //        for (int i = 1; i <= nums.Length - 1; i++)
        //        {
        //            if (nums[i - 1] == nums[i])
        //                return true;
        //        }
        //        return false;
        //    }
        //}
        //public class Solution
        //{
        //    public void Rotate(int[] nums, int k)
        //    {
        //        int temp = 0, j = nums.Length - 1;
        //        for (int i = j; i >= 0 && k != 0; i--)
        //        {
        //            if (i == j)
        //                temp = nums[i];
        //            else if (i == 0)
        //            {
        //                nums[i + 1] = nums[i];
        //                nums[i] = temp;
        //                k--;
        //                i = j;
        //            }
        //            else
        //            {
        //                nums[i + 1] = nums[i];
        //            }
        //        }

        //    }
        //}
    }
}
