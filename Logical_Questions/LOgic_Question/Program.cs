using System.Text;

namespace LOgic_Question
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("=============================================================");
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", FibonacciSeries.fibonacci(i));
            }
            Console.WriteLine(Environment.NewLine);

            Console.Write("Fibbonacci Series of {0} is : {1} ", 10, FibonacciSeries.FibbonacciSeries1(n));
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("=============================================================");

        }
    }
}
