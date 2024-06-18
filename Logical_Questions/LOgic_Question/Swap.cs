using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOgic_Question
{
    internal class Swap
    {
        public static void SwapNumber(int a, int b)
        {
            Console.WriteLine("Before swapping"+" "+ a+", "+b);
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping"+" " + a + ", " + b);
        }

        public static void SwapNumber2(int a, int b)
        {
            Console.WriteLine("Before swapping" + " " + a + ", " + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("After swapping" + " " + a + ", " + b);
        }
        public static void SwapNumber3(int a, int b)
        {
            Console.WriteLine("Before swapping" + " " + a + ", " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After swapping" + " " + a + ", " + b);
        }
        public static void SwapNumber4(int a, int b)
        {
            Console.WriteLine("Before swapping" + " " + a + ", " + b);
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine("After swapping" + " " + a + ", " + b);
        }

        public static void SwapString(string a,string b)
        {
            Console.WriteLine("Before swapping" + " " + a + ", " + b);
            a = a + b;
            b = a.Substring(0, a.Length - b.Length);
            a = a.Substring(b.Length);
            Console.WriteLine("After swapping" + " " + a + ", " + b);
        }
    }
}
