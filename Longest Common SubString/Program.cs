using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Common_SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution S = new Solution();
            S.MinWindow("a", "aa");
        }
        public class Solution
        {
            public string MinWindow(string s, string t)
            {
                int start_pos = 0, minlen = int.MaxValue, end_pos = 0, required_cnt = 0, have_cnt = 0;
                int strt_ptr = 0, end_ptr = 0;
                var dict = new Dictionary<char, int>();
                for (int i = 0; i < t.Length; i++)
                {
                    if (!dict.ContainsKey(t[i]))
                        dict.Add(t[i], 1);
                    else
                    {
                        int val = dict[t[i]];
                        dict[t[i]] = val++;
                    }
                }
                have_cnt = dict.Count;
                while (end_ptr < s.Length)
                {
                    if(dict.ContainsKey(s[end_ptr]))
                    {
                          dict[s[end_ptr]]--;
                        if (dict[s[end_ptr]]<=0)
                            required_cnt++;
                     }
                    end_ptr++;
                    while (required_cnt == have_cnt)
                    {
                        if (minlen > end_ptr - strt_ptr)
                        {
                            minlen = end_ptr - strt_ptr;
                            start_pos = strt_ptr;
                            end_pos = end_ptr;
                        }
                         if (dict.ContainsKey(s[strt_ptr]))
                            {
                                dict[s[strt_ptr]]++;
                                required_cnt--;
                              }
                            strt_ptr++;
                    }
                }

                return s.Substring(start_pos, (end_pos - start_pos));
            }
        }
    }
}
