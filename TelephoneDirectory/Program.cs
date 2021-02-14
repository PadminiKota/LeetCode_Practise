using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Solution S = new Solution();
            S.LetterCombinations("23");
        }
        public class Solution
        {
            IList<string> output = new List<string>();
            Dictionary<int, string> Mapping = new Dictionary<int, string>{
            {2,"abc"},
            {3,"def"},
            {4,"ghi"},
            {5,"jkl"},
            {6,"mno"},
            {7,"pqrs"},
            {8,"tuv"},
            {9,"wxyz"}
        };
            public IList<string> LetterCombinations(string digits)
            {
                Helper_combinations(0, new List<string>(), digits);
                return output;
            }
            private void Helper_combinations(int i, List<string> partial_sol, string digits)
            {
                if (i == digits.Length)
                {
                    output.Add(string.Join("", partial_sol.ToArray()));
                }
                foreach (char c in Mapping[Int32.Parse(digits[i].ToString())])
                {
                    partial_sol.Add(c.ToString());
                    Helper_combinations(i + 1, partial_sol, digits);
                    partial_sol.RemoveAt(partial_sol.Count - 1);
                }
            }
        }
    }
}
