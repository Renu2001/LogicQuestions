using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOgic_Question
{
    public class PrimeNumber
    {
        //For one number to check
        public static void Prime()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            
            if(isPrime)
            {
                Console.WriteLine("Number{0} is prime", number);
            }
            else
            {
                Console.WriteLine("Number{0} is not prime", number);
            }
        }

        public static void ListofPrime()
        {
            
            Console.WriteLine("Enter Start Number");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Last Number");
            int end = Convert.ToInt32(Console.ReadLine());
            
            for (int i=start; i<=end; i++)
            {
                bool isPrime = true;

                if (i <= 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int j = 2; j <=i/2; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
