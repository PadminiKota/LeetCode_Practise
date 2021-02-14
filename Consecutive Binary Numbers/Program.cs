using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consecutive_Binary_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution S = new Solution();
            S.ConcatenatedBinary(12);
        }
        public class Solution
        {
            public int ConcatenatedBinary(int n)
            {
                string binaryformat = "";
                for (int i = 1; i <= n; i++)
                {
                    binaryformat += ToBinary(i);

                }
                return Toint(binaryformat);
            }
            private string ToBinary(int n)
            {
                if (n < 2)
                    return n.ToString();
                int divisor = n / 2;
                int reminder = n % 2;
                return ToBinary(divisor) + reminder;
            }
            private int Toint(string binary)
            {
                long result = 0;
                long current_result = 0;
                var reverse_binary = binary.Reverse().ToArray();
                for (int i = 0; i < reverse_binary.Count(); i++)
                {
                    int currentbit = reverse_binary[i];
                    if (currentbit == '1')
                    {
                        current_result = (long)Math.Pow(2, i);
                        current_result = current_result % 10000000007;
                        result += current_result;
                    }
                }
               // result = result % 10000000007;
                return (int)result;
            }
        }
    }
}
