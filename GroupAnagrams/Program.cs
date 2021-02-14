using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            Solution S = new Solution();
            S.GroupAnagrams(input);
        }
        public class Solution
        {
            public IList<IList<string>> GroupAnagrams(string[] strs)
            {
                Dictionary<string, IList<string>> Map = new Dictionary<string, IList<string>>();
                foreach (string s in strs)
                {
                    char[] key = s.ToCharArray();
                    Array.Sort(key);
                    string Key_str = new string(key);
                    if (!Map.ContainsKey(Key_str))
                    {
                        Map[Key_str] = new List<string>();
                        Map[Key_str].Add(s.ToString());
                    }
                    else
                    {
                        IList<string> partial_sol = Map[Key_str];
                        partial_sol.Add(s.ToString());
                        Map[Key_str] = partial_sol;
                    }
                }
                IList<IList<string>> result = new List<IList<string>>();
                foreach (var group in Map)
                {
                    result.Add(group.Value);
                }
                return result;

            }
        }
    }
}
