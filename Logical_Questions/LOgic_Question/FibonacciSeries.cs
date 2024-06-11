using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOgic_Question
{
    internal class FibonacciSeries
    {
        public static int fibonacci(int n)
        {
            int first = 0;
            int second = 1;
            int result = 0;
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            for (int i = 2; i <= n; i++)
            {
                result = first + second;
                first = second;
                second = result;
            }
            return result;
        }
        public static string FibbonacciSeries1(int n)
        {
            int a = 0, b = 1, c;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(a.ToString() + ",");
                c = a + b;
                a = b;
                b = c;
            }
            return sb.ToString().Remove(sb.Length - 1); ;
        }
    }
}
