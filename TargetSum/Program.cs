using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetSum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = new long[] {2,10,20};
            check_if_sum_possible(arr, 0);
        }


        /*
         * Complete the function below.
         */
        static bool check_if_sum_possible(long[] arr, long k)
        {
            return Helper(arr, 0, k, 0);

        }
        private static bool Helper(long[] arr, int i, long k, long Sum)
        {
            if (Sum == k && i!=0)
                return true;
            else if (arr.Length == i)
                return false;
            else
                return (Helper(arr, i + 1, k, Sum) || Helper(arr, i + 1, k, Sum + arr[i]));

        }




    }
}
