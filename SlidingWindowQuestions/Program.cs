using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingWindowQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] input = new int[] {1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0};
            //  Solution S = new Solution();
            // S.LongestOnes(input, 2);
            Solution1 S = new Solution1();
            List<string> sol = new List<string>();
           sol= S.LengthOfLongestSubstring("awaglknagawunagwkwagl", 4);

        }
        public class Solution1
        {
            public List<string> LengthOfLongestSubstring(string s, int k)
            {
                List<string> sol = new List<string>();
                StringBuilder temp = new StringBuilder();
                Dictionary<int, string> dict = new Dictionary<int, string>();
                int j = 0,i = 0;
                while (j < s.Length && i < s.Length)
                {
                    while (j<s.Length && !dict.ContainsValue(s[j].ToString()) && j-i<k) {
                        
                            dict.Add(j, s[j].ToString());
                            temp.Append(s[j]);
                            j++;
                       }
                    while( j<s.Length && dict.ContainsValue(s[j].ToString()) && j - i < k)
                    {
                        dict.Remove(i);
                        temp.Remove(0, 1);
                        i++;
                    }
                    if (j - i == k)
                    {
                        if(!sol.Contains(temp.ToString()))
                        sol.Add(temp.ToString());
                        dict.Remove(i);
                        temp.Remove(0, 1);
                        i++;

                    }
                 
                }
                return sol;
            }

            public class Solution
            {
                public int LongestOnes(int[] A, int K)
                {
                    int i = 0, j = 0, count = 0, Max_count = 0, ref_ptr = 0;
                    Dictionary<int, int> dict = new Dictionary<int, int>();
                    while (i < A.Length)
                    {
                        while (j < A.Length && A[j] == 1)
                        {
                            dict.Add(j, 1);
                            j++;
                        }
                        while (j < A.Length && A[j] == 0 && K > 0)
                        {
                            dict.Add(j, 0);
                            K--;
                            j++;
                        }
                        if (j < A.Length && A[j] == 0 && K == 0)
                        {
                            if (A[i] == 0)
                                K++;
                            count = j - i;
                            dict.Remove(i);
                            i++;
                        }

                        Max_count = Math.Max(count, Max_count);
                    }
                    return Max_count;
                }
                public int NumKLenSubstrNoRepeats(string S, int K)
                {
                    int i = 0, j = 0, output = 0;
                    Dictionary<char, int> dict = new Dictionary<char, int>();
                    while (i < S.Length && j < S.Length)
                    {
                        if (!dict.ContainsKey(S[j]))
                        {
                            dict.Add(S[j], j);
                            if (j - i + 1 == K)
                            {
                                output++;
                                i++;
                            }

                            j++;
                        }
                        else
                        {
                            dict.Remove(S[i]);
                            i++;
                        }
                    }
                    return output;

                }


            }
        }
    }
}

