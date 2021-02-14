using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solution S = new Solution();
            //S.GenerateParenthesis(3);
            find_all_well_formed_brackets(4);
        }

        /*
         * Complete the function below.
         */
        public static List<string> output = new List<string>();
        static string[] find_all_well_formed_brackets(int n)
        {
            Helper(n, n, "");
            return output.ToArray();
        }
        private static void Helper(int open, int close, string partial_sol)
        {
            if (open == 0 && close == 0)
            {
                output.Add(partial_sol.ToString());
                return;
            }

            if (open != 0)
                Helper(open - 1, close, partial_sol + "(");

            if (open > close)
                Helper(open, close - 1, partial_sol + ")");


        }


        public class Solution
        {
            public IList<string> GenerateParenthesis(int n)
            {
                IList<string> output = new List<string>();
                generate_Helper(n, 0, 0, output, new StringBuilder());
                return output;
            }
            private void generate_Helper(int n, int open, int close, IList<string> output, StringBuilder partial_sol)
            {
                if (open == n && open == close)
                {
                    output.Add(partial_sol.ToString());
                    partial_sol.Remove(0, partial_sol.Length);
                    return;
                }
                if (open < n)
                {
                    partial_sol.Append("(");
                    generate_Helper(n, open + 1, close, output, partial_sol);
                    partial_sol.Remove(0, partial_sol.Length);
                }
                if (close < open)
                {
                    partial_sol.Append(")");
                    generate_Helper(n, open, close + 1, output, partial_sol);
                    partial_sol.Remove(0, partial_sol.Length);
                }
            }
        }
    }
}
