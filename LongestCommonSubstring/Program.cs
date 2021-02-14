using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution S = new Solution();
            string input = "au";
            S.LengthOfLongestSubstring(input);
        }
        public class Solution
        {
            public int LengthOfLongestSubstring(string s)
            {
                if (s == "")
                    return 0;
                if (s.Length == 1)
                    return 1;
                Dictionary<char, int> dict = new Dictionary<char, int>();
                int j = 0, Max_len = 0;
                while (j < s.Length)
                {
                    if (!dict.ContainsKey(s[j]))
                    {
                        dict.Add(s[j], j);
                        j++;
                    }
                    else
                    {
                        Max_len = Math.Max(dict.Count, Max_len);
                        dict.Clear();
                    }

                }

                return Max_len;


            }
        }




    }
}
