using System.Text;

namespace LOgic_Question
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Console.WriteLine("=============================================================");
            //Console.WriteLine("Enter number");
            //int n = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("{0} ", FibonacciSeries.fibonacci(i));
            //}
            //Console.WriteLine(Environment.NewLine);

            //Console.Write("Fibbonacci Series of {0} is : {1} ", 10, FibonacciSeries.FibbonacciSeries1(n));
            //Console.WriteLine(Environment.NewLine);
            //Console.WriteLine("=============================================================");

            Console.WriteLine("=============================================================");
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Swapping with third variable");
            Swap.SwapNumber(a, b);
            Console.WriteLine("Swapping without third variable with / & *");
            Swap.SwapNumber2(a,b);
            Console.WriteLine("Swapping without third variable with + & -");
            Swap.SwapNumber3(a, b);
            Console.WriteLine("Swapping without third variable with ^");
            Swap.SwapNumber4(a, b);
            Console.WriteLine("=============================================================");
            Console.WriteLine("Enter String");
            string c = Console.ReadLine();
            string d = Console.ReadLine();
            Console.WriteLine("Swapping String");
            Swap.SwapString(c, d);
            Console.WriteLine("=============================================================");

        }
    }
}
